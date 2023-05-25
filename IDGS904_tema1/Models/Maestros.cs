using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class Maestros
    {

        public Maestros()
        {
        }

        public Maestros(string line)
        {
            var campos = line.Split(',');
            Nombre = campos[0];
            Apaterno = campos[1];
            Amatero = campos[2];
            int.TryParse(campos[3], out int edad);
            Edad = edad;
            Email = campos[4];
        }

        public string Nombre { get; set; }
        public string Apaterno { get; set; }
        public string Amatero { get; set; }
        public int Edad {get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{Nombre},{Apaterno},{Amatero},{Edad},{Email}\n";
        }
    }
}