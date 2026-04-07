// ============================================================
// SISTEMA DE INVENTARIO - Clase 1.2
// Estado: Mensaje de bienvenida
// ============================================================


using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;


Console.WriteLine("==========================================");
Console.WriteLine("    SISTEMA DE GESTIÓN DE INVENTARIO      ");
Console.WriteLine("==========================================");
Console.WriteLine();
Console.WriteLine($"Version: {version}");
Console.WriteLine($"Versión: 1.0.0.0");
Console.WriteLine($"Plataforma: {Environment.OSVersion}");
Console.WriteLine($".NET Version: {Environment.Version}");
Console.WriteLine();
Console.WriteLine("Estructura del proyecto:");
Console.WriteLine("     |-- Program.cs");
Console.WriteLine("     |-- InventarioApp.csproj");
Console.WriteLine("     |-- .gitignore");
Console.WriteLine("     |-- README.md");
Console.WriteLine("     |-- src/");
Console.WriteLine("         |-- models/");
Console.WriteLine("Configuración .csproj");
Console.WriteLine("Carpeta src/ creada");
Console.WriteLine("Metadatos configurados");
Console.WriteLine();
Console.WriteLine("Proximo paso: Checkpoint");