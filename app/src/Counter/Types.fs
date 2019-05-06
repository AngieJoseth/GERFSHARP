module Counter.Types

type Model = string
type Msg =
    | Codigo of string
    | Nombre of string
    | Cantidad of string
    | Unidad of string
    | Precio of string
