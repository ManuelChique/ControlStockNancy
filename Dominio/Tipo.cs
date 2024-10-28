using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Tipo
    {
        public int ID { get; set; }                   // Identificador único de cada tipo
        public string Nombre { get; set; }        // Nombre del tipo de producto

        // Constructor sin parámetros
        public Tipo() { }

        // Constructor con parámetros
        public Tipo(int id, string nombreTipo)
        {
            ID = id;
            Nombre = nombreTipo;
        }
    }

}
