namespace simple_intrst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the principal");
            double principal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the rate");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the time");
            double time = Convert.ToDouble(Console.ReadLine());

            double simpleintrest = (principal * time * rate)/10;

            Console.WriteLine("Final Amount= " + simpleintrest);

        }
    }
}