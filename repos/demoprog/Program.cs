namespace demoprog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of A");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of B");
            double B = Convert.ToDouble(Console.ReadLine());

            double sum = (A + B) / 2;
            Console.WriteLine("Enter the sum = " + sum);
        }
    }
}