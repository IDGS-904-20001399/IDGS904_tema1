using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class AgregarTraductor
    {
        public string PalabraEn { get; set; }
        public string PalabraEs { get; set; }
        public AgregarTraductor()
        {

        }

        public AgregarTraductor(string line)
        {
            var palabras = line.Split(',');
            PalabraEs = palabras[0];
            PalabraEn = palabras[1];
        }

        public override string ToString()
        {
            return $"{PalabraEs.ToLower()},{PalabraEn.ToLower()}\n";
        }
    }
}