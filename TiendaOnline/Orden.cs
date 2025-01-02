using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Sistema de Ordenes:
Crear una clase Orden que represente una compra realizada por un cliente. Cada orden tiene los siguientes atributos:
Cliente (nombre del cliente)
Productos (lista de productos comprados)
Total (monto total de la orden)
Métodos: CalcularTotal(), MostrarDetalles().
Cada orden debe permitir agregar productos, aplicar descuentos y calcular el total a pagar.

Excepciones:
Implementar excepciones para manejar casos como:
Intentar comprar más productos de los que hay en stock.
Intentar pagar sin haber agregado productos a la orden.
Por ejemplo, si un cliente intenta comprar más unidades de un producto que las disponibles, se debe lanzar una excepción
StockInsuficienteException.
*/

namespace TiendaOnline
{
    internal class Orden
    {
        public string NombreCliente { get; set; }

        List<Producto> Productos = new List<Producto>();

        public decimal Total { get; private set; }


        private IPago MetodoPago { get; set; }


        //Constructor 

        public Orden (string NombreCliente, IPago unMetodo)
        {
            this.NombreCliente = NombreCliente;
            this.MetodoPago = unMetodo;
        } 


        //Metodo para agregar un producto a la lista de compras

        public void AgregarProductoACompra(Producto producto)
        {
            if (producto.Stock > 1) // Mientras el stock sea mayor a 0 se puede agregar un producto a la lista.
            {
                Productos.Add(producto);
                Total = producto.Precio; // Al total se puede acceder solo mediante este metodo que actualiza el
                                         //total con cada compra.

                producto.ActualizarStock(producto.Stock - 1); //Como el metodo ActualizarStock recibe como parametros un entero
                                                              //Aqui le pasamos la cantidadad existente - 1
            }
        }


        //Metodo para eliminar un prodcuto de la lista de compras


        public void EliminarProductoCompra (Producto producto)
        {
            if (BuscarProductoEnCompra(producto)) //Se evalua antes de eliminar un producto si este existe
            {
                Productos.Remove(producto);

            } else
            {
                throw new ArgumentException("No se puede eliminar de la lista un producto que no existe");
            }
        }


        //Metodo para evaluar si existe un el producto pasado como parametros en la lista de compras
        public bool BuscarProductoEnCompra (Producto unProducto)
        {
            foreach (Producto productoX in Productos)
            {
                if (productoX.Nombre == unProducto.Nombre )
                {
                    return true;    
                }  
            }

            return false;
        }


        //Metodo para mostrar los productos comprados y sus detalles.
        public string MostrarProductosComprados()
        {
            StringBuilder detalles = new StringBuilder();
            foreach (Producto producto in Productos)
            {
                detalles.AppendLine($"Nombre: {producto.Nombre}");
            }
            return detalles.ToString();
        }


        //Metodo para calcular el total de la lista de compras


        public string CalcularTotal()
        {
            Total = 0;

            foreach (var producto in Productos)
            {
                Total += producto.Precio;
            }

            return $"{Total}";   
        }


        //Metodo para mostrar los detalles de la orden realizada.

        public void MostrarDetalles ()
        {
            Console.WriteLine($"Hola {NombreCliente} , Usted compro: {MostrarProductosComprados()}");
        }


        //Metodo sobre escrito para procesar pago.

        public void ProcesarPago(IPago metodoPago)
        {
            if (Productos.Count == 0)
            {
                throw new InvalidOperationException("No se puede procesar el pago sin productos en la orden.");
            }

            MetodoPago = metodoPago;

            MetodoPago.Pagar();

            Console.WriteLine($"Metodo pago utilizado : {MetodoPago.ObtenerMetodoPago()}");
        }


        //Metodo sobre escrito par acancelar el pago
        public void CancelarPago()
        {
            if (MetodoPago != null)
            {
                MetodoPago.CancelarPago();
                Console.WriteLine($"Método de pago cancelado: {MetodoPago.ObtenerMetodoPago()}");
            }
            else
            {
                Console.WriteLine("No hay ningún pago para cancelar.");
            }
        }
    }
}
