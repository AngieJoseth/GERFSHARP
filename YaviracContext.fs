namespace CrudJirafa.Models

open Microsoft.EntityFrameworkCore


type ProductoContext(options: DbContextOptions)=
    inherit DbContext(options)

    [<DefaultValue>]
    val mutable private productos: DbSet<Productos>
    member __.Productos
        with get() = __.productos
        and private set valor = __.productos <- valor
    
    override __.OnConfiguring optionsBuilder =
        if not optionsBuilder.IsConfigured then
            optionsBuilder.UseSqlServer @"Server=(localdb)\mssqllocaldb;Database=tienda;" |> ignore

    override __.OnModelCreating modelBuilder =
        modelBuilder.Entity<Productos>(fun entity ->
            entity.HasKey(fun e -> e.Codigo :> obj ) |> ignore

            entity.Property(fun e -> e.Nombre)
                .IsRequired()
                .HasMaxLength(50) |> ignore
            
            entity.Property(fun e -> e.Unidad)
                .IsRequired()
                .HasMaxLength(50) |> ignore
            
            entity.Property(fun e -> e.Precio)
                .HasColumnType("float") |> ignore
        ) |> ignore


// type ProvContext(options: DbContextOptions)=
//     inherit DbContext(options)

//     [<DefaultValue>]
//     val mutable private productos: DbSet<Proveedores>
//     member __.Proveedores
//         with get() = __.productos
//         and private set valor = __.productos <- valor
    
//     override __.OnConfiguring optionsBuilder =
//         if not optionsBuilder.IsConfigured then
//             optionsBuilder.UseSqlServer @"Server=(localdb)\mssqllocaldb;Database=tienda;" |> ignore

//     override __.OnModelCreating modelBuilder =
//         modelBuilder.Entity<Proveedores>(fun entity ->
//             entity.HasKey(fun e -> e.Ruc :> obj ) |> ignore

//             entity.Property(fun e -> e.Nombre)
//                 .IsRequired()
//                 .HasMaxLength(50) |> ignore
            
//             entity.Property(fun e -> e.Direccion)
//                 .IsRequired()
//                 .HasMaxLength(50) |> ignore
            
//             entity.Property(fun e -> e.Telefono)
//                 .HasColumnType("int") |> ignore
            
//             entity.Property(fun e -> e.Correo)
//                 .IsRequired()
//                 .HasMaxLength(50) |> ignore
//         ) |> ignore
