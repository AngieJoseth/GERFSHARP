module App.View

open Elmish
open Elmish.Browser.Navigation
open Elmish.Browser.UrlParser
open Fable.Core
open Fable.Core.JsInterop
open Fable.Import
open Fable.Import.Browser
open Types
open App.State
open Global

importAll "../sass/main.sass"
open Fable.Helpers.React.Props
open Fable.Helpers.React


let root model dispatch =

  let pageHtml page =
    match page with
    | Page.Home -> Home.View.root
    | Proveedor -> Proveedores.View.root model.Proveedor (ProveedorMsg >> dispatch)
    | Productos -> Productos.View.root1  model.Productos  (ProductosMsg >> dispatch )
    | Pedidos -> failwith "Not Implemented" 
   

  div
    []
    [ Navbar.View.root

      div[]
         [pageHtml model.CurrentPage]
      
     ]

open Elmish.React
open Elmish.Debug
open Elmish.HMR

// App
Program.mkProgram init update root
|> Program.toNavigable (parseHash pageParser) urlUpdate
#if DEBUG
|> Program.withDebugger
#endif
|> Program.withReact "elmish-app"
|> Program.run
