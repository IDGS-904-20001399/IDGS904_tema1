using IDGS904_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class Traducir
    {
        public string Palabra { get; set; }
        public string Idioma { get; set; }

        public string TraducirPalabra()
        {
            var palabra = "La palabra no existe";
            var palabras = new LeerService().LeerArchivo();
            if (Idioma == "Ingles")
            {
                palabra = palabras?.Where(p => p.PalabraEs == Palabra.ToLower()).FirstOrDefault()?.PalabraEn ?? "La palabra no existe";
            }else { 
                palabra = palabras?.Where(p => p.PalabraEn == Palabra.ToLower()).FirstOrDefault()?.PalabraEs ?? "La palabra no existe";
            }
            return palabra;
        }
    }
}