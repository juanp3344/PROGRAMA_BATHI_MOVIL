


class Program {
    static void Main(string[] args) 
    {
        // 1. Portatiles (Asignados a Tipos, Sedes y Compras ficticias)
        var portatiles = new List<Portatiles> {
            new Portatiles { Id_Portatil = 1, Numero_Serial = "SN-001", Fecha_Fabricacion = new DateTime(2025, 01, 10), Estado_Actual = "Disponible", Id_Tipo_Portatil = 1, Id_Sede = 1, Id_Compra = 1 },
            new Portatiles { Id_Portatil = 2, Numero_Serial = "SN-002", Fecha_Fabricacion = new DateTime(2025, 01, 15), Estado_Actual = "Alquilado", Id_Tipo_Portatil = 1, Id_Sede = 1, Id_Compra = 1 },
            new Portatiles { Id_Portatil = 3, Numero_Serial = "SN-003", Fecha_Fabricacion = new DateTime(2025, 02, 01), Estado_Actual = "Mantenimiento", Id_Tipo_Portatil = 2, Id_Sede = 2, Id_Compra = 2 },
            new Portatiles { Id_Portatil = 4, Numero_Serial = "SN-004", Fecha_Fabricacion = new DateTime(2025, 02, 05), Estado_Actual = "Disponible", Id_Tipo_Portatil = 3, Id_Sede = 5, Id_Compra = 3 },
            new Portatiles { Id_Portatil = 5, Numero_Serial = "SN-005", Fecha_Fabricacion = new DateTime(2025, 02, 10), Estado_Actual = "Disponible", Id_Tipo_Portatil = 4, Id_Sede = 3, Id_Compra = 4 }
        };

        // 2. Tipos_Portatiles
        var tiposPortatiles = new List<Tipos_Portatiles> {
            new Tipos_Portatiles { Id_Tipo_Portatil = 1, Nombre = "Estándar", Descripcion = "Polietileno básico", Altura = 2.20, Ancho = 1.10, Largo = 1.20 },
            new Tipos_Portatiles { Id_Tipo_Portatil = 2, Nombre = "Lujo", Descripcion = "Con Lavamanos", Altura = 2.30, Ancho = 1.20, Largo = 1.30 },
            new Tipos_Portatiles { Id_Tipo_Portatil = 3, Nombre = "VIP", Descripcion = "Climatizado", Altura = 2.40, Ancho = 1.50, Largo = 1.50 },
            new Tipos_Portatiles { Id_Tipo_Portatil = 4, Nombre = "Accesible", Descripcion = "Rampa sillas", Altura = 2.20, Ancho = 2.00, Largo = 2.00 },
            new Tipos_Portatiles { Id_Tipo_Portatil = 5, Nombre = "Urinario", Descripcion = "4 estaciones", Altura = 2.00, Ancho = 1.10, Largo = 1.10 }
        };

        // 3. Tipo_Aseo_Elementos
        var tiposAseo = new List<Tipo_Aseo_Elementos> {
            new Tipo_Aseo_Elementos { Id_Tipo_Aseo_Elementos = 1, Uso = "Desinfectante", Instrucciones_Uso = "Mezclar 1:10", medida_litros = 0.5m, toxicidad = "Media" },
            new Tipo_Aseo_Elementos { Id_Tipo_Aseo_Elementos = 2, Uso = "Aromatizante", Instrucciones_Uso = "Spray directo", medida_litros = 1.0m, toxicidad = "Baja" },
            new Tipo_Aseo_Elementos { Id_Tipo_Aseo_Elementos = 3, Uso = "Neutralizador", Instrucciones_Uso = "Uso en tanque", medida_litros = 5.0m, toxicidad = "Alta" },
            new Tipo_Aseo_Elementos { Id_Tipo_Aseo_Elementos = 4, Uso = "Jabón", Instrucciones_Uso = "Dispensador", medida_litros = 0.8m, toxicidad = "Nula" },
            new Tipo_Aseo_Elementos { Id_Tipo_Aseo_Elementos = 5, Uso = "Desengrasante", Instrucciones_Uso = "Limpieza profunda", medida_litros = 2.0m, toxicidad = "Media" }
        };

        // 4. Tipo_Implementos
        var tiposImplementos = new List<Tipo_Implementos> {
            new Tipo_Implementos { Id_Tipo_Implementos = 1, Nombre = "Bomba de pie", Descripcion = "Para lavamanos", ancho = 0.2m, largo = 0.2m, alto = 0.1m },
            new Tipo_Implementos { Id_Tipo_Implementos = 2, Nombre = "Dispensador Papel", Descripcion = "Cerradura llave", ancho = 0.3m, largo = 0.1m, alto = 0.3m },
            new Tipo_Implementos { Id_Tipo_Implementos = 3, Nombre = "Tanque Residuos", Descripcion = "Capacidad 200L", ancho = 0.8m, largo = 0.8m, alto = 0.6m },
            new Tipo_Implementos { Id_Tipo_Implementos = 4, Nombre = "Espejo", Descripcion = "Policarbonato", ancho = 0.4m, largo = 0.05m, alto = 0.6m },
            new Tipo_Implementos { Id_Tipo_Implementos = 5, Nombre = "Ventilador", Descripcion = "12V Solar", ancho = 0.2m, largo = 0.1m, alto = 0.2m }
        };

        // 5. Implementos
        var implementos = new List<Implementos> {
            new Implementos { Id_Implemento = 1, Vida_Util = 24, Estado = "Nuevo", fecha_fabricacion = DateTime.Now, Marca = "EcoFlush", Costo = 150000, Id_Portatil = 1, Id_Bodega = 1, Tipo_Implementos = 1 },
            new Implementos { Id_Implemento = 2, Vida_Util = 12, Estado = "Usado", fecha_fabricacion = DateTime.Now, Marca = "PaperSafe", Costo = 45000, Id_Portatil = 1, Id_Bodega = 1, Tipo_Implementos = 2 },
            new Implementos { Id_Implemento = 3, Vida_Util = 36, Estado = "Nuevo", fecha_fabricacion = DateTime.Now, Marca = "TitanTank", Costo = 500000, Id_Portatil = 2, Id_Bodega = 2, Tipo_Implementos = 3 },
            new Implementos { Id_Implemento = 4, Vida_Util = 48, Estado = "Excelente", fecha_fabricacion = DateTime.Now, Marca = "GlassFree", Costo = 30000, Id_Portatil = 3, Id_Bodega = 1, Tipo_Implementos = 4 },
            new Implementos { Id_Implemento = 5, Vida_Util = 18, Estado = "Reparado", fecha_fabricacion = DateTime.Now, Marca = "SolarWind", Costo = 120000, Id_Portatil = 4, Id_Bodega = 5, Tipo_Implementos = 5 }
        };

        // 6. Aseo_Elementos
        var aseoElementos = new List<Aseo_Elementos> {
            new Aseo_Elementos { Id_Aseo_Elemento = 1, Fecha_Vencimiento = DateTime.Now.AddYears(1), Cantidad = 50, Marca = "BlueSan", Costo = 12000, Id_Tipo_Aseo_Elementos = 1 },
            new Aseo_Elementos { Id_Aseo_Elemento = 2, Fecha_Vencimiento = DateTime.Now.AddMonths(6), Cantidad = 20, Marca = "LemonFresh", Costo = 8000, Id_Tipo_Aseo_Elementos = 2 },
            new Aseo_Elementos { Id_Aseo_Elemento = 3, Fecha_Vencimiento = DateTime.Now.AddYears(2), Cantidad = 100, Marca = "KillAll", Costo = 25000, Id_Tipo_Aseo_Elementos = 3 },
            new Aseo_Elementos { Id_Aseo_Elemento = 4, Fecha_Vencimiento = DateTime.Now.AddMonths(3), Cantidad = 15, Marca = "CleanHands", Costo = 15000, Id_Tipo_Aseo_Elementos = 4 },
            new Aseo_Elementos { Id_Aseo_Elemento = 5, Fecha_Vencimiento = DateTime.Now.AddYears(1), Cantidad = 30, Marca = "PowerGrease", Costo = 18000, Id_Tipo_Aseo_Elementos = 5 }
        };

        // 7. Sedes
        var sedes = new List<Sedes> {
            new Sedes { Id_Sede = 1, Nombre = "Sede Norte", Direccion = "Calle 100 #15", Ciudad = "Bogotá", Telefono_Contacto = "3001111" },
            new Sedes { Id_Sede = 2, Nombre = "Sede Sur", Direccion = "Av. Pasoancho", Ciudad = "Cali", Telefono_Contacto = "3002222" },
            new Sedes { Id_Sede = 3, Nombre = "Eje Cafetero", Direccion = "Cra 20 #10", Ciudad = "Pereira", Telefono_Contacto = "3003333" },
            new Sedes { Id_Sede = 4, Nombre = "Costa", Direccion = "Vía 40", Ciudad = "Barranquilla", Telefono_Contacto = "3004444" },
            new Sedes { Id_Sede = 5, Nombre = "Antioquia", Direccion = "Calle 10", Ciudad = "Medellín", Telefono_Contacto = "3005555" }
        };

        // 8. Bodegas
        var bodegas = new List<Bodegas> {
            new Bodegas { Id_Bodega = 1, Nombre = "Bodega Principal Bogotá", Ubicacion = "Sótano 1", Capacidad_Maxima = 100, Id_Sede = 1, Id_Empleado = 1 },
            new Bodegas { Id_Bodega = 2, Nombre = "Bodega Cali", Ubicacion = "Módulo A", Capacidad_Maxima = 50, Id_Sede = 2, Id_Empleado = 2 },
            new Bodegas { Id_Bodega = 3, Nombre = "Bodega Pereira", Ubicacion = "Lote 2", Capacidad_Maxima = 40, Id_Sede = 3, Id_Empleado = 3 },
            new Bodegas { Id_Bodega = 4, Nombre = "Bodega Químicos B/quilla", Ubicacion = "Zona Norte", Capacidad_Maxima = 30, Id_Sede = 4, Id_Empleado = 4 },
            new Bodegas { Id_Bodega = 5, Nombre = "Bodega Reparaciones Medellín", Ubicacion = "Taller Sur", Capacidad_Maxima = 80, Id_Sede = 5, Id_Empleado = 5 }
        };

        // 9. Historial_Precios
        var historialPrecios = new List<Historial_Precios> {
            new Historial_Precios { Id_Historial = 1, Valor = 1200000, Fecha_Inicio = new DateTime(2024, 01, 01), Fecha_Fin = new DateTime(2024, 12, 31), Motivo_Cambio = "Precio Apertura", Id_Tipo_Portatil = 1 },
            new Historial_Precios { Id_Historial = 2, Valor = 1350000, Fecha_Inicio = new DateTime(2025, 01, 01), Fecha_Fin = new DateTime(2025, 12, 31), Motivo_Cambio = "Inflación", Id_Tipo_Portatil = 1 },
            new Historial_Precios { Id_Historial = 3, Valor = 1800000, Fecha_Inicio = new DateTime(2025, 01, 01), Fecha_Fin = new DateTime(2025, 12, 31), Motivo_Cambio = "Lanzamiento Lujo", Id_Tipo_Portatil = 2 },
            new Historial_Precios { Id_Historial = 4, Valor = 2500000, Fecha_Inicio = new DateTime(2025, 01, 01), Fecha_Fin = new DateTime(2025, 12, 31), Motivo_Cambio = "Precio VIP", Id_Tipo_Portatil = 3 },
            new Historial_Precios { Id_Historial = 5, Valor = 3000000, Fecha_Inicio = new DateTime(2025, 01, 01), Fecha_Fin = new DateTime(2025, 12, 31), Motivo_Cambio = "Especial Discapacitados", Id_Tipo_Portatil = 4 }
        };



        //----------------------------------------------------------------------------------------------------------------------------------------------------


        // Entidades Personales

        // Clase para herdedar

        // 11. Clientes 
        var clientes = new List<Clientes> {
            new Clientes { id_personas = 1, nombre = "Cli Eventos", cedula = "101", correo = "eventos@mail.com", Telefono = "393087409", Razon_Social = "Eventos SA", Nit_CC = "900-1", Tipo_Cliente = 2, Direccion_Fiscal = "Cl 1", Id_Usuario = 1 },
            new Clientes { id_personas = 2, nombre = "Cli Tomorrowland", cedula = "102", correo = "const@mail.com", Telefono = "375849385", Razon_Social = "Constructora Civil", Nit_CC = "900-2",Tipo_Cliente = 1, Direccion_Fiscal = "Av 2", Id_Usuario = 2 },
            new Clientes { id_personas = 3, nombre = "Cli Alcaldia", cedula = "103", correo = "alcaldia@mail.com", Telefono = "3449485710", Razon_Social = "Alcaldía Local", Nit_CC = "900-3",Tipo_Cliente = 3, Direccion_Fiscal = "Pza Central", Id_Usuario = 3 },
            new Clientes { id_personas = 4, nombre = "Cli Rock", cedula = "104", correo = "rock@mail.com", Telefono = "3309458499", Razon_Social = "Festivales Rock", Nit_CC = "900-4",Tipo_Cliente = 2, Direccion_Fiscal = "Parque 4", Id_Usuario = 4 },
            new Clientes { id_personas = 5, nombre = "Cli Minera", cedula = "105", correo = "minera@mail.com", Telefono = "3890394857", Razon_Social = "Minera Norte", Nit_CC = "900-5", Tipo_Cliente = 4, Direccion_Fiscal = "Km 5", Id_Usuario = 5 }
        };

        // 12. Empleados 
        var empleados = new List<Empleados> {
            new Empleados { id_personas = 6, nombre = "Juan Perez", cedula = "201", correo = "juan@erp.com", Telefono = "3123456789", Fecha_Ingreso = new DateTime(2020, 01, 01), Id_Rol = 1, Id_Usuario = 1 },
            new Empleados { id_personas = 7, nombre = "Maria Lopez", cedula = "202", correo = "maria@erp.com", Telefono = "3009283746", Fecha_Ingreso = new DateTime(2021, 05, 10), Id_Rol = 2, Id_Usuario = 2 },
            new Empleados { id_personas = 8, nombre = "Carlos Ruiz", cedula = "203", correo = "carlos@erp.com", Telefono = "3234578907", Fecha_Ingreso = new DateTime(2022, 08, 20), Id_Rol = 3, Id_Usuario = 3 },
            new Empleados { id_personas = 9, nombre = "Ana Gomez", cedula = "204", correo = "ana@erp.com", Telefono = "3876576546", Fecha_Ingreso = new DateTime(2023, 03, 15), Id_Rol = 4, Id_Usuario = 4 },
            new Empleados { id_personas = 10, nombre = "Luis Prado", cedula = "205", correo = "luis@erp.com", Telefono = "3654645645", Fecha_Ingreso = new DateTime(2024, 02, 01), Id_Rol = 5, Id_Usuario = 5 }
        };
        // 13. Roles_Empleados
        var roles = new List<Roles_Empleados> {
            new Roles_Empleados { Id_Rol = 1, Nombre_Rol = "Gerente", Descripcion_Rol = "Control Total", Salario_Base = 8000000, Permisos = Roles_Empleados.Niveles_Acceso.superadmin },
            new Roles_Empleados { Id_Rol = 2, Nombre_Rol = "Contador", Descripcion_Rol = "Finanzas", Salario_Base = 4500000, Permisos = Roles_Empleados.Niveles_Acceso.Gerencial },
            new Roles_Empleados { Id_Rol = 3, Nombre_Rol = "Supervisor Logístico", Descripcion_Rol = "Rutas", Salario_Base = 3000000, Permisos = Roles_Empleados.Niveles_Acceso.Supervisor },
            new Roles_Empleados { Id_Rol = 4, Nombre_Rol = "Operario Aseo", Descripcion_Rol = "Limpieza", Salario_Base = 1500000, Permisos = Roles_Empleados.Niveles_Acceso.Invitado },
            new Roles_Empleados { Id_Rol = 5, Nombre_Rol = "Técnico", Descripcion_Rol = "Reparación", Salario_Base = 2200000, Permisos = Roles_Empleados.Niveles_Acceso.Supervisor }
        };

        // 14. Usuarios
        var usuarios = new List<Usuarios> {
            new Usuarios { Id_Usuario = 1, Username = "j.perez", Password_Hash = "hash1", Activo = true, Fecha_Ultimo_Acceso = DateTime.Now, id_personas = 6 },
            new Usuarios { Id_Usuario = 2, Username = "c.ruiz", Password_Hash = "hash2", Activo = true, Fecha_Ultimo_Acceso = DateTime.Now, id_personas = 8 },
            new Usuarios { Id_Usuario = 3, Username = "cli.alcaldia", Password_Hash = "hash3", Activo = true, Fecha_Ultimo_Acceso = DateTime.Now, id_personas = 3 },
            new Usuarios { Id_Usuario = 4, Username = "cli.rock", Password_Hash = "hash4", Activo = true, Fecha_Ultimo_Acceso = DateTime.Now, id_personas = 4 },
            new Usuarios { Id_Usuario = 5, Username = "cli.minera", Password_Hash = "hash5", Activo = false, Fecha_Ultimo_Acceso = DateTime.Now, id_personas = 5 }
        };


        //----------------------------------------------------------------------------------------------------------------------------------------------------


        // 15. Contratos
        var listaContratos = new List<Contratos> {
            new Contratos { Id_Contratos = 1, Fecha_Firma = DateTime.Now.AddDays(-30), Terminos = "Alquiler mensual con mantenimiento", Fecha_Expiracion = DateTime.Now.AddMonths(6), Id_Cliente = 4},
            new Contratos { Id_Contratos = 2, Fecha_Firma = DateTime.Now.AddDays(-15), Terminos = "Evento fin de semana", Fecha_Expiracion = DateTime.Now.AddDays(5), Id_Cliente = 3},
            new Contratos { Id_Contratos = 3, Fecha_Firma = DateTime.Now.AddDays(-60), Terminos = "Compra de 5 unidades estándar", Fecha_Expiracion = DateTime.Now.AddDays(30), Id_Cliente = 1},
            new Contratos { Id_Contratos = 4, Fecha_Firma = DateTime.Now.AddDays(-10), Terminos = "Licitación pública anual", Fecha_Expiracion = DateTime.Now.AddYears(1), Id_Cliente = 2},
            new Contratos { Id_Contratos = 5, Fecha_Firma = DateTime.Now, Terminos = "Uso industrial continuo", Fecha_Expiracion = DateTime.Now.AddMonths(12), Id_Cliente = 5}
        };

        // 16. Prestamos
        var listaPrestamos = new List<Prestamos> {
            new Prestamos { Id_Prestamo = 1, Fecha_Inicio = DateTime.Now.AddDays(-20), Fecha_Fin_Prevista = DateTime.Now.AddMonths(1), Estado_Prestamo = true, Id_Contratos = 1 },
            new Prestamos { Id_Prestamo = 2, Fecha_Inicio = DateTime.Now.AddDays(-2), Fecha_Fin_Prevista = DateTime.Now.AddDays(3), Estado_Prestamo = true, Id_Contratos = 2 },
            new Prestamos { Id_Prestamo = 3, Fecha_Inicio = DateTime.Now.AddDays(-40), Fecha_Fin_Prevista = DateTime.Now.AddMonths(2), Estado_Prestamo = true, Id_Contratos = 4 },
            new Prestamos { Id_Prestamo = 4, Fecha_Inicio = DateTime.Now.AddDays(-5), Fecha_Fin_Prevista = DateTime.Now.AddMonths(5), Estado_Prestamo = false, Id_Contratos = 5 },
            new Prestamos { Id_Prestamo = 5, Fecha_Inicio = DateTime.Now.AddDays(-10), Fecha_Fin_Prevista = DateTime.Now.AddDays(20), Estado_Prestamo = true, Id_Contratos = 1 }
        };

        // 17. Compras
        var listaCompras = new List<Compras> {
            new Compras { Id_Compra = 1, Fecha_Compra = DateTime.Now.AddMonths(-12), Monto_Total = 15000000, Metodo_Pago = "Transferencia", Garantia_Meses = 24, Id_Contratos = 3 },
            new Compras { Id_Compra = 2, Fecha_Compra = DateTime.Now.AddMonths(-6), Monto_Total = 8000000, Metodo_Pago = "Crédito", Garantia_Meses = 12, Id_Contratos = 3 },
            new Compras { Id_Compra = 3, Fecha_Compra = DateTime.Now.AddDays(-90), Monto_Total = 12000000, Metodo_Pago = "Cheque", Garantia_Meses = 24, Id_Contratos = 3 },
            new Compras { Id_Compra = 4, Fecha_Compra = DateTime.Now.AddDays(-45), Monto_Total = 5000000, Metodo_Pago = "Efectivo", Garantia_Meses = 6, Id_Contratos = 5 },
            new Compras { Id_Compra = 5, Fecha_Compra = DateTime.Now.AddDays(-10), Monto_Total = 20000000, Metodo_Pago = "Transferencia", Garantia_Meses = 36, Id_Contratos = 4 }
        };

        // 18. Mantenimiento
        var listaMantenimientos = new List<Mantenimiento> {
            new Mantenimiento { Id_Mantenimiento = 1, Fecha_Servicio = DateTime.Now.AddDays(-5), Tipo_Mantenimiento = "Preventivo", Descripcion_Trabajo = "Limpieza y recarga químicos", Costo_Mano_Obra = 50000, Id_Prestamo = 1, Id_Empleado = 4 },
            new Mantenimiento { Id_Mantenimiento = 2, Fecha_Servicio = DateTime.Now.AddDays(-3), Tipo_Mantenimiento = "Correctivo", Descripcion_Trabajo = "Cambio de bomba de pie", Costo_Mano_Obra = 80000, Id_Prestamo = 2, Id_Empleado = 5 },
            new Mantenimiento { Id_Mantenimiento = 3, Fecha_Servicio = DateTime.Now.AddDays(-10), Tipo_Mantenimiento = "Aseo Profundo", Descripcion_Trabajo = "Desinfección total vapor", Costo_Mano_Obra = 60000, Id_Prestamo = 3, Id_Empleado = 4 },
            new Mantenimiento { Id_Mantenimiento = 4, Fecha_Servicio = DateTime.Now.AddDays(-15), Tipo_Mantenimiento = "Reparación", Descripcion_Trabajo = "Pintura y sellado grieta", Costo_Mano_Obra = 120000, Id_Prestamo = 4, Id_Empleado = 5 },
            new Mantenimiento { Id_Mantenimiento = 5, Fecha_Servicio = DateTime.Now.AddDays(-1), Tipo_Mantenimiento = "Preventivo", Descripcion_Trabajo = "Recarga suministros", Costo_Mano_Obra = 45000, Id_Prestamo = 5, Id_Empleado = 4 }
        };



        //----------------------------------------------------------------------------------------------------------------------------------------------------


        // 19. Envios
        var listaEnvios = new List<Envios> {
            new Envios { Id_Envio = 1, Fecha_Salida = DateTime.Now.AddDays(-2), Destino = "Parque Simón Bolívar", Costo_Envio = 150000, Fecha_Entrega_Estimada = DateTime.Now.AddDays(-2), Id_Contratos = 2, Id_Empleado = 3 },
            new Envios { Id_Envio = 2, Fecha_Salida = DateTime.Now.AddDays(-5), Destino = "Zona Industrial 4", Costo_Envio = 200000, Fecha_Entrega_Estimada = DateTime.Now.AddDays(-5), Id_Contratos = 1, Id_Empleado = 3 },
            new Envios { Id_Envio = 3, Fecha_Salida = DateTime.Now.AddDays(-1), Destino = "Construcción Puente 5", Costo_Envio = 180000, Fecha_Entrega_Estimada = DateTime.Now.AddDays(-1), Id_Contratos = 4, Id_Empleado = 3 },
            new Envios { Id_Envio = 4, Fecha_Salida = DateTime.Now, Destino = "Evento Municipal", Costo_Envio = 120000, Fecha_Entrega_Estimada = DateTime.Now.AddHours(5), Id_Contratos = 2, Id_Empleado = 3 },
            new Envios { Id_Envio = 5, Fecha_Salida = DateTime.Now.AddDays(1), Destino = "Mina Carbón Sur", Costo_Envio = 450000, Fecha_Entrega_Estimada = DateTime.Now.AddDays(2), Id_Contratos = 5, Id_Empleado = 3 }
        };

        //----------------------------------------------------------------------------------------------------------------------------------------------------


        // 20. Facturas
        var listaFacturas = new List<Facturas> {
            new Facturas { Id_Factura = 1, Numero = "FAC-101", Fecha_Emision = DateTime.Now.AddDays(-10), Total = 1190000, Impuesto_Iva = 190000, Id_Cliente = 2},
            new Facturas { Id_Factura = 2, Numero = "FAC-102", Fecha_Emision = DateTime.Now.AddDays(-5), Total = 2380000, Impuesto_Iva = 380000, Id_Cliente = 3},
            new Facturas { Id_Factura = 3, Numero = "FAC-103", Fecha_Emision = DateTime.Now.AddDays(-2), Total = 595000, Impuesto_Iva = 95000, Id_Cliente = 1},
            new Facturas { Id_Factura = 4, Numero = "FAC-104", Fecha_Emision = DateTime.Now.AddDays(-1), Total = 4760000, Impuesto_Iva = 760000, Id_Cliente = 4},
            new Facturas { Id_Factura = 5, Numero = "FAC-105", Fecha_Emision = DateTime.Now, Total = 1785000, Impuesto_Iva = 285000, Id_Cliente = 5}
        };

        // 21. Detalle_Facturas
        var listaDetalles = new List<Detalle_Facturas> {
            new Detalle_Facturas { Id_Detalle = 1, Cantidad = 1, Costo_Unitario = 1000000, Descuento_Aplicado = 0, Subtotal = 1000000, Id_Factura = 1, Id_Portatil = 1 },
            new Detalle_Facturas { Id_Detalle = 2, Cantidad = 2, Costo_Unitario = 1000000, Descuento_Aplicado = 0, Subtotal = 2000000, Id_Factura = 2, Id_Portatil = 2 },
            new Detalle_Facturas { Id_Detalle = 3, Cantidad = 1, Costo_Unitario = 500000, Descuento_Aplicado = 0, Subtotal = 500000, Id_Factura = 3, Id_Portatil = 3 },
            new Detalle_Facturas { Id_Detalle = 4, Cantidad = 4, Costo_Unitario = 1000000, Descuento_Aplicado = 0, Subtotal = 4000000, Id_Factura = 4, Id_Portatil = 4 },
            new Detalle_Facturas { Id_Detalle = 5, Cantidad = 1, Costo_Unitario = 1500000, Descuento_Aplicado = 0, Subtotal = 1500000, Id_Factura = 5, Id_Portatil = 5 }
        };

        // 22. Pagos
        var listaPagos = new List<Pagos> {
            new Pagos { Id_Pago = 1, Total_Pagado = 1190000, Fecha_Pago = DateTime.Now.AddDays(-8), Referencia_Bancaria = "REF-001", Metodo_Pago = "PSE", Id_Factura = 1 },
            new Pagos { Id_Pago = 2, Total_Pagado = 2380000, Fecha_Pago = DateTime.Now.AddDays(-3), Referencia_Bancaria = "REF-002", Metodo_Pago = "Transferencia", Id_Factura = 2 },
            new Pagos { Id_Pago = 3, Total_Pagado = 595000, Fecha_Pago = DateTime.Now.AddDays(-1), Referencia_Bancaria = "REF-003", Metodo_Pago = "Efectivo", Id_Factura = 3 },
            new Pagos { Id_Pago = 4, Total_Pagado = 2000000, Fecha_Pago = DateTime.Now, Referencia_Bancaria = "REF-004", Metodo_Pago = "Cheque", Id_Factura = 4 },
            new Pagos { Id_Pago = 5, Total_Pagado = 1785000, Fecha_Pago = DateTime.Now, Referencia_Bancaria = "REF-005", Metodo_Pago = "Transferencia", Id_Factura = 5 }
        };

        //----------------------------------------------------------------------------------------------------------------------------------------------------


        // 23. Prestamos_Portatiles
        var listaPrestamosPortatiles = new List<Prestamos_Portatiles> {
            new Prestamos_Portatiles { Id_Prestamo_Portatil = 1, Id_Prestamo = 1, Id_Portatil = 1 },
            new Prestamos_Portatiles { Id_Prestamo_Portatil = 2, Id_Prestamo = 2, Id_Portatil = 2 },
            new Prestamos_Portatiles { Id_Prestamo_Portatil = 3, Id_Prestamo = 3, Id_Portatil = 3 },
            new Prestamos_Portatiles { Id_Prestamo_Portatil = 4, Id_Prestamo = 4, Id_Portatil = 4 },
            new Prestamos_Portatiles { Id_Prestamo_Portatil = 5, Id_Prestamo = 5, Id_Portatil = 5 }
        };

        // 24. Tipos_Intermedia 
        var listaTiposIntermedia = new List<Tipos_Intermedia> {
            new Tipos_Intermedia { Id_Tipos_Intermedia = 1, Id_Tipo_Portatil = 1, Id_Tipo_Implementos = 2, Posicion_Montaje = "Lateral Derecha" },
            new Tipos_Intermedia { Id_Tipos_Intermedia = 2, Id_Tipo_Portatil = 2, Id_Tipo_Implementos = 1, Posicion_Montaje = "Piso Frontal" },
            new Tipos_Intermedia { Id_Tipos_Intermedia = 3, Id_Tipo_Portatil = 2, Id_Tipo_Implementos = 3, Posicion_Montaje = "Base Inferior" },
            new Tipos_Intermedia { Id_Tipos_Intermedia = 4, Id_Tipo_Portatil = 3, Id_Tipo_Implementos = 4, Posicion_Montaje = "Sobre Lavamanos" },
            new Tipos_Intermedia { Id_Tipos_Intermedia = 5, Id_Tipo_Portatil = 3, Id_Tipo_Implementos = 5, Posicion_Montaje = "Techo" }
        };
        //----------------------------------------------------------------------------------------------------------------------------------------------------
    
        var op = new OperacionesBaños();

            Console.WriteLine("=== REPORTE DE NEGOCIO ===");
            
            // Función 1: Envíos
            Console.WriteLine($"Envíos atrasados: {op.ObtenerEnviosRetrasados(listaEnvios)}");

            // Función 2: Stock por Sede (Sede 1)
            Console.WriteLine($"Baños disponibles en Sede 1: {op.StockDisponibleSede(1, portatiles)}");

            // Función 3: Finanzas
            Console.WriteLine($"Dinero pendiente de cobro: {op.CalcularCarteraPendiente(listaFacturas, listaPagos):C}");

            // Función 4: Rendimiento Técnico (Empleado 4)
            Console.WriteLine($"Gasto en técnico ID 4: {op.GastoMantenimientoPorTecnico(4, listaMantenimientos):C}");

            // Función 5: Contratos próximos a vencer
            Console.WriteLine("\n--- Contratos por vencer ---");
            var vencidos = op.ContratosPorVencer(listaContratos);
            vencidos.ForEach(c => Console.WriteLine($"ID: {c.Id_Contratos} | Vence: {c.Fecha_Expiracion.ToShortDateString()}"));

            Console.ReadLine(); // Para que no se cierre la consola
    
    }



