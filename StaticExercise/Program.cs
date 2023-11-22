namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celcius = TempConverter.FahrenheitToCelcius(68);
            Console.WriteLine($"Celcius: {celcius}");

            var fahrenheit = TempConverter.CelciusToFahrenheit(.09);
            Console.WriteLine($"Fahrenheit: {fahrenheit}");
        }
    }
}
