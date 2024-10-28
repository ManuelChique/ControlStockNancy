using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Lote
    {
        public int ID { get; set; }                   // Identificador único del lote
        public string IdProducto { get; set; }        // Clave foránea que hace referencia a la tabla de productos
        public DateTime FechaVencimiento { get; set; } // Fecha de vencimiento del lote específico
        public int Cantidad { get; set; }             // Cantidad de unidades en este lote específico

        // Constructor sin parámetros
        public Lote() { }

        // Constructor con parámetros
        public Lote(int id, string idProducto, DateTime fechaVencimiento, int cantidad)
        {
            ID = id;
            IdProducto = idProducto;
            FechaVencimiento = fechaVencimiento;
            Cantidad = cantidad;
        }
    }

}
