1. Abrir visual studio
2. Crear nuevo proyecto
3. “Buscar” Solución en blanco y ponerle nombre
4. Crear proyectos:
    1. Crear nuevo proyecto - Biblioteca de clases - Que corresponde al cerebro del proyecto que no compila por si solo
    2. Eliminar class.cs que es por defecto
    3. Crear aparte un nuevo proyecto - App de consola - Que es el que uso par iniciar el programa
    4. Crear nuevo proyecto aparte - Prueba MSTEST - Que se asegura que cada pieza del proyecto cumpla su función y avisar si algo cambia
    
    ![image.png](attachment:b11ff299-f7e7-4a1a-bd2c-97383e0a0802:image.png)
    
5. Establecer las referencias:
    1. **En `consola`**: Clic derecho en **Dependencias** -> *Agregar referencia de proyecto* -> Marca la casilla de **`libreria_clase`**.
    2. **En `mstest`**: Clic derecho en **Dependencias** -> *Agregar referencia de proyecto* -> Marca la casilla de **`libreria_clase`**.
6. Hacer esto en el proyecto **`libreria_clase`**:
    1. Clic derecho en el proyecto `libreria_clase`.
    2. Selecciona Administrar paquetes NuGet.
    3. Busca e instala en Examinar: `Microsoft.EntityFrameworkCore.SqlServer`.
    4. Confirma que el proyecto esté usando **.NET 10.0**.
7. Crear estas 3 carpetas en la biblioteca de clases
1. Agregar las clases que se van a usar en entidades con agregar → Clase → Clase. La nombré Materiales
1. Las clases deben llevar esta estructura

![image.png](attachment:6541576b-cb65-4102-a554-3cad5e9bb563:image.png)

1. Crear IConexion.cs de tipo interfaz en la carpeta interfaces y lleva esta info. Recuerda reemplazar los valores según el ejercicio

```csharp
using Biblioteca_Clases.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Libreria_Clase.Interfaces
{
    public interface IConexion
    {
        // Este 'DbSet' es el que representa tu tabla de baños en SQL
        DbSet<Materiales>? Materiales { get; set; }
        string? StringConexion { get; set; }
    }
}
```

1. En implementaciones crear la clase Conexion.cs con esta info

```csharp
namespace Biblioteca_Clases.Implementaciones
{
    public class Conexion : DbContext, IConexion
    { 
        public string? StringConexion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.StringConexion!, p => { });
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        public DbSet<>? { get; set; }
    }
}

```

1. En Consola abrir el archivo `Program.cs`.
    1. Borrar el “Hello Word”
    2. Escribir el Siguiente Código
    
    ```csharp
    using Biblioteca_Clases.Implementaciones;
    using System;
    
    // 1. Instanciamos la clase de conexión
    var miConexion = new Conexion();
    
    // 2. Configuramos la ruta usando el punto (.)
    // IMPORTANTE: Asegúrate de que tu base de datos se llame 'DB' o cámbialo aquí
    miConexion.StringConexion = "Server=.;Database=DB;Trusted_Connection=True;TrustServerCertificate=True;";
    
    ```
    
2. Clic derecho en el proyecto **`consola`** -> **Establecer como proyecto de inicio**. El nombre del proyecto se pondrá en **negrita**.
3. Al crear una nueva clase:

![image.png](attachment:39e3130d-9041-4b0c-9d6e-aa32f461ecaa:image.png)

En `IConexion.cs`

```csharp
DbSet<Clientes>? Clientes { get; set; }
```

En `Conexion.cs`

```csharp
public DbSet<Clientes>? Clientes { get; set; }
```

1. Para las pruebas unitarias necesitas

PAQUETES: .SDK, .DESIGN Y ENTITYFRAMEWORK

```csharp
namespace mst_unitarias //Nombre inventado pero igual para todas las pruebas
{
    [TestClass]
    public sealed class SedesUnitaria //Nombre inventado
    {
        [TestMethod]
        public void Ejecutar()
        {
            IConexion conexion = new Conexion();
            conexion.StringConexion = "server=localhost;Integrated Security=True;TrustServerCertificate=true;database=db_video_juegos;";
            var lista = conexion.Sedes!.ToList(); //.Sedes ahí de la entidad
            if (lista.Count > 0)
                return;
            throw new Exception();
        }
    }
}

```

