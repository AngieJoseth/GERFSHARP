module Counter.View

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Types

let simpleButton txt action dispatch =
  div
    [ ClassName "column is-narrow" ]
    [ a
        [ ClassName "button"
          OnClick (fun _ -> action |> dispatch) ]
        [ str txt ] ]

let root model dispatch =
  // div
  //   [ ClassName "columns is-vcentered" ]
  //   [ div [ ClassName "column" ] [ ]
  //     div
  //       [ ClassName "column is-narrow"
  //         Style
  //           [ CSSProp.Width "170px" ] ]
  //       [ str (sprintf "Counter value: %i" model) ]
  //     simpleButton "+1" Increment dispatch
  //     simpleButton "-1" Decrement dispatch
  //     simpleButton "Reset" Reset dispatch
  //     div [ ClassName "column" ] [ ] ]


  div [ ClassName "field column is-8" ]   
      [ 
        article [ ClassName "message is-primary " ]
                [  
                   h1 [ClassName "message-header" ]
                          [ str "Registro de Productos" ]    
                  // Código     
                   div   [ ClassName "message-body"]
                        [ label [ ClassName "label .is-small"]
                            [ str "Codigo" ]
                          div [ ClassName "control has-icons-left has-icons-right is-half" ]
                            [ input [ ClassName  "input is-normal"
                                      Type "number"
                                      AutoFocus true]
                                      //OnChange (CloseEventType|> dispatch )  ]

                              span [ ClassName "icon is-small is-left" ] 
                                    [ i [ ClassName  "fas fa-barcode"]
                                          [ ] ] ] 
                          
                  // Descripción
                          label [ ClassName "label .is-small"]
                             [ str "Descripción" ] 
                          div [ClassName "control has-icons-left has-icons-right" ]
                            [ input [ ClassName "input is-two-fifths"
                                      Type "text"
                                      Placeholder "Nombre del producto"]
                                       //OnChange (CloseEventType|> dispatch )  ] 
                              span [ ClassName "icon is-small is-left" ] 
                                    [ i [ ClassName "far fa-edit" ]
                                          [ ] ] ]
                     
                  // Cantidad
                          label [ ClassName "label .is-small" ]
                                  [ str "Cantidad" ]
                          div [ ClassName "control has-icons-left has-icons-right" ]
                                  [ input [ ClassName "input is-normal"
                                            Type "number"]
                                             //OnChange (CloseEventType|> dispatch )  ]
                                    span [ ClassName "icon is-small is-left" ] 
                                          [ i [ ClassName "fas fa-calculator"  ]
                                               [ ] ] ]
                  // Unidad

                          label [ ClassName "label .is-small" ]
                                      [ str "Unidad" ]
                          div [  ClassName "control is-normal" ]
                                  [ div [ ClassName "select" ]  
                                          [  select [ ClassName "select"]  
                                                   [ option [ ] [str "Kilos"]
                                                     option [ ] [str "Litros"] 
                                                     option [ ] [str "Latas"]
                                                     option [ ] [str "Paquetes"]
                                                     option [ ] [str "Cajas"]
                                                     option [ ] [str "Unidad"] ] ] ]                        
                  // Precio
                          label [ ClassName "label .is-small" ]
                                      [ str "Precio" ]
                          div [  ClassName "control has-icons-left has-icons-right is-one-fifth" ]
                                      [ input [ ClassName "input is-one-fifth"
                                                Type "text"] 
                                                 //OnChange (CloseEventType|> dispatch )  ]
                                        span [ ClassName "icon is-small is-left" ] 
                                              [ i [ ClassName "fas fa-dollar-sign"]
                                                     [ ] ] ]         
                          br [ ] ] 
                   
                  // Botones
                   
                   div [  ClassName "field is-grouped is-grouped-centered"]
                        [ div [  ClassName "control"]
                            [ button [ ClassName "button is-success is-normal" ]
                                       //OnClick (fun _ -> action |> dispatch) ]
                                [ str "Guardar " ] ]
                          div [ ClassName "control"]
                            [ button [ ClassName "button is-danger is-normal"  ]
                                       //OnClick (fun _ -> action |> dispatch) ]
                                [ str "Cancelar" ] ] ] 
                  //  div [  ClassName "field is-grouped is-grouped-centered"]
                  // //       [ div [  ClassName "control"]
                  //           [ span [ ClassName  "icon is-small is-left"
                                   //  Icon "fal fa-edit" ] ] 
                   br [ ]  
                   table [ ClassName "table table-bordered" ] 
                    [ thead [] [ tr [] [ th [] [ str "Código" ]
                                         th [] [ str "Nombre" ]
                                         th [] [ str "Cantidad" ]
                                         th [] [ str "Unidad" ]
                                         th [] [ str "Precio"]
                                         th [] [ str "Acciones" ] ] ] ] ] ]
                               
