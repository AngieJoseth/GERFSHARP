module App.State

open Elmish
open Elmish.Browser.Navigation
open Elmish.Browser.UrlParser
open Fable.Import.Browser
open Global
open Types

let pageParser: Parser<Page->Page,Page> =
    oneOf [
           map Proveedor (s "proveedor")
           map Home (s "home")
            ]

let urlUpdate (result : Page option) model =
    match result with
    | None ->
        console.error("Error parsing url")
        model, Navigation.modifyUrl (toHash model.CurrentPage)
    | Some page ->
        { model with CurrentPage = page }, []

let init result =
   // let (counter, counterCmd) = Counter.State.init()
    let (proveedor, proveedorCmd) = Proveedores.State.init()
    let (model, cmd) =
        urlUpdate result
          { CurrentPage = Home
            Proveedor = proveedor }

    model, Cmd.batch [ cmd
                      // Cmd.map CounterMsg counterCmd
                       Cmd.map ProveedorMsg proveedorCmd ]

let update msg model =
    match msg with
    | ProveedorMsg msg ->
        let (proveedor, proveedorCmd) = Proveedores.State.update msg model.Proveedor
        { model with Proveedor = proveedor }, Cmd.map ProveedorMsg proveedorCmd
