using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Pattern
{
    class YoukuPlayer : AbstractPlayer
    {
        public override void Play()
        {
            Console.WriteLine("正在使用优酷播放器播放视频。。。");
        }
    }
}
