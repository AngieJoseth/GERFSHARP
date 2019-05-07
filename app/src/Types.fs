module App.Types

open Global

type Msg =
    | ProveedorMsg of Proveedores.Types.Msg
    | ProductosMsg of Productos.Types.Msg

type Model =
    { CurrentPage: Page
      Proveedor: Proveedores.Types.Model
      Productos: Productos.Types.Model }
