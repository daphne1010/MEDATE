using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBicis.Clases
{
    public class Historial
    {
        private string archivo = "historial.txt";
        public void GuardarCarrera(string jugador1,string jugador2,string ganador,string tiempo)
        {
            string linea =
                DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
                + ";"
                + jugador1
                + ";"
                + jugador2
                + ";"
                + ganador
                + ";"
                + tiempo;
            File.AppendAllText(archivo,linea + Environment.NewLine);
        }
    }
}