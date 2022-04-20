

export interface LoguinUser {
    transaccion:  string;
    datosUsarios: DatosUsarios;
}

export interface DatosUsarios{
    email: string;
    password: string;
}

export interface ConsultaProductos
{
    transaccion: string;
    tipo: number;
}
export interface ProductosResponse
{
    descripcion :string;
    precio: number;
    estado:boolean;
    detalle:string;
    imagen:string;
}

export class ProductosArray
{
    descripcion! :string;
    precio!: number;
    estado!:boolean;
    detalle!:string;
    imagen!:string;
}
