module Navbar.View

open Fable.Helpers.React
open Fable.Helpers.React.Props

let navButton classy href faClass txt =
    p
        [ ClassName "control" ]
        [ a
            [ ClassName (sprintf "button %s" classy)
              Href href ]
            [ span
                [ ClassName "icon" ]
                [ i
                    [ ClassName (sprintf "fas %s" faClass) ]
                    [ ] ]
              span
                [ ]
                [ str txt ] ] ]

let navButton1 clase href  texto  =
    p
      [ ClassName (sprintf "button %s" clase )
        Href href]
      [ span
          [ ]
          [ str texto]]

let navButtons =
    span
        [ ClassName "navbar-item" ]
        [ div
            [ ClassName "field is-grouped" ]
            [ navButton "is-dark" "" "fa-user-lock" ""] ]

let navButtons1 =
    ul
      [ ]
      [ li
          []
          [ navButton1 "is-dark" "" "Productos"]
        li
          []
          [ navButton1 "is-dark" "" "Proveedores"]
        li
          []
          [ navButton1 "is-dark" "" "Pedidos"]]
          
type Page =
    | Home
    | Proveedor
    | Productos
    | Pedidos
let toHash page =
    match page with
    | Home -> "#home"
    | Proveedor -> "#proveedor"
    | Productos -> "#productos"
    | Pedidos -> "#pedidos"

// let menuItem page currentPage =
//     li
//       [ ]
//       [ a
//           [ ClassName [ Page 
//            currentPage ]
//             Href (toHash page) ][]
// //            ]
// let menu currentPage =
//   aside
//     [ ClassName "menu" ]
//     [ p
//         [ ClassName "menu-label" ]
//         [ str "General" ]
//       ul
//         [ ClassName "menu-list" ]
//         [ menuItem  Home currentPage
//           menuItem  Productos currentPage
//           menuItem  Page.Proveedor currentPage
//          // menuItem "Modular" Modular currentPage 
//           ] ]

let root =
    nav
        [ ClassName "navbar is-dark" ]
        [ div
            [ ClassName "container" ]
            [ div
                [ ClassName  "breadcrumb-brand" ]
                [ h1
                    [ ClassName "navbar-item title is-4" ]
                    [ str "GERF" ] ]
              div [ ClassName "breadcrumb is-centered"]
                  [ h1  [ ClassName "navbar-item title is-4" ]
                  [ navButtons1] ]
              div
                [ ClassName "navbar-end" ]
                [ navButtons ]
              ] ]
