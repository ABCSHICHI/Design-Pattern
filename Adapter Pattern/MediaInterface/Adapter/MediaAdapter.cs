
using Adapter_Pattern.MediaInterface.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern.MediaInterface.Adapter
{
    class MediaAdapter : MediaPlayer
    {
        AdvanceMediaPlayer advanceMediaPlayer;

        public MediaAdapter(string audioType)
        {
            if (audioType.Equals("vlc"))
            {
                advanceMediaPlayer = new VlcPlayer();
            }
            else if (audioType.Equals("mp4"))
            {
                advanceMediaPlayer = new Mp4Player();
            }
        }

        public void Play(string audioType, string fileName)
        {
            if (audioType.Equals("vlc"))
            {
                advanceMediaPlayer.PlayVlc(fileName);
            }
            else if (audioType.Equals("mp4"))
            {
                advanceMediaPlayer.PlayMp4(fileName);
            }
        }
    }
}
