using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class OperasBas
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Operacion { get; set; }
        public int Res { get; set; }

        public int calcular()
        {
            switch (Operacion)
            {
                case 1:
                    return suma();
                case 2:
                    return resta();
                case 3:
                    return multi();
                case 4:
                    return div();
                default:
                    return 0;
            }
        }
        public int div()
        {
            return Num1 / Num2;
        }
        public int multi()
        {
            return Num1 * Num2;
        }

        public int resta()
        {

            return Num1 - Num2;
        }

        public int suma()
        {
            return Num1 + Num2;
        }
    }
}