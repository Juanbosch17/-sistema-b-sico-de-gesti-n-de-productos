namespace GestionProductos
{
    public class Producto
    {
        // Propiedades automaticas
        public string Codigo { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public double Precio { get; set; }

        // Constructor para facilitar la creacion
        public Producto(string codigo, string nombre, double precio)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
        }

        // Constructor vacio (necesario para inicializadores)
        public Producto() { }
    }
}