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

using VideoLibrary;

namespace yTransfer
{
    public partial class Form1 : Form
    {
        private string url;
        public string title;
        public int timelens;
        public string saveplace;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gpInfo.Visible = false;
        }


        private void mp3Btn_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (urlToSource(urlBox.Text))
            {
                urlToVideo();
                gpInfo.Visible = true;
            }
            else
            {
                MessageBox.Show("Couldnt found!!!");
                gpInfo.Visible = false;
            }
            //lblVideoInfo.Text = title;

        }

        private void pgbMP3_Click(object sender, EventArgs e)
        {

        }

        private void subtitleCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblVideoTitle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                cbFilePath.Text = folderDlg.SelectedPath + "\\";
                saveplace = folderDlg.SelectedPath + "\\";
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }

        }

        private void btnMp4_Click(object sender, EventArgs e)
        {
            saveVideo();
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
                var video = youTube.GetVideo(url); // gets a Video object with info about the video\
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void urlToVideo()
        {
            var youTube = YouTube.Default;
            var videos = youTube.GetAllVideos(url);

            var videoInfos = Client.For(YouTube.Default).GetAllVideosAsync(url).GetAwaiter().GetResult();
            var resolutions = videoInfos.Where(j => j.AdaptiveKind == AdaptiveKind.Video).Select(j => j.Resolution);
            var bitRates = videoInfos.Where(j => j.AdaptiveKind == AdaptiveKind.Audio).Select(j => j.AudioBitrate);
            var unknownFormats = videoInfos.Where(j => j.AdaptiveKind == AdaptiveKind.None).Select(j => j.Resolution);

            foreach (var item in resolutions)
            {
                if (!cbVq.Items.Contains(item))
                    cbVq.Items.Add(item);
            }
            
            if (cbVq.Items.Count > 0)
            {
                cbVq.Invoke((MethodInvoker)(() => cbVq.Sorted = true));
                cbVq.Invoke((MethodInvoker)(() => cbVq.SelectedIndex = 0));
            }
        }
        public void saveVideo()
        {
            var youTube = YouTube.Default;
            var video = youTube.GetVideo(url); // gets a Video object with info about the video\

            VideoInfo info = video.Info; // (Title, Author, LengthSeconds)

            string title = video.Title;
            lblVideoInfo.Text = title;
            string fileExtension = video.FileExtension; //.mp4
            string fullName = video.FullName;           //title.mp4
            int resolution = video.Resolution;          //Video quality ex:(360)

            byte[] bytes = video.GetBytes();
            var stream = video.Stream();

            System.Console.WriteLine(saveplace);
            //File.WriteAllBytes("saveplace" + fullName, bytes);

            System.Console.WriteLine("finish");
        }

    }
}
