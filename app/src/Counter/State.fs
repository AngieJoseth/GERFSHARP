module Counter.State

open Elmish
open Types


let init () : Model * Cmd<Msg> =
  "", []

let update msg model =
  match msg with
  | Codigo str ->
      str, []
  | Nombre str ->
      str, []
  | Cantidad  str ->
      str, []
  | Unidad str ->
      str,[]
  | Precio str -> 
      str,[]
