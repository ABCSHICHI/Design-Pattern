using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //从库中拿到数据
            Student model = RetrieveStudentFromDatabase();

            //创建一个视图：把学生详细信息输出到控制台
            StudentView view = new StudentView();
            StudentController controller = new StudentController(model, view);

            controller.SetStudentName("Shichi");

            controller.UpdateView();

        }

        private static Student RetrieveStudentFromDatabase()
        {
            Student student = new Student();
            student.Name = "Robter";
            student.RollNo = "10010";
            return student;
        }
    }
}
