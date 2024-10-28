using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
    {
        public int ID { get; set; }                   // Identificador único de cada marca
        public string Nombre { get; set; }       // Nombre de la marca

        // Constructor sin parámetros
        public Marca() { }

        // Constructor con parámetros
        public Marca(int id, string nombreMarca)
        {
            ID = id;
            Nombre = nombreMarca;
        }
    }

}
