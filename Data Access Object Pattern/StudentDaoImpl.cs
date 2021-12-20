using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Object_Pattern
{
    /// <summary>
    /// 数据访问对象实体类
    /// 注： 该类实现了上述的接口， 该类负责从数据源获取数据，数据源可以是数据库，也是以是xml，或者其他的存储机制
    /// </summary>
    class StudentDaoImpl : StudentDao
    {
        //列表当作一个数据库
        List<Student> students;

        public StudentDaoImpl()
        {
            students = new List<Student>();
            Student student_1 = new Student("Robert", 0);
            Student student_2 = new Student("John", 1);
            students.Add(student_1);
            students.Add(student_2);

        }

        public void DeleteStudent(Student student)
        {
            students.RemoveAt(student.RollNo);
            Console.WriteLine("Student: Roll No " + student.RollNo
         + ", deleted from database");
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public Student GetStudent(int rollNo)
        {
            return students[rollNo];
        }

        public void UpdataStudent(Student student)
        {
            students[student.RollNo].Name = student.Name;
            Console.WriteLine("Student: Roll No " + student.RollNo
         + ", updated in the database");
        }
    }
}