    // Clase de Funciones

    public class OperacionesBaños
    {
        // 1. ALERTAS DE LOGÍSTICA: Envíos que no se han entregado a tiempo
        public int ObtenerEnviosRetrasados(List<Envios> envios) => 
            envios.Count(e => e.Fecha_Entrega_Estimada < DateTime.Now);

        // 2. DISPONIBILIDAD DE STOCK: Baños listos para alquilar en una sede específica
        public int StockDisponibleSede(int idSede, List<Portatiles> inventario) => 
            inventario.Count(p => p.Id_Sede == idSede && p.Estado_Actual == "Disponible");

        // 3. CARTERA POR COBRAR: Total de dinero que los clientes deben 
        public decimal CalcularCarteraPendiente(List<Facturas> facturas, List<Pagos> pagos)
        {
            decimal totalFacturado = facturas.Sum(f => f.Total);
            decimal totalRecaudado = pagos.Sum(p => p.Total_Pagado);
            return totalFacturado - totalRecaudado;
        }

        // 4. RENDIMIENTO OPERATIVO: Costo total de mantenimientos realizados por un empleado
        public decimal GastoMantenimientoPorTecnico(int idEmp, List<Mantenimiento> mant) => 
            mant.Where(m => m.Id_Empleado == idEmp).Sum(m => m.Costo_Mano_Obra);

