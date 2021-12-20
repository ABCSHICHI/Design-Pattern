using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Object_Pattern
{
    /// <summary>
    /// 数据访问对象接口
    /// 注： 该接口定义了在一个模型对象上要执行的标准操作
    /// </summary>
    public interface StudentDao
    {
        List<Student> GetAllStudents();
        Student GetStudent(int rollNo);
        void UpdataStudent(Student student);
        void DeleteStudent(Student student);

    }
}
