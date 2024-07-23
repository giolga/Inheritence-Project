using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    /*
     CHALLENGE : add a deriving Class "VideoPost" with a property VideoURL, Length.
     
    Create the required constructor to create a VideoPost
     adjust the ToString() method accordingly
     create an instance of VideoPost

     More advanced - use Timer and a Callback method here
     create fields as required
     add member methods "Play" which should write the current duration of the video
     and "Stop" which should stop the "timer" and write "Stopped at {} seconds"
     play the video after creating the instance and pause it, when the user presses any key
     */
    internal class Program
    {
        static void Main(string[] args)
        {

            Post post1 = new Post("Thanks for the birthday wishes", true, "El Kumi");

            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("Check out my new Muay Thai Switch Kicks :)) <33", "El Kumi", "https:instagram.com/el-kumi/muay-thai-switch-kicks", true); //random url :))
            Console.WriteLine(imagePost1.ToString());

            VideoPost videoPost1 = new VideoPost("Failed Video", "El Kumi", "https://video.com/failed-video", true, 10); // random url :)
            Console.WriteLine(videoPost1.ToString());


            videoPost1.ToString();
            videoPost1.Play();
            Console.WriteLine("Press any key to stop the video!");
            Console.ReadKey();
            videoPost1.Stop();


            Console.ReadKey();
        }
    }
}
