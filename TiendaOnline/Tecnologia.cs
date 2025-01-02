using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Tecnología: Tiene un atributo adicional Garantía y un método VerificarGarantía().
*/

namespace TiendaOnline
{
    internal class Tecnologia: Producto , IDescuento
    {
        public DateTime Garantia { get; set; }


        //Constructor

        public Tecnologia(string nombre, decimal precio, int stock, string categoria, DateTime unaGarantia ) : base(nombre, precio, stock, categoria)
        {
            this.Nombre = nombre;
            this.Precio = precio;
            this.ActualizarStock(stock); // Al instanciar un nuevo Producto tipo Ropa mediante el metodo actualizar stock modificamos el stock.
            this.Categoria = categoria;
            this.Garantia = unaGarantia;
        }

        //Metodos


        //Metodo  que evalua si la garantia seteada es mayor a la fecha actual.
        public string VerificarGarantia()
        {
            if (Garantia > DateTime.Now)
            {
                return "Garantía válida";
            }
            else
            {
                return "Garantía expirada";
            }
        }



        //Metodo para evaluar el valor de un precio.
        public bool EvaluarPrecio (decimal unPrecio , decimal unValor , decimal otroValor )
        {
            return unPrecio >= unValor && unPrecio <= otroValor;
        }

        //Metodo Para aplicar descuento en productos de tecnologia.
        public decimal AplicarDescuento()
        {
            decimal descuento = 0;


            if (EvaluarPrecio(Precio, 1000, 2000))
            {
                descuento = 0.1m;

            } else if (EvaluarPrecio(Precio, 2000, 4000))
            {
                descuento = 0.2m;

            } else if (EvaluarPrecio(Precio , 4000 , 10000))
            {
                descuento = 0.30m;

            } else
            {
                throw new ArgumentException("Monto no valido");
            }

            Precio -= Precio * descuento;

            return Precio;
        }


        //Sobre Escribir metodo AjustarPrecio 

        public decimal AjustarPrecio()
        {
            return Precio;
        }
    }
}
