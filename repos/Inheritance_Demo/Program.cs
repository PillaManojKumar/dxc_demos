namespace Inheritance_Demo
{
    class calculator
    {
        public void show()
        {
            Console.WriteLine("This is calculator show");
        }
        public int add(int x, int y)
        {
            return x + y;
        }
        public int sub(int x , int y)
        {
            return (x - y);
        }
        public int mul(int x, int y)
        {
            return x * y;
        }

    class scientificcalc : calculator
        {
            public void show()
            {
                Console.WriteLine("THis id scientificcalc show");
            }
            public void square(int x)
            {
                x = x * x;
            }
            public void cube(int x)
            {
                x = x * x * x;
            }

        }
    class AIcalc : scientificcalc
        {
            public void show()
            {
                Console.WriteLine("This is AIcalc show");
            }
        }
    }
    internal class Program
    {
        static void Main()
        {
            calculator calculator = new calculator();
        }
    }
}