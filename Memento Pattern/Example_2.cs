using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Pattern
{
    class Example_2
    {
        static void Main()
        {
            //创建一个角色
            GameRole hero = new GameRole();
            hero.GetInitState();
            Console.WriteLine("创建英雄");
            hero.Show();

            //存储角色数据
            RoleStateCaretaker c = new RoleStateCaretaker();
            c.Memento = hero.SaveState();

            //hero战斗
            hero.Fight();
            Console.WriteLine("英雄战斗");
            hero.Show();

            //战斗后状态发生变化，所以重新调用以前的数据
            hero.RecoverState(c.Memento);
            Console.WriteLine("英雄复活");
            hero.Show();

        }

    }
}
