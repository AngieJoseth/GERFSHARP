module Proveedores.View

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Types


let root model dispatch  =
            div [ClassName "card-block"
                 Style[ Width "420px"
                        Height "300px"
                        Background "#DAE8F5"
                        BorderRadius 8
                        ] ]
                    [ header
                        [ ClassName "card-header"
                          Style[Background "#FFFFFF"
                                BorderRadius 8]]
                        [ p[ClassName "card-header-title"][str "FORMULARIO DE PROVEEDORES"]]

                      div
                        [ClassName "card-content" ]
                        [ div
                            [ClassName "field is-grouped"]
                            [ div
                                [ClassName "control"]
                                [ label [ClassName "label is-small"]
                                        [str "Ruc"]
                                  p [ ClassName "control has-icons-right"]
                                    [ input [ ClassName " input is-small"
                                              Type "text"
                                              Placeholder "Precio"
                                              OnChange (fun ev -> ev.target?value |> int |> ChangeRuc |> dispatch)]
                                      span  [ ClassName "icon is-small is-right"]
                                            [i [ ClassName "fas fa-dollar-sign"][]]]
                                            ]
                              div
                                [ClassName "control"]
                                [ label [ClassName "label is-small"]
                                        [str "Nombre"]
                                  p [ ClassName "control has-icons-right"]
                                    [ input [ ClassName " input is-small "
                                              Type "text"
                                              Placeholder "Unidades"
                                              OnChange (fun ev -> ev.target?value |> string|> ChangeNombre |> dispatch)]
                                      span  [ ClassName "icon is-small is-right"]
                                            [i [ ClassName "fas fa-balance-scale"][]]]
                                            ]]
                          div
                            []
                            [ label [ClassName "label is-small"]
                                    [str "Direccion"]
                              input [ ClassName " input is-small"
                                      Type "text"
                                      Placeholder "Nombre Producto"
                                      OnChange (fun ev -> ev.target?value |> string |> ChangeDireccion |> dispatch)]]
                          div
                            [ClassName "field is-grouped"]
                            [ div
                                [ClassName "control"]
                                [ label [ClassName "label is-small"]
                                        [str "Telefono"]
                                  p [ ClassName "control has-icons-right"]
                                    [ input [ ClassName " input is-small"
                                              Type "text"
                                              Placeholder "Precio"
                                              OnChange (fun ev -> ev.target?value |> int |> ChangeTelefono |> dispatch)]
                                      span  [ ClassName "icon is-small is-right"]
                                            [i [ ClassName "fas fa-dollar-sign"][]]]
                                            ]
                              div
                                [ClassName "control"]
                                [ label [ClassName "label is-small"]
                                        [str "Correo Electrónico"]
                                  p [ ClassName "control has-icons-right"]
                                    [ input [ ClassName " input is-small "
                                              Type "text"
                                              Placeholder "Unidades"
                                              OnChange (fun ev -> ev.target?value |> string |> ChangeCorreo |> dispatch)]
                                      span  [ ClassName "icon is-small is-right"]
                                            [i [ ClassName "fas fa-balance-scale"][]]]
                                            ]]
                          br[]
                          div
                            []
                            [ button [ClassName "button is-fullwidth is-block is-info"]
                                     [str "Registrar"]
                            ]]]

