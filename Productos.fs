namespace CrudJirafa.Models

open System

[<CLIMutable>]

type Productos = {
    Codigo : int
    Nombre : string
    Unidad: string
    Precio: float
}

type Proveedores = {
    Ruc : bigint
    Nombre : string
    Direccion : string
    Telefono : int
    Correo : string
}