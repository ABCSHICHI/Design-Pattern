using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Pattern
{
    /// <summary>
    /// 播放器
    /// </summary>
    public abstract class AbstractPlayer
    {
        public void PlayVideo()
        {
            OpenPlayer();
            Play();
            ClosePlayer();
        }

        protected void OpenPlayer()
        {
            Console.WriteLine("打开播放器");
        }
        protected void ClosePlayer()
        {
            Console.WriteLine("关闭播放器");
        }

        public abstract void Play();
    }
}
