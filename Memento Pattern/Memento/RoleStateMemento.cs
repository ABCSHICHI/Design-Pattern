using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Pattern
{
    class RoleStateMemento
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

        //保存当前角色数据
        public RoleStateMemento(int vitality, int attack, int defense)
        {
            this.vitality = vitality;
            this.attack = attack;
            this.defense = defense;
        }
    }
}
