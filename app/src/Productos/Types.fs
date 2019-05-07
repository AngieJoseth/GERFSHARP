module Productos.Types

type Model =
    { Codigo: int
      Nombre : string
      Cantidad : int
      Unidad : string
      Precio: float 
      Proveedor : string
       }    
  
    
type Msg =
    | ChangeCodigo of int
    | ChangeNombre of string
    | ChangeCantidad of int
    | ChangeUnidad of string
    | ChangePrecio of float
    | ChangeProveedor of string


