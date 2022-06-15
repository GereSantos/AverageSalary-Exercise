using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageSalaryApp.Class
{
    public class People
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public People()
        {
        }

        public People(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}
