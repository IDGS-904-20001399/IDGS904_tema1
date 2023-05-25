using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstApp.Models
{
    public class Temp
    {
        public double Grados { get; set; }
        public string Opcion { get; set; }
        public double Res { get; set; }

        public void CalculateCelcius()
        {
            if (this.Opcion == "Celsius")
            {
                Res = (Grados - 32) / 1.8;
            } else
            {
                Res = (Grados * 1.8) + 32;
            }
        } 
    }
}