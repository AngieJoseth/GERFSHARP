module Productos.State

open Elmish
open Types

let init()=
    { Codigo = 0
      Nombre = ""
      Cantidad = 0
      Unidad = ""
      Precio = 0.
      Proveedor = "" }, Cmd.none

//-----UPDATE

let update (msg:Msg) (model:Model) =
    match msg with
    | ChangeCodigo codigo ->
        { model with Codigo = codigo }, Cmd.none
    | ChangeNombre nombre ->
        { model with Nombre = nombre }, Cmd.none
    | ChangeCantidad cantidad ->
        { model with Cantidad = cantidad }, Cmd.none
    | ChangeUnidad unidad ->
        { model with Unidad = unidad }, Cmd.none
    | ChangePrecio precio ->
        { model with Precio = precio }, Cmd.none
    | ChangeProveedor proveedor ->
        { model with Proveedor = proveedor }, Cmd.none