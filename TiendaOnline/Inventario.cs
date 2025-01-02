using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Gestión de Inventario:
Crear una clase Inventario que mantenga un registro de todos los productos disponibles en la tienda.
Métodos: AgregarProducto(), EliminarProducto(), BuscarProducto(), ActualizarProducto().
Interacción entre las Clases:
*/

namespace TiendaOnline
{
    internal class Inventario
    {
        public List<Producto> ProductosDisponibles = new List<Producto>();


        //Metodo para agregar Productos a la lista

        public void AgregarProductoDisponible (Producto producto)
        {
            if (EsProductoConStockDisponible(producto))
            {
                ProductosDisponibles.Add(producto); 

            } else
            {
                throw new ArgumentException("No se puede agregar un producto existente o que no tiene stock");
            } 
        }


        //Metodo para evaluar si un producto no esta en la lista , asi no agregamos productos repetidos.

        public bool HayProducto(Producto producto)
        {
            foreach (Producto item in ProductosDisponibles)
            {
                if (item.Nombre == producto.Nombre)
                {
                    return true;    
                }
            }

            return false;   
        }




        //Metodo para evaluar si el stock del producto a buscar en la lista tiene stock.
        public bool EsProductoConStockDisponible(Producto productoX)
        {
            return productoX.Stock > 0;  
        }


        //Metodo para actualizar producto 


        public void ActualizarProducto ()
        {
           
        }
    }
}
