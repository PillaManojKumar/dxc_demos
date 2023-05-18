using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjecDemo
{
    public class DAL : IDAL
    {
        public string GetData()
        {
            return "This is Dependency Injection Demo";
        }
    }
}
