namespace linq1
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }

    internal class Program
    {
        public static void Main()
        {
            List<Employee> listEmployees = new List<Employee>();
            {
                new Employee { Id = 1, Name = "Manoj" },
                new Employee { Id = 2, Name = "Sai" },
                new Employee { Id = 3, Name = "Manu" };

            }

            Employee employee = listEmployees.Find(x => x.Id == 2);
            Console.WriteLine("Id = {0}, Name = {1}", employee.Id, employee.Name);

           

        }
    }
}