using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Object_Pattern
{
    /// <summary>
    /// 数值对象/模型对象
    /// 注：包含了 get/set 方法来存储通过使用 DAO 类检索到的数据
    /// </summary>
    public class Student
    {
        private string name;
        private int rollNo;

        public int RollNo { get => rollNo; set => rollNo = value; }
        public string Name { get => name; set => name = value; }

        public Student(string name, int rollNo)
        {
            this.name = name;
            this.rollNo = rollNo;
        }


    }
}