1. Program.cs

```csharp
Console.WriteLine("Conexion de Base de datos");
IConexion conexion = new Conexion();
conexion.StringConexion = "server=localhost;Integrated Security=True;TrustServerCertificate=true;database=carros;";

//De Entidades
var lista_Sedes = conexion.Sedes!.ToList();
var lista_Portatiles = conexion.Portatiles!.ToList();

Console.WriteLine("Final");
```

1. Por si no funcionan las claves primarias

```csharp
using System.ComponentModel.DataAnnotations;

public class Bodegas
{
    [Key] // <--- Esto le dice a C# que "Id_Bodega" es la llave primaria del SQL
    public int Id_Bodega { get; set; }
    public string Nombre { get; set; }
    // ... resto de propiedades
}
```

1. Estructuras de SQL SERVER

```csharp
-- Insertar varios registros a la vez
INSERT INTO Videojuegos (Titulo, Precio, FechaLanzamiento, EnStock, Categoria)
VALUES 
('Elden Ring', 59.99, '2022-02-25', 1, 'RPG'),
('FIFA 24', 69.50, '2023-09-29', 1, 'Deportes'),
('Halo Infinite', 30.00, '2021-12-08', 0, 'Shooter'),
('Zelda: TotK', 65.00, '2023-05-12', 1, 'Aventura');
```

```csharp
-- Agregar una columna nueva
ALTER TABLE Videojuegos ADD Categoria NVARCHAR(50);

-- Cambiar el tipo de dato (ejemplo: hacer el título más largo)
ALTER TABLE Videojuegos ALTER COLUMN Titulo NVARCHAR(200);

-- Borrar una columna si no la necesitas
-- ALTER TABLE Videojuegos DROP COLUMN Categoria;
```

1. Metodos de Linq

