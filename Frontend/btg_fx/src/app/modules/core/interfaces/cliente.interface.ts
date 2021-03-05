export interface Cliente {
    idCliente?: string;
    tipoIdentificacion?: string;
    identificacion?: string;
    nombre?: string;
    activo?: boolean;
    eliminado?: boolean;
    /*public int IdCliente { get; set; }
    public string Nombre { get; set; }
    public int TipoIdentificacion { get; set; }
    public string Identificacion { get; set; }
    public bool Activo { get; set; }
    public bool Eliminado { get; set; }*/
}
