using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Object_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDao studentDao = new StudentDaoImpl();

            //输出所有的学生
            foreach (var item in studentDao.GetAllStudents())
            {
                Console.WriteLine("Student: [RollNo : "
                    + item.RollNo + ", Name : " + item.Name + " ]");
            }
            //更新学生
            Student student = studentDao.GetAllStudents()[0];
            student.Name = "Michael";
            studentDao.UpdataStudent(student);

            //获取学生
            student = studentDao.GetAllStudents()[0];
            Console.WriteLine("Student: [RollNo : "
            + student.RollNo + ", Name : " + student.Name + " ]");
        }
    }
}
