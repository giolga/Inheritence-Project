using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InheritanceC
{
    internal class VideoPost : Post
    {
        protected bool isPlaying = false;
        protected int currDuration = 0;

        Timer timer;

        protected string VideoURL { get; set; }
        protected int Length { get; set; }
        public VideoPost()
        {

        }

        public VideoPost(string title, string sendByUserName, string videoURL, bool isPublic, int length)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.VideoURL = videoURL;
            this.IsPublic = isPublic;
            this.Length = length;
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallBack, null, 0, 1000);
            }
        }

        private void TimerCallBack(Object o)
        {
            if (currDuration < Length)
            {
                currDuration += 1;
                Console.WriteLine("Video at {0}s", currDuration);
                GC.Collect();//Garbage Collection
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stopped at {0}s", currDuration);
                currDuration = 0;
                timer.Dispose();
            }
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} {3} - by {4}", this.ID, this.Title, this.VideoURL, this.Length, this.SendByUserName);

        }
    }
}
