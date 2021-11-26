using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern.MediaInterface.Entity
{
    class Mp4Player : AdvanceMediaPlayer
    {
        public void PlayMp4(string fileName)
        {
            Console.WriteLine("Playing PlayMp4 file. Name: " + fileName);
        }

        public void PlayVlc(string fileName)
        {
        }
    }
}
