using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int id { get; private set; }
        public string name { get; private set; }

        public Department(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
