using Unity;

namespace DependencyInjecDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();
            container.RegisterType<IDAL, DAL2>();

            var service = container.Resolve<Service>();
            service.PrintData();
        }
    }
}