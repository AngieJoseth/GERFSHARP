module Home.View

open Fable.Helpers.React
open Fable.Helpers.React.Props

let root =
  div [ ClassName "content"]
          [ figure  [ ClassName "image is-2by1"]
                  [ img  [ Src "img/FondoPagina.png"] ] ] 
        
