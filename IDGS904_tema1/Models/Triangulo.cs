using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class Triangulo
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }
        public double X3 { get; set; }
        public double Y3 { get; set; }
        public double Area { get; set; }
        public string Type { get; set; }
        public void Calcular()
        {
            //Lado AB = √((x₂ -x₁)² +(y₂ -y₁)²)
            //Lado BC = √((x₃ -x₂)² +(y₃ -y₂)²)
            //Lado CA = √((x₁ -x₃)² +(y₁ -y₃)²)
            double distance1 = Math.Round(Math.Abs(Math.Sqrt((Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2)))), 2);
            double distance2 = Math.Round(Math.Abs(Math.Sqrt((Math.Pow((X3 - X2), 2) + Math.Pow((Y3 - Y2), 2)))), 2);
            double distance3 = Math.Round(Math.Abs(Math.Sqrt((Math.Pow((X1 - X3), 2) + Math.Pow((Y1 - Y3), 2)))), 2);
            var distances = new List<double> { distance1, distance2, distance3 };
            var maxDistance = distances.Max();
            distances.Remove(maxDistance);
            var sumDistances = distances.Sum();
            if (maxDistance < sumDistances)
            {
                bool equalSides = distance1 == distance2 && distance2 == distance3;
                bool diferrentSides = distance1 != distance2 && distance2 != distance3;
                if (equalSides)
                {
                    Type = "Equilatero";
                }
                else if (diferrentSides)
                {
                    Type = "Escaleno";
                }
                else
                {
                    Type = "Isoceles";
                }
                //s = (Lado AB + Lado BC + Lado CA) / 2
                var s = (distance1 + distance2 + distance3) / 2;
                //A = √(s(s - Lado AB)(s - Lado BC)(s - Lado CA))
                //var area = Math.Abs(s * (s - distance1) * (s - distance2) * (X1 - distance3));
                //Area = Math.Sqrt(area);
                Area = 0.5 * Math.Abs((X1 * (Y2 - Y3) + X2 * (Y3 - Y1) + X3 * (Y1 - Y2)));
            }
            else
            {
                Type = "No es un triangulo";
            }
        }

    }
}