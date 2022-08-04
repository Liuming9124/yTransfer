using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VideoLibrary;
using System.IO;

namespace yTransfer
{
    public class media
    {
        private string url;
        public string title;
        private string author;
        public int timelens;
        public bool urlToMedia (string e)
        {
            this.url = e;

            var youTube = YouTube.Default;
            var video = youTube.GetVideo(url); // gets a Video object with info about the video

            this.title = video.Title;
            



            VideoInfo info = video.Info; // (Title, Author, LengthSeconds)

            string title = video.Title;
            string fileExtension = video.FileExtension; //.mp4
            string fullName = video.FullName;           //title.mp4
            int resolution = video.Resolution;          //Video quality ex:(360)




            //File.WriteAllBytes(@"D:\Desktop\" + video.FullName, video.GetBytes());
            System.Console.WriteLine("finish");

            return true;
        }
    }
}
