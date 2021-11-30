using Filter_Pattern.Filter;
using Filter_Pattern.Filter.EntityClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter_Pattern
{
    class FilterPatternDemo
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            persons.Add(new Person("Robert", "Male", "Single"));
            persons.Add(new Person("John", "Male", "Married"));
            persons.Add(new Person("Laura", "Female", "Married"));
            persons.Add(new Person("Diana", "Female", "Single"));
            persons.Add(new Person("Mike", "Male", "Single"));
            persons.Add(new Person("Bobby", "Male", "Single"));

            ICriteria male = new CriteriaMale();
            ICriteria female = new CriteriaFemale();
            ICriteria single = new CriteriaSingle();
            ICriteria singleMale = new AndCriteria(single, male);
            ICriteria singleOrFemale = new OrCriteria(single, female);

            Console.WriteLine("Male: ");
            PrintPersons(male.MeetCriterial(persons));

            Console.WriteLine("\nFemales: ");
            PrintPersons(female.MeetCriterial(persons));

            Console.WriteLine("\nSingle Males: ");
            PrintPersons(singleMale.MeetCriterial(persons));

            Console.WriteLine("\nSingle Or Females: ");
            PrintPersons(singleOrFemale.MeetCriterial(persons));

        }

        private static void PrintPersons(List<Person> persons)
        {
            foreach (Person item in persons)
            {
                Console.WriteLine("Person : [ Name : " + item.GetName()
            + ", Gender : " + item.GetGender()
            + ", Marital Status : " + item.GetMaritalStatus()
            + " ]");
            }
        }
    }
}
