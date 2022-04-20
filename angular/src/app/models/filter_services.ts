

export interface LoguinUser {
    Transaccion:  string;
    DatosUsarios: DatosUsarios;
}

export interface DatosUsarios{
    Email: string;
    Password: string;
}

export interface ConsultaProductos
{
    Transaccion: string;
    Tipo: number;
}
