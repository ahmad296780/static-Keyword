using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Exercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double x)
        {
            return (x - 32) * 5 / 9;
        }
        public static double CelsiusToFahrenheit(double y)
        {
            return (y * 1.8) + 32;
        }
    }
}
