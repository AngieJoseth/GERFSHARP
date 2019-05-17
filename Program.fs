open Giraffe
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.EntityFrameworkCore
open Microsoft.Extensions.DependencyInjection
open System
open CrudJirafa.Models
open CrudJirafa.ProductoController

let webApp=
    choose [
        subRoute "/productos"
            (choose [
                GET >=> choose [
                    route "/" >=> getAll
                    routef "/%i" getById]
                POST >=> post
                PUT >=> routef "/%i" put
                DELETE >=> routef "/%i" delete ] ) 
        RequestErrors.NOT_FOUND "Resource not found, may be your URL is wrong?"   
        // subRoute "/proveedores"
        //         (choose [
        //             GET >=> choose [
        //                     route "/" >=> getAll1 ]
        //         ])
        // RequestErrors.NOT_FOUND "Resource not found, may be your URL is wrong?"   
        ]

let configureApp (app: IApplicationBuilder) =
    app.UseGiraffe webApp
    //app.UseGiraffe webApp1 

let serviciosConfigurados (services: IServiceCollection)=
    let conexion = @"Server=(localdb)\mssqllocaldb;Database=tienda;"
    services
        .AddGiraffe()
        .AddDbContext<ProductoContext>(fun options -> options.UseSqlServer conexion |> ignore )
       // .AddDbContext<ProvContext>(fun options -> options.UseSqlServer conexion |> ignore )
        |> ignore

[<EntryPoint>]
let main argv =
    WebHostBuilder()
        .UseKestrel()
        .Configure(Action<_> configureApp)
        .ConfigureServices(serviciosConfigurados)
        .Build()
        .Run()
    0 
 