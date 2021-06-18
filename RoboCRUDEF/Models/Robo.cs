using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboCRUDEF.Models
{
    public class Robo
    {
        public int RoboId { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public string Objeto_Robado { get; set; }
        public string Valor { get; set; }
        public string Ubicacion { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
    }
}