        // 5. ALERTAS DE CONTRATOS: Contratos que vencen en los próximos 30 días
        public List<Contratos> ContratosPorVencer(List<Contratos> contratos) => 
            contratos.Where(c => c.Fecha_Expiracion >= DateTime.Now && 
                                c.Fecha_Expiracion <= DateTime.Now.AddDays(30)).ToList();
    }


}









//I. Entidades Base

public class Portatiles
{
    public int Id_Portatil { get; set; }
    public string Numero_Serial { get; set; }
    public DateTime Fecha_Fabricacion { get; set; }
    public string Estado_Actual { get; set; }

    // N:1
    public int Id_Tipo_Portatil { get; set; }
    public int Id_Sede { get; set; }
    public int Id_Compra { get; set; }

    public Tipos_Portatiles? _Tipo_Portatil { get; set; }
    public Sedes? _Sede { get; set; }
    public Compras? _Compra { get; set; }


    // 1:N
    public List<Implementos>? Implementos { get; set; }
    public List<Mantenimiento>? Mantenimientos { get; set; }
    public List<Prestamos_Portatiles>? Prestamos_Portatiles { get; set; }
    public List<Detalle_Facturas>? Detalle_Facturas { get; set; }
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
    public List<Tipos_Intermedia>? Tipos_Intermedias { get; set; }
}

