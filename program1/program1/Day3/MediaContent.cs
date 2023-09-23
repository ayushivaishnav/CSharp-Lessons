using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Program1.Day3
{
    internal class MediaContent
    {
        public virtual void StartPlayingContent()
        {
            Console.WriteLine("Start");
        }
        public virtual void StopPlayingContent()
        {
            Console.WriteLine("Stop");
        }
        public virtual void PausePlayingContent()
        {
            Console.WriteLine("Pause");
        }
        public virtual void ContinuePlayingContent()
        {
            Console.WriteLine("Continue");
        }
        public override sealed string ToString()
        {
            return "OTT";
        }
        internal class AudioContent : MediaContent
        {
            public override sealed void StartPlayingContent()
            {
                Console.WriteLine("Start form Audio Content");
            }
        }
        //End of audio
        internal class VideoContent : AudioContent
        {



        }
        //End of video
        internal class MediaTester
        {
            public static void TestOne()
            {

            }
            //End of media tester
        }
    }
}
