Console.WriteLine("Sr.No\tCelsius\t\tFahrenheit");

for (int i = 1, celsius = 0; i <= 10; i++, celsius += 10)
{
    double fahrenheit = (celsius * 9.0 / 5.0) + 32.0;
    Console.WriteLine($"{i}\t{celsius}\t\t\t{fahrenheit}");
}