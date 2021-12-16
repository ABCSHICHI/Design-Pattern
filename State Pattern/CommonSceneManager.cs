using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    class CommonSceneManager
    {
        private string m_state = "开始";

        //更换场景
        public void ChangeScene(string stateName)
        {
            m_state = stateName;
            switch (m_state)
            {
                case "菜单":
                    Console.WriteLine("载入菜单场景");
                    break;
                case "主场景":
                    Console.WriteLine("载入主场景");
                    break;
                default:
                    break;
            }
        }

        //更新
        public void Update()
        {
            switch (m_state)
            {
                case "开始":
                    Console.WriteLine("载入主场景");
                    break;
                case "主场景":
                    Console.WriteLine("00000");
                    break;
                case "菜单":
                    Console.WriteLine("11111");
                    break;
                default:
                    break;
            }
        }
    }
}
