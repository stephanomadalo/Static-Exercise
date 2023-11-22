using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    static class TempConverter
    {
        public static double FahrenheitToCelcius(double fahrenheit)
        {
            return (fahrenheit - 32) / 1.8;
        }

        public static double CelciusToFahrenheit(double celcius)
        {
            return (celcius * 9) / 5 + 32;
        }

    }
}
