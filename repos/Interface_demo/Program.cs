namespace Interface_demo
{
    public interface IVehicle
    {
        void Drive();
        bool Refuel(int amount);
    }

    public class Car : IVehicle
    {
        public int Fuel { get; set; }

        public Car(int fuel)
        {
            Fuel = fuel;
        }

        public void Drive()
        {
            if (Fuel > 0)
            {
                Console.WriteLine("Driving");
            }
            else
            {
                Console.WriteLine("Not fuel");
            }
        }

        public bool Refuel(int amount)
        {
            Fuel += amount;
            return true;
        }
    }

    public class FirstInterface
    {
        public static void Main(string[] args)
        {
            Car car = new Car(0);
            Console.WriteLine("Enter the amount of gasoline to refuel");
            int fuel = Convert.ToInt16(Console.ReadLine());
            if (car.Refuel(fuel))
            {
                car.Drive();
            }
        }


    }
}