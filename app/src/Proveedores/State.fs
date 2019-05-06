module Proveedores.State

open Elmish
open Types

let init() =
    { Ruc = 0
      Nombre = ""
      Direccion = ""
      Telefono = 0
      Correo = ""}, Cmd.none

// UPDATE

let update (msg:Msg) (model:Model)  =
    match msg with
    | ChangeRuc ruc ->
        { model with Ruc = ruc }, Cmd.none

    | ChangeNombre nombre ->
        { model with Nombre = nombre }, Cmd.none

    | ChangeDireccion direccion ->
        { model with Direccion = direccion }, Cmd.none

    | ChangeTelefono telefono ->
        { model with Telefono = telefono }, Cmd.none

    | ChangeCorreo correo ->
        { model with Correo = correo }, Cmd.none


