using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Pattern
{
    /// <summary>
    /// 角色数据类
    /// </summary>
    class GameRole
    {
        /// <summary>
        /// 生命值
        /// </summary>
        private int vitality;
        public int Vitality { get => vitality; set => vitality = value; }

        /// <summary>
        /// 攻击力
        /// </summary>
        private int attack;
        public int Attack { get => attack; set => attack = value; }

        /// <summary>
        /// 防御力
        /// </summary>
        private int defense;
        public int Defense { get => defense; set => defense = value; }

        //获取初始状态
        public void GetInitState()
        {
            this.vitality = 100;
            this.defense = 100;
            this.attack = 100;
        }

        //显示数据
        public void Show()
        {
            Console.WriteLine("State:");
            Console.WriteLine("vitality={0}", vitality);
            Console.WriteLine("Attack={0}", attack);
            Console.WriteLine("Defense={0}", Defense);
        }

        //重置数据
        public void Fight()
        {
            this.vitality = 0;
            this.attack = 0;
            this.defense = 0;
        }

        //从Memento中获取刚刚保存的数据
        public void RecoverState(RoleStateMemento memento)
        {
            this.vitality = memento.Vitality;
            this.attack = memento.Attack;
            this.defense = memento.Defense;
        }

        //保存当前数据到Memento中
        public RoleStateMemento SaveState()
        {
            return new RoleStateMemento(vitality, attack, defense);
        }


    }
}
