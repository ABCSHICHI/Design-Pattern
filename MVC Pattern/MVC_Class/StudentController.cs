using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Pattern
{
    /// <summary>
    /// 控制器
    /// </summary>
    class StudentController
    {
        private Student model;
        private StudentView view;

        public StudentController(Student model, StudentView view)
        {
            this.model = model;
            this.view = view;
        }

        public void SetStudentName(string name)
        {
            model.Name = name;
        }
        public string GetSetStudent()
        {
            return model.Name;
        }
        public void SetStudentRollNo(string rollNo)
        {
            model.RollNo = rollNo;
        }

        public void UpdateView()
        {
            view.PrintStudentDetail(model.Name, model.RollNo);
        }
        
    }
}
