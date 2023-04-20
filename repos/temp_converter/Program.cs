namespace temp_converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the temperature in celcius");
            double celcius = Convert.ToDouble(Console.ReadLine());

            double Fahrenheit;

            Fahrenheit = (celcius * 9 / 5) + 32;
            Console.WriteLine("temperature in fahrenheit is " + Fahrenheit);

        }
    }
}