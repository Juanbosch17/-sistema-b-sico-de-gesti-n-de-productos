using System;

namespace GestionProductos
{

    public class Menu
    {
        private Almacen miAlmacen = new Almacen();

        public void Mostrar()
        {
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("=== SISTEMA DE GESTION ===");
                Console.WriteLine("1. Registrar | 2. Buscar | 3. Eliminar | 4. Listar | 5. Salir");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine()!;
                switch (opcion)
                {
                    case "1": Registrar(); break;
                    case "2": Buscar(); break;
                    case "3": Eliminar(); break;
                    case "4": Listar(); break;
                    case "5": salir = true; break;
                }
            }
        }

        // Metodos para que el switch los llame y no de error de compilacion
        private void Registrar() { Console.ReadKey(); }
        private void Buscar() {  Console.ReadKey(); }
        private void Eliminar() {  Console.ReadKey(); }
        private void Listar() { Console.ReadKey(); }
    }
}
