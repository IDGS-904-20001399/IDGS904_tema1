using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Services
{
    public class GuardarServices
    {
        public void GuardarArchivo(AgregarTraductor traductor)
        {
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");
            //File.WriteAllText(archivo, maestros.ToString());
            File.AppendAllText(archivo, traductor.ToString());
        }
    }
}