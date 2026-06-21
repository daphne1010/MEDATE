using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBicis.Clases
{
    public class Participante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Equipo { get; set; }
        public Participante(string nombre, int edad, string equipo)
        {
            Nombre = nombre;
            Edad = edad;
            Equipo = equipo;
        }
    }
}
