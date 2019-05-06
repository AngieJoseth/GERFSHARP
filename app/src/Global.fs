module Global

type Page =
    | Home
    | Proveedor

let toHash page =
    match page with
    | Home -> "#home"
    | Proveedor -> "#proveedor"
