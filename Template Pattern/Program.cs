using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            YoukuPlayer youkuPlayer = new YoukuPlayer();
            youkuPlayer.PlayVideo();

            Console.WriteLine("***************************");

            TencentPlayer tencentPlayer = new TencentPlayer();
            tencentPlayer.PlayVideo();
        }
    }
}
