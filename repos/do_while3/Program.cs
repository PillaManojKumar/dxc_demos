using System.Runtime.CompilerServices;

char choice;
{
    Console.Write("Enter temperature in Celsius: ");
    double celsius = Convert.ToDouble(Console.ReadLine());
    double fahrenheit = (celsius * 9 / 5) + 32;
    Console.WriteLine("Temperature(celcius)= " + celsius + " \t " + "Temperature(Fahrenheit)= " + fahrenheit);

    Console.Write("Do you want to continue? (y/n): ");
    choice = Convert.ToChar(Console.ReadLine());
    while (choice == 'y' || choice == 'Y');
}
