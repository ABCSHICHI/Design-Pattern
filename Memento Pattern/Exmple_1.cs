using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Pattern
{
    class Originator
    {
        private string state;

        public string State { get => state; set => state = value; }

        public void Show()
        {
            Console.WriteLine("State = {0}", State);
        }

        /// <summary>
        /// 从memento中调用之前保存好的参数
        /// </summary>
        /// <param name="memento"></param>
        public void SetMemento(Memento memento)
        {
            this.state = memento.State;
        }

        /// <summary>
        ///  将当前的参数记录到Memento中去
        /// </summary>
        /// <returns></returns>
        public Memento CreateMemento()
        {
            return new Memento(state);
        }

    }

    class Memento
    {
        private string state;
        /// <summary>
        /// 备忘录中只需变成只读就可以了
        /// </summary>
        public string State { get => state; }

        public Memento(string state)
        {
            this.state = state;
        }

    }

    class Caretaker
    {
        private Memento memento;

        internal Memento Memento { get => memento; set => memento = value; }
    }
    class Exmple_1
    {
        static void Main1()
        {
            //初始化Originator，设定初始数据
            Originator o = new Originator();
            o.State = "O";
            o.Show();

            //保存originator传递到Memento中
            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();

            //修改Originator中的数据
            o.State = "T";
            o.Show();

            //调用备忘录中数据，重新更新数据
            o.SetMemento(c.Memento);
            o.Show();
        }
    }
}
