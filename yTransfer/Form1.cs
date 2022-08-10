using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Controls;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using VideoLibrary;




namespace yTransfer
{
    public partial class Form1 : Form
    {
        private YouTube youTube = YouTube.Default;
        private string url;
        private string title;
        public string saveplace;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gpInfo.Visible = false;
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            url = urlBox.Text;
            if (urlToSource(url))
            {
                gpInfo.Visible = true;
                bgUrlToVideo.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Couldnt found!!!");
                gpInfo.Visible = false;
            }
        }


        private void subtitleCheck_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void lblVideoTitle_Click(object sender, EventArgs e)
        {

        }


        private void btnMp4_Click(object sender, EventArgs e)
        {
            //saveToDisk();
            bgSaveMp4.RunWorkerAsync();
        }

        private void urlBox_TextChanged(object sender, EventArgs e)
        {

        }

        public bool urlToSource(string e)
        {
            url = e;
            
            var youTube = YouTube.Default;
            try
            {
                var video = youTube.GetVideo(url); // gets a Video object with info about the video


                var videos = youTube.GetAllVideos(url);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void btnFilePath_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                    filePathBox.Text = folderDialog.SelectedPath + "\\";
                else
                    filePathBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }
        }
        private void lblVideoInfoTextChange(string sender)
        {
            lblVideoInfo.Text = sender;
        }

        private void bgUrlToVideo_DoWork(object sender, DoWorkEventArgs e)
        {
            var video = youTube.GetVideo(url);
            var videos = youTube.GetAllVideos(url);
            var videoInfos = Client.For(YouTube.Default).GetAllVideosAsync(url).GetAwaiter().GetResult();
            var resolutions = videoInfos.Where(j => j.AdaptiveKind == AdaptiveKind.Video).Select(j => j.Resolution);
            var bitRates = videoInfos.Where(j => j.AdaptiveKind == AdaptiveKind.Audio).Select(j => j.AudioBitrate);
            var unknownFormats = videoInfos.Where(j => j.AdaptiveKind == AdaptiveKind.None).Select(j => j.Resolution);


            title = video.Title;
            lblVideoInfo.Invoke((MethodInvoker)(() =>lblVideoInfoTextChange(title)));
            foreach (var item in resolutions)
            {
                if (!cbVq.Items.Contains(item))
                    cbVq.Invoke((MethodInvoker)(() => cbVq.Items.Add(item)));
            }

            if (cbVq.Items.Count > 0)
            {
                cbVq.Invoke((MethodInvoker)(() => cbVq.Sorted = true));
                cbVq.Invoke((MethodInvoker)(() => cbVq.SelectedIndex = 0));
            }

        }

        public void saveToDisk()
        {
            var youTube = YouTube.Default;
            var video = youTube.GetVideo(url);

            string title = video.Title;
            VideoInfo info = video.Info;
            string fileExtension = video.FileExtension;
            string fullName = video.FullName; // same thing as title + fileExtension
            int resolution = video.Resolution;

            var videos = youTube.GetAllVideos(url);
            var videoInfos = Client.For(YouTube.Default).GetAllVideosAsync(url).GetAwaiter().GetResult();
            var resolutions = videoInfos.Where(j => j.AdaptiveKind == AdaptiveKind.Video).Select(j => j.Resolution);
            var maxResolution = videoInfos.First(i => i.Resolution == videoInfos.Max(j => j.Resolution));

            //byte[] bytes = video.GetBytes();
            byte[] max = maxResolution.GetBytes();
            var stream = video.Stream();

            //File.WriteAllBytes(saveplace + fullName, bytes);
            File.WriteAllBytes(filePathBox.Text + fullName, max);


            System.Console.WriteLine("Finish");
        }
        private void bgSaveMp4_DoWork(object sender, DoWorkEventArgs e)
        {

            var youTube = YouTube.Default;
            var video = youTube.GetVideo(url);

            string title = video.Title;
            VideoInfo info = video.Info;
            string fileExtension = video.FileExtension;
            string fullName = video.FullName; // same thing as title + fileExtension
            int resolution = video.Resolution;

            var videos = youTube.GetAllVideos(url);
            var videoInfos = Client.For(YouTube.Default).GetAllVideosAsync(url).GetAwaiter().GetResult();
            var resolutions = videoInfos.Where(j => j.AdaptiveKind == AdaptiveKind.Video).Select(j => j.Resolution);
            var maxResolution = videoInfos.First(i => i.Resolution == videoInfos.Max(j => j.Resolution));

            //byte[] bytes = video.GetBytes();
            byte[] max = maxResolution.GetBytes();
            var stream = video.Stream();

            //File.WriteAllBytes(saveplace + fullName, bytes);
            File.WriteAllBytes(filePathBox.Text + fullName, max);


            System.Console.WriteLine("Finish");
        }
    }
}
