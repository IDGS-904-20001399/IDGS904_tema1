using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;

namespace IDGS904_tema1.Services
{
    public class LeerService
    {
        public List<AgregarTraductor> LeerArchivo()
        {
            var dict = new List<AgregarTraductor>();
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");
            if (File.Exists(archivo))
            {
                var lines = File.ReadAllLines(archivo);
                foreach (var line in lines)
                {
                    dict.Add(new AgregarTraductor(line));
                }
            }
            return dict;
        }
    }
}