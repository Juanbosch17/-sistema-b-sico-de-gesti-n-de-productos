using System;
using System.Collections.Generic;
using System.Linq;

namespace GestionProductos
{
    public class Almacen 
    {
        // Contenedor dinImico (List<T>)
        private List<Producto> _productos = new List<Producto>();

        // metodo para agregar un producto
        public bool Agregar(Producto p)
        {
            // validar que no exista un producto con el mismo codigo
            if (_productos.Any(x => x.Codigo == p.Codigo)) 
            {
                return false; 
            }
            
            _productos.Add(p);
            return true;
        }

        // metodo de busqueda por codigo
        public Producto? Buscar(string codigo) 
        {
            return _productos.FirstOrDefault(p => p.Codigo == codigo);
        }

        // metodo para eliminar por codigo
        public bool Eliminar(string codigo)
        {
            var p = Buscar(codigo);
            if (p == null) return false;
            return _productos.Remove(p);
        }

        // metodo de listado completo
        public List<Producto> Listar() => _productos;
        public int Total() => _productos.Count;
    }
}
