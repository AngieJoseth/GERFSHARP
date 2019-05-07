module Productos.View

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Types 

let root1 model dispatch  =
            div [ ClassName "columns"]
              [ aside [ ClassName "menu-list is-left"]
                                [ ul [ ClassName "menu-list"
                                       Style [Background "#424242"
                                              LineHeight "3.50"
                                              Height "590px"
                                              Display "block"
                                              Width "200px"
                                              Padding "5px" ] ]
                                      [ li [ Style [Background "#A4A4A4" ]] [a [] [str "Productos"] ]
                                        li [ Style [Background "#A4A4A4" ]] [a [ ] [str "Proveedor"]]] ]
                div [ ClassName "column is-offset-one-fifth"] [ 
                br[]
                div [ClassName "card-block is-centered"
                     Style[ Width "550px"
                            Height "500px"
                            Background "#F2F2F2"
                            BorderRadius 8
                            ] ]

                        [ header
                            [ ClassName "card-header"
                              Style[Background "#D8D8D8"
                                    BorderRadius 8]]
                            [ p[ClassName "card-header-title"][str "FORMULARIO DE PRODUCTOS"]]

                          div
                            [ClassName "card-content is-centered" ]
                            [ div
                                [ClassName "field is-grouped"]
                                [ div
                                    [ClassName "control"]
                                    [ label [ClassName "label"]
                                            [str "Código"]
                                      p [ ClassName "control has-icons-right"]
                                        [ input [ ClassName " input"
                                                  Type "text"
                                                  Placeholder "Código"
                                                  OnChange (fun ev -> ev.target?value |> int |> ChangeCodigo |> dispatch)]
                                          span  [ ClassName "icon is-small is-right"]
                                                [i [ ClassName "fas fa-barcode"][]]]

                                                ]]
                              div
                                [ClassName "control"]
                                [ label [ClassName "label"]
                                        [str "Nombre Producto"]
                                  p [ ClassName "control has-icons-right"]
                                [ input [ ClassName " input"
                                          Type "text"
                                          Placeholder "Nombre Producto"
                                          OnChange (fun ev -> ev.target?value |> string |> ChangeNombre|> dispatch) ]
                                  span  [ ClassName "icon is-small is-right"]
                                                [i [ ClassName "fas fa-edit"][]]] ]
                              
                              div
                                [ClassName "field is-grouped"]
                                [ div
                                    [ClassName "control"]
                                    [ label [ClassName "label"]
                                            [str "Cantidad"]
                                      p [ ClassName "control has-icons-right"]
                                        [ input [ ClassName " input"
                                                  Type "number"
                                                  Placeholder "Cantidad"
                                                  OnChange (fun ev -> ev.target?value |> int |> ChangeCantidad |> dispatch)]
                                          span  [ ClassName "icon is-small is-right"]
                                                [i [ ClassName "fas fa-calculator"][]]]
                                                ]
                                  
                                  div
                                    [ClassName "control"]
                                    [ label [ClassName "label"]
                                            [str "Unidad"]
                                      p [ ClassName "control has-icons-right"]
                                        [ div [ ClassName "select" ]  
                                                    [  select [ ClassName "select"]  
                                                             [ option [ ] [str "Kilos"]
                                                               option [ ] [str "Litros"] 
                                                               option [ ] [str "Latas"]
                                                               option [ ] [str "Paquetes"]
                                                               option [ ] [str "Cajas"]
                                                               option [ ] [str "Unidad"] ] ] ] ] ]
                              div
                                [ClassName "field is-grouped"]
                                [ div
                                    [ClassName "control"]
                                    [ label [ClassName "label"]
                                            [str "Proveedor"]
                                      p [ ClassName "control has-icons-right"]
                                        [ input [ ClassName " input"
                                                  Type "text"
                                                  Placeholder "Proveedor"
                                                  OnChange (fun ev -> ev.target?value |> string |> ChangeProveedor |> dispatch)]
                                          span  [ ClassName "icon is-small is-right"]
                                                [i [ ClassName "fas fa-user"][]]]]]                  
                              div
                                [ClassName "field is-grouped"]
                                [ div
                                    [ClassName "control"]
                                    [ label [ClassName "label"]
                                            [str "Precio"]
                                      p [ ClassName "control has-icons-right"]
                                        [ input [ ClassName " input"
                                                  Type "text"
                                                  Placeholder "Precio"
                                                  OnChange (fun ev -> ev.target?value |> float |> ChangePrecio |> dispatch)]
                                          span  [ ClassName "icon is-small is-right"]
                                                [i [ ClassName "fas fa-dollar-sign"][]]]]]                         
                              
                              div
                                []
                                [ button [ClassName "button is-fullwidth is-block is-info"]
                                         [str "Registrar"]
                                ]] ]]
 ]
