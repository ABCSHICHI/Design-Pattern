using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern.MediaInterface.Entity
{
    class VlcPlayer : AdvanceMediaPlayer
    {
        public void PlayMp4(string fileName)
        {
        }

        public void PlayVlc(string fileName)
        {
            Console.WriteLine("Playing vlc file. Name: " + fileName);
        }
    }
}