public class Tipo_Aseo_Elementos 
{
    public int Id_Tipo_Aseo_Elementos { get; set;} 
    public string Uso { get; set; }
    public string Instrucciones_Uso { get; set; }
    public decimal medida_litros {get; set;}
    public string toxicidad {get; set;}

    public List<Aseo_Elementos>? Aseo_Elementos { get; set; }
}
public class Tipo_Implementos 
{
    public int Id_Tipo_Implementos { get; set; }
    public string Nombre { get; set; }   
    public string Descripcion { get; set; }
    public decimal ancho { get; set; }
    public decimal largo { get; set; }
    public decimal alto { get; set; }
    public List<Implementos>? Implementos { get; set; }
    public List<Tipos_Intermedia> Tipos_Intermedias { get; set; }
}

public class Implementos 
{
    public int Id_Implemento { get; set; }
    public int Vida_Util { get; set; }
    public string Estado { get; set; }
    public DateTime fecha_fabricacion { get; set; }
    public string Marca { get; set; }
    public decimal Costo { get; set; }

    // N:1
    public int Id_Portatil { get; set; }
    public int Id_Bodega { get; set; }
    public int Tipo_Implementos { get; set; }

    public Tipo_Implementos? _Tipo_Implementos { get; set; }
    public Portatiles? _Portatil { get; set; }
    public Bodegas? _Bodega { get; set; }


}

