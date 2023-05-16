using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class Productos
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public DateTime Produccion { get; set; }
    }
}