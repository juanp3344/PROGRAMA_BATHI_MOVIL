

//I. Entidades Base

public class Articulos
{
    public int Id_Articulo { get; set; }
    public string Marca { get; set; }
    public decimal Costo { get; set; }
    public DateTime fecha_fabricacion {get; set;}

    // 1:N
    public List<Implementos>? Implementos { get; set; }
    public List<Tipo_Implementos>? Tipo_Implementos { get; set; }
    public List<Detalle_Facturas>? Detalle_Facturas { get; set; }
    public List<Mantenimiento_Elementos>? Mantenimiento_Elementos { get; set; }
}
public class Tipo_Aseo_Elementos : Articulos
{
    public int Id_Tipo_Aseo_Elementos { get; set;} 
    public string Uso { get; set; }
    public string Instrucciones_Uso { get; set; }
    public decimal medida_litros {get; set;}
    public int Id_Articulo {get; set;}
}
public class Tipo_Implementos : Articulos
{
    public int Id_Tipo_Implementos { get; set; }
    public string Nombre { get; set; }   
    public string Descripcion { get; set; }
    public decimal ancho { get; set; }
    public decimal largo { get; set; }
    public decimal alto { get; set; }
    public List<Implementos>? Implementos { get; set; }
}

public class Implementos 
{
    public int Id_Implemento { get; set; }
    public int Vida_Util { get; set; }

    // N:1
    public int Id_Portatil { get; set; }
    public int Id_Bodega { get; set; }
    public int Tipo_Implementos { get; set; }

    public Tipo_Implementos? _Tipo_Implementos { get; set; }
    public Portatiles? _Portatil { get; set; }
    public Bodegas? _Bodega { get; set; }

    public string Estado { get; set; }
}

public class Aseo_Elementos 
{
    public DateTime Fecha_Vencimiento { get; set; }
    public int Cantidad { get; set; }

    // N:1
    public int Id_Tipo_Aseo_Elementos { get; set; }
    public Tipo_Aseo_Elementos? _Tipo_Aseo_Elemento { get; set; }
}


public class Portatiles
{
    public int Id_Portatil { get; set; }
    public string Numero_Serial { get; set; }
    public DateTime Fecha_Fabricacion { get; set; }
    public string Estado_Actual { get; set; }

    // N:1
    public int Id_Tipo_Portatil { get; set; }
    public int Id_Sede { get; set; }

    public Tipos_Portatiles? _Tipo_Portatil { get; set; }
    public Sedes? _Sede { get; set; }

    // 1:N
    public List<Implementos>? Implementos { get; set; }
    public List<Mantenimiento>? Mantenimientos { get; set; }
    public List<Prestamos_Portatiles>? Prestamos_Portatiles { get; set; }
}

public class Tipos_Portatiles
{
    public int Id_Tipo_Portatil { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public double Altura { get; set; }
    public double Ancho { get; set; }
    public double Largo { get; set; }

    // 1:N
    public List<Portatiles>? Portatiles { get; set; }
    public List<Historial_Precios>? Historial_Precios { get; set; }
    public List<Tipo_Implementos>? Tipo_Implementos { get; set; }
}

public class Sedes
{
    public int Id_Sede { get; set; }
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public string Ciudad { get; set; }
    public string Telefono_Contacto { get; set; }

    // 1:N
    public List<Portatiles>? Portatiles { get; set; }
    public List<Bodegas>? Bodegas { get; set; }
}

public class Bodegas
{
    public int Id_Bodega { get; set; }
    public string Nombre { get; set; }
    public string Ubicacion { get; set; }
    public int Capacidad_Maxima { get; set; }


    // N:1
    public int Id_Sede { get; set;}
    public int Id_Empleado { get; set; }
    public Empleados? _Empleado { get; set; }
    public Sedes? _Sede { get; set;}

    // Relaciones 1:N
    public List<Implementos>? Implementos { get; set; }
    public List<Aseo_Elementos> _aseo_Elementos { get; set; }
}


public class Historial_Precios
{
    public int Id_Historial { get; set; }
    public decimal Valor { get; set; }
    public DateTime Fecha_Inicio { get; set; }
    public DateTime Fecha_Fin { get; set; }
    public string Motivo_Cambio { get; set; }

    // N:1
    public int Id_Tipo_Portatiles { get; set; }
    public Tipos_Portatiles? _Tipo_Portatiles { get; set; }
}


//II. Entidades de Actores y Acceso

public class Clientes
{
    public int Id_Cliente { get; set; }
    public string Razon_Social { get; set; }
    public string Nit_CC { get; set; }
    public string Telefono { get; set; }
    public string Correo { get; set; }
    public string Direccion_Fiscal { get; set; }

    // 1:N
    public List<Contratos>? Contratos { get; set; }
    public List<Facturas>? Facturas { get; set; }
    // 1:1
    public int Id_Usuario { get; set; }
    public Usuarios? _Usuario { get; set; }
}

public class Empleados
{
    public int Id_Empleado { get; set; }
    public string Nombre { get; set; }
    public string Documento { get; set; }
    public string Telefono { get; set; }
    public string Correo { get; set; }
    public DateTime Fecha_Ingreso { get; set; }

