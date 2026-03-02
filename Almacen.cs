using System;
using System.Collections.Generic;
using System.Linq;

namespace GestionProductos
{
    public class Almacen 
    {
        // Contenedor dinámico (List<T>)
        private List<Producto> _productos = new List<Producto>();

        // SOLUCIÓN AL ERROR CS1061: Método Agregar
        public bool Agregar(Producto p)
        {
            // Requisito: Evitar códigos duplicados usando LINQ
            if (_productos.Any(x => x.Codigo == p.Codigo)) 
            {
                return false; 
            }
            
            _productos.Add(p);
            return true;
        }

        // Método de búsqueda por código
        public Producto? Buscar(string codigo) 
        {
            return _productos.FirstOrDefault(p => p.Codigo == codigo);
        }

        // Método para eliminar
        public bool Eliminar(string codigo)
        {
            var p = Buscar(codigo);
            if (p == null) return false;
            return _productos.Remove(p);
        }

        // Métodos de listado y conteo
        public List<Producto> Listar() => _productos;
        public int Total() => _productos.Count;
    }
}