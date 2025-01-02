using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Ejercicio Completo: Sistema de Gestión de Tienda Online
Descripción del Problema:
Imagina que eres parte del equipo de desarrollo de una tienda online que vende productos físicos (ropa, tecnología, etc.). Necesitas crear un sistema que
gestione el inventario de productos, las órdenes de los clientes, y los pagos. El sistema debe ser flexible y extensible para adaptarse a futuros cambios,
como agregar nuevos tipos de productos o nuevos métodos de pago.

Requerimientos del Sistema:
Clases y Objetos:

Crear una clase Producto con los atributos comunes de un producto como Nombre, Precio, Stock y Categoría.
Métodos: AjustarPrecio(), ActualizarStock().


Herencia:
Crear una clase base Producto y subclases para productos específicos como Ropa y Tecnología. Cada tipo de producto tiene comportamientos diferentes:
Ropa: Tiene un atributo adicional Tamaño y un método AplicarDescuento().
Tecnología: Tiene un atributo adicional Garantía y un método VerificarGarantía().

Encapsulamiento:
Los productos deben manejar el stock de manera encapsulada. Solo se podrá acceder a este atributo a través de métodos públicos como ActualizarStock(),
pero no directamente desde fuera de la clase.


Polimorfismo:

Crear una interfaz IDescuento con un método AplicarDescuento().
La interfaz será implementada por las subclases Ropa y Tecnología, cada una con una lógica diferente para aplicar el descuento según su tipo.


Interfaz para Pagos:
Crear una interfaz IPago con los métodos Pagar() y CancelarPago().


Implementar diferentes clases que representen diferentes métodos de pago, como PagoConTarjeta, PagoConPaypal, etc. Cada clase debe implementar la interfaz
IPago con su propia lógica.


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
Por ejemplo, si un cliente intenta comprar más unidades de un producto que las disponibles, se debe lanzar una excepción StockInsuficienteException.
Gestión de Inventario:
Crear una clase Inventario que mantenga un registro de todos los productos disponibles en la tienda.
Métodos: AgregarProducto(), EliminarProducto(), BuscarProducto(), ActualizarProducto().
Interacción entre las Clases:

Un cliente realiza una orden de compra, se agregan productos al carrito, se calcula el total con descuentos, y se procede al pago. Si el pago es exitoso,
la orden se confirma y el stock se actualiza.
*/

namespace TiendaOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ropa camiseta = new Ropa("Camiseta", 19.99m, 10, "Ropa", "M");

            Inventario inventarioLocal = new Inventario();

            PagoConPaypal NuevoPagoPaypal = new PagoConPaypal();    

            inventarioLocal.AgregarProductoDisponible(camiseta);

            Orden orden = new Orden("David" , NuevoPagoPaypal); //Mediante el constructor podemos pasar como argumento estos datos.

            orden.AgregarProductoACompra(camiseta);

            orden.CancelarPago();
      
        }
    }
}
