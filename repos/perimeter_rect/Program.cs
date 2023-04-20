using System.ComponentModel.DataAnnotations;

namespace perimeter_rect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the length of rectangle");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the breadth of the rectangle");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double perimeter;

            perimeter = 2 * (num1 + num2);
            Console.WriteLine("perimeter of a reactangle is "+perimeter);

        }
    }
}