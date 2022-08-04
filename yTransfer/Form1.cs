using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yTransfer
{
    public partial class Form1 : Form
    {
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
            string url = urlBox.Text;
            Boolean sub = subtitleCheck.Checked;
            if (sub)
            {
                string lan = cbList.Text;
                System.Console.WriteLine($"{url}");
                System.Console.WriteLine(sub);
                System.Console.WriteLine(lan);
            }
            else
            {
                System.Console.WriteLine($"{url}");
            }
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            gpInfo.Visible = true;
            var search = new media();
            search.urlToMedia(urlBox.Text);
            
        }

        private void pgbMP3_Click(object sender, EventArgs e)
        {

        }

        private void subtitleCheck_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
