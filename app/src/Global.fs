module Global

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

