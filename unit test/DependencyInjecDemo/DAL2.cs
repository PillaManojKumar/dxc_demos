using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjecDemo
{
    public class DAL2 : IDAL
    {
        public string GetData()
        {
            return "Data Acessed Sucessfully";
        }
    }
}
