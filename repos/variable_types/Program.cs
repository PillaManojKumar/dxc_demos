using System.ComponentModel;

namespace variable_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x; //variable declartion
            x = 10; //variable assignment

            int y = 20; // variable declaration with assingment
            const int z = 30;

            int num1, num2, num3;
            num1 = 10;
            num2 = 20;
            num3 = num1 + num2;
            Console.WriteLine(num3);

            float a = 2.5f;
            decimal b = 3.4m;
            
            bool isCompleted = true;
        }
    }
}