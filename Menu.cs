using System;

namespace GestionProductos
{
    public class Menu
    {
        private Almacen miAlmacen = new Almacen();

        public void Mostrar()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("=== GESTION DE PRODUCTOS  ===");
                Console.WriteLine("1. Registrar | 2. Buscar | 3. Eliminar | 4. Listar | 5. Salir");
                Console.Write("\nOpción: ");
                
                string? op = Console.ReadLine();
                switch (op)
                {
                    case "1": Registrar(); break;
                    case "2": Buscar(); break;
                    case "3": Eliminar(); break;
                    case "4": Listar(); break;
                    case "5": continuar = false; break;
                }
            }
        }

        private void Registrar()
        {
            Console.WriteLine("\n-- Nuevo Producto --");
            Console.Write("Codigo: "); string c = Console.ReadLine() ?? "";
            Console.Write("Nombre: "); string n = Console.ReadLine() ?? "";
            Console.Write("Precio: "); double.TryParse(Console.ReadLine(), out double p);

            // Ahora Almacen ya tiene el método Agregar
            if (miAlmacen.Agregar(new Producto(c, n, p)))
                Console.WriteLine("Guardado con exito!");
            else
                Console.WriteLine("Error: El codigo ya existe.");
            Console.ReadKey();
        }

        private void Buscar()
        {
            Console.Write("\nCodigo a buscar: ");
            var prod = miAlmacen.Buscar(Console.ReadLine() ?? "");
            Console.WriteLine(prod != null ? $"Resultado: {prod.Nombre} - RD${prod.Precio}" : "No encontrado.");
            Console.ReadKey();
        }

        private void Eliminar()
        {
            Console.Write("\nCódigo a eliminar: ");
            if (miAlmacen.Eliminar(Console.ReadLine() ?? ""))
                Console.WriteLine("Producto borrado.");
            else
                Console.WriteLine("No se encontro el producto.");
            Console.ReadKey();
        }

        private void Listar()
        {
            Console.WriteLine("\n-- Inventario --");
            foreach (var p in miAlmacen.Listar())
                Console.WriteLine($"{p.Codigo} | {p.Nombre} | RD${p.Precio}");
            Console.WriteLine($"Total: {miAlmacen.Total()}");
            Console.ReadKey();
        }
    }
}