public class Aseo_Elementos 
{
    public int Id_Aseo_Elemento { get; set; }
    public DateTime Fecha_Vencimiento { get; set; }
    public int Cantidad { get; set; }
    public string Marca { get; set; }
    public decimal Costo { get; set; }


    // N:1
    public int Id_Tipo_Aseo_Elementos { get; set; }
    public int Id_Mantenimiento { get; set; }
    public Mantenimiento? _Mantenimiento { get; set; }
    public Tipo_Aseo_Elementos? _Tipo_Aseo_Elemento { get; set; }

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
    public List<Aseo_Elementos> Aseo_Elementos { get; set; }
}


public class Historial_Precios
{
    public int Id_Historial { get; set; }
    public decimal Valor { get; set; }
    public DateTime Fecha_Inicio { get; set; }
    public DateTime Fecha_Fin { get; set; }
    public string Motivo_Cambio { get; set; }

    // N:1
    public int Id_Tipo_Portatil { get; set; }
    public Tipos_Portatiles? _Tipo_Portatiles { get; set; }
}


//II. Entidades de Actores y Acceso
public class Personas
{
    public int id_personas { get; set; }
    public string cedula { get; set; }
    public string nombre { get; set; }
    public string correo { get; set; }
    public string Telefono { get; set; }
    