```csharp
// --- EL MANUAL DEFINITIVO DE LINQ EN UN SOLO BLOQUE ---

// 1. FILTRADO AVANZADO (Where con múltiples condiciones)
// Sedes en Medellín que tengan un teléfono que empiece por '3'
var sedesFiltradas = conexion.Sedes
    .Where(s => s.Ciudad == "Medellín" && s.Telefono_Contacto.StartsWith("3"))
    .ToList();

// 2. BÚSQUEDA ESPECÍFICA (FirstOrDefault / LastOrDefault)
// El primer portátil que esté activo, o nulo si todos están apagados
var primerActivo = conexion.Portatiles.FirstOrDefault(p => p.Estado_Actual == true);

// 3. ORDENAMIENTO DOBLE (OrderBy y ThenBy)
// Bodegas ordenadas por Ciudad de la A-Z, y si hay empate, por Capacidad de mayor a menor
var bodegasOrdenadas = conexion.Bodegas
    .OrderBy(b => b.Ubicacion)
    .ThenByDescending(b => b.Capacidad_Maxima)
    .ToList();

// 4. PROYECCIÓN Y OBJETOS NUEVOS (Select)
// Crear una lista de frases: "La sede X está en la ciudad Y"
var frasesSedes = conexion.Sedes
    .Select(s => $"La sede {s.Nombre} está en {s.Ciudad}")
    .ToList();

// 5. PAGINACIÓN (Skip y Take) - Ideal para tablas con muchos datos
// Saltarse los primeros 10 registros y tomar los siguientes 5 (Página 3)
var paginaTres = conexion.Portatiles.Skip(10).Take(5).ToList();

// 6. OPERACIONES MATEMÁTICAS (Sum, Average, Min, Max)
int totalCapacidad = conexion.Bodegas.Sum(b => b.Capacidad_Maxima);
double promedioCapacidad = conexion.Bodegas.Average(b => b.Capacidad_Maxima);
int masPequena = conexion.Bodegas.Min(b => b.Capacidad_Maxima);

// 7. AGRUPACIÓN (GroupBy) - Muy potente para reportes
// Agrupar sedes por Ciudad y contar cuántas hay en cada una
var sedesPorCiudad = conexion.Sedes
    .GroupBy(s => s.Ciudad)
    .Select(grupo => new { 
        Ciudad = grupo.Key, 
        Cantidad = grupo.Count() 
    }).ToList();

// 8. UNIÓN DE TABLAS (Join) - Si tuvieras una relación
// Ejemplo: Unir Portátiles con Sedes (suponiendo que Portatiles tiene Id_Sede)
/*
var inventario = conexion.Portatiles
    .Join(conexion.Sedes, 
          p => p.Id_Sede,      // Llave en Portatiles
          s => s.Id_Sede,      // Llave en Sedes
          (p, s) => new { p.Numero_Serial, s.Nombre }) // Resultado
    .ToList();
*/

// 9. CONVERSIÓN A DICCIONARIO (ToDictionary)
// Crear un mapa donde el ID sea la llave y el objeto sea el valor
var mapaSedes = conexion.Sedes.ToDictionary(s => s.Id_Sede);

// --- EL "GOD MODE" DE LINQ EN UNA SOLA CELDA ---

// 1. CUANTIFICADORES (All / Any)
// ¿TODOS los portátiles están activos? (Devuelve true solo si el 100% cumple)
bool todosActivos = conexion.Portatiles.All(p => p.Estado_Actual == true);

// 2. CONTEO CONDICIONAL (Count)
// ¿Cuántas bodegas tienen capacidad entre 50 y 200?
int conteoRango = conexion.Bodegas.Count(b => b.Capacidad_Maxima >= 50 && b.Capacidad_Maxima <= 200);

// 3. SELECCIÓN DE VALORES ÚNICOS (Distinct)
// Obtener una lista de todas las ciudades donde tenemos sedes, sin repetir nombres
var ciudadesUnicas = conexion.Sedes.Select(s => s.Ciudad).Distinct().ToList();

// 4. BÚSQUEDA POR ÍNDICE (ElementAt)
// Obtener el tercer registro de la lista directamente (índice 2)
var terceraSede = conexion.Sedes.OrderBy(s => s.Nombre).ElementAtOrDefault(2);

// 5. AGRUPACIÓN COMPLEJA (GroupBy + Sum/Count)
// Reporte: Por cada ciudad, sumar la capacidad total de sus bodegas
var reporteCiudades = conexion.Bodegas
    .GroupBy(b => b.Ubicacion)
    .Select(g => new {
        Ciudad = g.Key,
        CapacidadTotal = g.Sum(x => x.Capacidad_Maxima),
        NumeroDeBodegas = g.Count()
    }).ToList();

// 6. CONCATENACIÓN Y UNIÓN (Concat / Union)
// Unir dos listas diferentes en una sola (Concat permite duplicados, Union los elimina)
var listaA = conexion.Sedes.Where(s => s.Ciudad == "Medellín");
var listaB = conexion.Sedes.Where(s => s.Ciudad == "Bogotá");
var sedesPrincipales = listaA.Concat(listaB).ToList();

// 7. CONVERTIR LISTA A STRING (String.Join + Select)
// Crear un solo texto con todos los nombres de sedes separados por coma
string nombresJuntos = string.Join(", ", conexion.Sedes.Select(s => s.Nombre));

// 8. MANEJO DE NULOS (DefaultIfEmpty)
// Si la lista está vacía, devuelve un valor por defecto en lugar de un error
var listaSegura = conexion.Portatiles.Where(p => p.Id_Portatil > 999).DefaultIfEmpty().ToList();

// 9. CASTING DE TIPOS (OfType)
// Si tienes una lista de objetos mezclados y solo quieres los de tipo 'Bodegas'
// var soloBodegas = listaMezclada.OfType<Bodegas>().ToList();

// 10. EL "DICCIONARIO" DE BÚSQUEDA RÁPIDA (ToDictionary)
// Crear un buscador donde pongas el Serial y te devuelva el objeto Portátil al instante
var buscadorPortatil = conexion.Portatiles.ToDictionary(p => p.Numero_Serial);
// Uso: var miPortatil = buscadorPortatil["SN-12345"];
```
