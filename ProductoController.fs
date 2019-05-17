module CrudJirafa.ProductoController

open FSharp.Control.Tasks.V2
open Giraffe
open CrudJirafa.Models
open Microsoft.AspNetCore.Http
open Microsoft.EntityFrameworkCore
open System

let encontrarAsync (dbSet: DbSet<_>)(key: obj)=
    task {
        match! dbSet.FindAsync key with
        | x when isNull (x :> obj ) -> return None
        | y -> return Some y
    }

let getAll next (ctx: HttpContext) =
    task {
        use baseContext= ctx.GetService<ProductoContext> ()
        return! Successful.OK baseContext.Productos next ctx
    }

let getById (codigo: int) next (ctx: HttpContext) =
    task {
        use dbContext = ctx.GetService<ProductoContext> ()
        match! encontrarAsync dbContext.Productos codigo with
        | Some producto -> return! Successful.OK producto next ctx
        | None -> return! RequestErrors.NOT_FOUND (sprintf "El producto %i no se puedo encontrar" codigo) next ctx
   }

let put (codigo: int) next (ctx: HttpContext) =
    task {
        let! modificarProducto = ctx.BindJsonAsync<Productos> ()
        if codigo = modificarProducto.Codigo then
            use dbContext = ctx.GetService<ProductoContext> ()
            dbContext.Entry(modificarProducto).State <- EntityState.Modified
            try
                let! _ = dbContext.SaveChangesAsync ()
                return! Successful.NO_CONTENT next ctx
            with
            | :? DbUpdateConcurrencyException ->
                match! dbContext.Productos.AnyAsync (fun e -> e.Codigo = codigo) with
                | true  -> return! RequestErrors.BAD_REQUEST "Concurrency exception when trying to update the product" next ctx
                | false -> return! RequestErrors.NOT_FOUND (sprintf "Producto %i no se pudo encontrar" codigo) next ctx
        else
            return! RequestErrors.BAD_REQUEST (sprintf "The Codigo in the URL %i doesn't match the Codigo of the producto %i" codigo modificarProducto.Codigo) next ctx
    }

let post next (ctx: HttpContext) =
    task { 
        let! nuevoProducto = ctx.BindJsonAsync<Productos> ()
        use dbContext = ctx.GetService<ProductoContext> ()
        dbContext.Productos.Add nuevoProducto |> ignore
        try
            let! _ = dbContext.SaveChangesAsync ()
            return! Successful.CREATED nuevoProducto next ctx
        with
        | :? DbUpdateException as ex ->
            match! dbContext.Productos.AnyAsync (fun e -> e.Codigo = nuevoProducto.Codigo) with
            | true -> return! RequestErrors.CONFLICT (sprintf "Ya existe un producto con el codigo=%i en la base de datos" ) next ctx
            | false -> return! RequestErrors.BAD_REQUEST ex.Message next ctx
    }

let delete (codigo: int) next (ctx: HttpContext) =
    task {
        use dbContext = ctx.GetService<ProductoContext> ()
        match! encontrarAsync dbContext.Productos codigo with
        | Some producto ->
            dbContext.Productos.Remove producto |> ignore
            let! _ = dbContext.SaveChangesAsync ()
            return! Successful.OK producto next ctx
        | None ->
            return! RequestErrors.NOT_FOUND (sprintf "Producto %i no se encontro" codigo) next ctx
            }


// let getAll1 next (ctx: HttpContext) =
//     task {
//         use baseContext= ctx.GetService<ProvContext> ()
//         return! Successful.OK baseContext.Proveedores next ctx
//     }