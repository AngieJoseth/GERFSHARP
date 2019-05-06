module Proveedores.Types

type Model =
    { Ruc: int
      Nombre : string
      Direccion : string
      Telefono : int
      Correo : string }

type Msg =
    | ChangeRuc of int
    | ChangeNombre of string
    | ChangeDireccion of string
    | ChangeTelefono of int
    | ChangeCorreo of string
