using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    class SampleTest
    {
        //static void Main()
        //{
        //    foreach (string s in GetEnumerableTest())
        //    {
        //        Console.WriteLine(s);
        //    }
        //}

        public static IEnumerable<string> GetEnumerableTest()
        {
            yield return "begin";

            for (int i = 0; i < 10; i++)
            {
                yield return i.ToString();
            }

            yield return "end";
        }
    }
}
