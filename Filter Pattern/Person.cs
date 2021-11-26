using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter_Pattern
{
    class Person
    {
        private string name;
        private string gender;
        private string maritalStatus;

        public Person(string name, string gender, string maritalStatus)
        {
            this.name = name;
            this.gender = gender;
            this.maritalStatus = maritalStatus;
        }

        public string GetName()
        {
            return name;
        }

        public string GetGender()
        {
            return gender;
        }
        public string GetMaritalStatus()
        {
            return maritalStatus;
        }
    }
}