    // N:1
    public int Id_Rol { get; set; }
    public Roles_Empleados? _Rol { get; set; }
    

    // 1:N
    public List<Mantenimiento>? Mantenimientos { get; set; }
    public List<Envios>? Envios { get; set; }

    //1:1
    public int Id_Usuario { get; set; }
    public Usuarios? _Usuario  { get; set; }
}
public class Roles_Empleados
{
    public int Id_Rol { get; set; }
    public string Nombre_Rol { get; set; }
    public string Descripcion_Rol { get; set; }
    public decimal Salario_Base { get; set; }

    // 1:N
    public List<Empleados>? Empleados { get; set; }
}
public class Usuarios
{
    public int Id_Usuario { get; set; }
    public string Username { get; set; }
    public string Password_Hash { get; set; }
    public bool Activo { get; set; }
    public DateTime Fecha_Ultimo_Acceso { get; set; }

    // 1:1
    public int Id_Cliente { get; set; }
    public int Id_Empleado { get; set; }
    public Clientes? _Cliente { get; set; }
    public Empleados? _Empleado { get; set; }

}




//III. Entidades Comerciales y Operativas

public class Contratos
{
    public int Id_Contratos { get; set; }
    public DateTime Fecha_Firma { get; set; }
    public string Terminos { get; set; }
    public DateTime Fecha_Expiracion { get; set; }

    // N:1
    public int Id_Cliente { get; set; }
    public Clientes? _Cliente { get; set; }

    // 1:1
    public Prestamos? Prestamo { get; set; }
    public Compras? Compra { get; set; }
}

public class Prestamos
{
    public int Id_Prestamo { get; set; }
    public DateTime Fecha_Inicio { get; set; }
    public DateTime Fecha_Fin_Prevista { get; set; }
    public bool Estado_Prestamo { get; set; }


    // N:1
    public int Id_Contratos { get; set; }
    public Contratos? _Contrato { get; set; }

  
    // 1:N
    public List<Envios>? Envios { get; set; }
    public List<Mantenimiento>? Mantenimientos { get; set; }
    public List<Prestamos_Portatiles>? Prestamos_Portatiles { get; set; }
}

public class Compras
{
    public int Id_Compra { get; set; }
    public DateTime Fecha_Compra { get; set; }
    public decimal Monto_Total { get; set; }
    public string Metodo_Pago { get; set; }
    public int Garantia_Meses { get; set; }

    // N:1
    public int Id_Contratos { get; set; }
    public Contratos? _Contrato { get; set; }
}

public class Mantenimiento
{
    public int Id_Mantenimiento { get; set; }
    public DateTime Fecha_Servicio { get; set; }
    public string Tipo_Mantenimiento { get; set; }
    public string Descripcion_Trabajo { get; set; }
    public decimal Costo_Mano_Obra { get; set; }

    // N:1
    public int Id_Prestamo { get; set; }
    public int Id_Empleado { get; set; }

    public Prestamos? _Prestamo { get; set; }
    public Empleados? _Empleado { get; set; }

    // 1:N
    public List<Aseo_Elementos>? Aseo_Elementos { get; set; }
   
}



//IV. Logística

public class Envios
{
    public int Id_Envio { get; set; }
    public DateTime Fecha_Salida { get; set; }
    public string Destino { get; set; }
    public decimal Costo_Envio { get; set; }
    public DateTime Fecha_Entrega_Estimada { get; set; }

    // N:1
    public int Id_Contratos { get; set; }
    public int Id_Empleado { get; set; }

    public Contratos? _Contrato { get; set; }
    public Empleados? _Empleado { get; set; }
}



//V. Finanzas

public class Facturas
{
    public int Id_Factura { get; set; }
    public string Numero { get; set; }
    public DateTime Fecha_Emision { get; set; }
    public decimal Total { get; set; }
    public decimal Impuesto_Iva { get; set; }

    // N:1
    public int Id_Cliente { get; set; }
    public Clientes? _Cliente { get; set; }

    // 1:N
    public List<Detalle_Facturas>? Detalle_Facturas { get; set; }
    public List<Pagos>? Pagos { get; set; }
}

public class Detalle_Facturas
{
    public int Id_Detalle { get; set; }
    public int Cantidad { get; set; }
    public decimal Costo_Unitario { get; set; }
    public decimal Descuento_Aplicado { get; set; }
    public decimal Subtotal { get; set; }

    // N:1
    public int Id_Factura { get; set; }
    public int Id_Articulo { get; set; }

    public Facturas? _Factura { get; set; }
    public Articulos? _Articulo { get; set; }

   
}

public class Pagos
{
    public int Id_Pago { get; set; }
    public decimal Total_Pagado { get; set; }
    public DateTime Fecha_Pago { get; set; }
    public string Referencia_Bancaria { get; set; }
    public string Metodo_Pago { get; set; }

    // N:1
    public int Id_Factura { get; set; }
    public Facturas? _Factura { get; set; }
}

//VI. Entidades Intermedias

public class Prestamos_Portatiles
{
    public int Id_Prestamo_Portatil { get; set; }

    // N:1
    public int Id_Prestamo { get; set; }
    public int Id_Portatil { get; set; }

    public Prestamos? _Prestamo { get; set; }
    public Portatiles? _Portatil { get; set; }
}

