using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class Distancia
    {
        public double X1 { get; set; }
        public double X2 { get; set; }
        public double Y1 { get; set; }
        public double Y2 { get; set; }
        public double Resultado { get; set; }

        public double Calcular()
        {
            //√((x_2 - x_1)²+(y_2 - y_1)²)
            return Math.Sqrt((Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2)));
        }
    }
}