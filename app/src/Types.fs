module App.Types

open Global

type Msg =
    | ProveedorMsg of Proveedores.Types.Msg

type Model =
    { CurrentPage: Page
      Proveedor: Proveedores.Types.Model }
