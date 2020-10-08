using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Persona
    {

        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string Cargo { get; set; }
        public int TotalSemanaCotizada { get; set; }
        public decimal IBL { get; set; }

        public Persona() { }

        public Persona(string identificacion, string nombre, int edad, string sexo, int totalSemanaCotizada, decimal iBL, string cargo)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
            TotalSemanaCotizada = totalSemanaCotizada;
            IBL = iBL;
            Cargo = cargo;
        }



    }
}
