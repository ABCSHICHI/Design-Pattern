using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Pattern
{
    /// <summary>
    /// 视图层
    /// </summary>
     public class StudentView
    {
        public void PrintStudentDetail(string studentName, string studentRollNo)
        {
            Console.WriteLine("Student:");
            Console.WriteLine("Name: " + studentName);
            Console.WriteLine("Roll No: " + studentRollNo);

        }
    }
}
