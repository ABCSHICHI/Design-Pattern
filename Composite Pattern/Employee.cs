using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    class Employee
    {
        private string name;
        private string dept;
        private int salary;
        private List<Employee> Subordinates;

        public Employee(string name, string dept, int sal)
        {
            this.name = name;
            this.dept = dept;
            this.salary = sal;
            Subordinates = new List<Employee>();
        }

        public void Add(Employee e)
        {
            Subordinates.Add(e);
        }

        public void Remove(Employee e)
        {
            Subordinates.Remove(e);
        }

        public List<Employee> GetSubordinates()
        {
            return Subordinates;
        }

        public string TransString()
        {
            return ("Employee :[ Name : " + name
              + ", dept : " + dept + ", salary :"
              + salary + " ]");
        }
    }
}