    // 1:1
    public int Id_Usuario { get; set; }
    public Usuarios? _Usuario { get; set; }
}

public class Clientes : Personas
{
    public enum CategoriaCliente
{
    Constructora = 1,
    OrganizadorEventos = 2,
    EntidadPublica = 3,
    Industrial = 4,
    Particular = 5
}
    public string Razon_Social { get; set; }
    public string Nit_CC { get; set; }
    public string Direccion_Fiscal { get; set; }
    public CategoriaCliente Tipo_Cliente { get; set; }

    // 1:N
    public List<Contratos>? Contratos { get; set; }
    public List<Facturas>? Facturas { get; set; }
}

public class Empleados : Personas
{
    public DateTime Fecha_Ingreso { get; set; }

    // N:1
    public int Id_Rol { get; set; }
    public Roles_Empleados? _Rol { get; set; }
    
    //1:1
    public int Id_Usuario { get; set; }
    public Usuarios? _Usuario  { get; set; }

    // 1:N
    public List<Mantenimiento>? Mantenimientos { get; set; }
    public List<Envios>? Envios { get; set; }

    
}
public class Roles_Empleados
{
    public enum Niveles_Acceso
    {
        superadmin = 1,
        Gerencial = 2,
        Supervisor = 3,
        Invitado = 4
    }
    public int Id_Rol { get; set; }
    public string Nombre_Rol { get; set; }
    public string Descripcion_Rol { get; set; }
    public decimal Salario_Base { get; set; }
    public Niveles_Acceso Permisos { get; set; }

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

    //1:1
    public int id_personas { get; set; }
    public Personas? _Persona { get; set; }
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
    // 1:N
    public List<Envios>? Envios { get; set; }

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

    public List<Portatiles>? Portatiles { get; set; }

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
    public int Id_Portatil { get; set; }

    public Prestamos? _Prestamo { get; set; }
    public Empleados? _Empleado { get; set; }
    public Portatiles? _Portatil { get; set; }

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
    public int Id_Portatil { get; set; }
    public Facturas? _Factura { get; set; }
    public Portatiles? _Portatil { get; set; }
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

public class Tipos_Intermedia
{
    public int Id_Tipos_Intermedia { get; set; }           
    public string Posicion_Montaje { get; set; } 
    
    // N:1
    public int Id_Tipo_Implementos { get; set; }
    public int Id_Tipo_Portatil { get; set; }
    public Tipos_Portatiles? _Tipo_Portatil { get; set; }
    public Tipo_Implementos? _Tipo_Implemento { get; set; }
}
