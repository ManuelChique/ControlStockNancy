using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {
        public string ID { get; set; }              // Identificador único de cada producto
        public Marca Marca { get; set; }            // Objeto de la clase Marca
        public Tipo Tipo { get; set; }              // Objeto de la clase Tipo
        public string Descripcion { get; set; }     // Descripción del producto
        public int CantidadTotal { get; set; }      // Cantidad total del producto en stock
        public decimal PrecioCompra { get; set; }   // Precio de compra de cada producto
        public decimal PrecioVenta { get; set; }    // Precio de venta de cada producto
        public string Imagen { get; set; }          // Dirección local de la imagen del producto

        // Constructor sin parámetros
        public Producto() { }

        // Constructor con parámetros
        public Producto(string idProducto, Marca marca, Tipo tipo, string descripcion, int cantidadTotal, decimal precioCompra, decimal precioVenta, string imagen)
        {
            ID = idProducto;
            Marca = marca;
            Tipo = tipo;
            Descripcion = descripcion;
            CantidadTotal = cantidadTotal;
            PrecioCompra = precioCompra;
            PrecioVenta = precioVenta;
            Imagen = imagen; // Asignación de la imagen
        }
    }
}
