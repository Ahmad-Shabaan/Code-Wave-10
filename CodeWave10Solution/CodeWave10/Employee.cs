using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWave10
{
    public class Employee
    {
            public string Name { get; set; }
            public int Age { get; set; }
            public double Salary { get; set; }
            public Employee(string name, int age, double salary)
            {
                this.Age = age;
                this.Name = name;
                this.Salary = salary;
            }
            public Employee()
            {
                this.Name = "";
            }
        
    }
}
