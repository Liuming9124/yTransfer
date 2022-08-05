
namespace yTransfer
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.urlBox = new System.Windows.Forms.TextBox();
            this.page = new System.Windows.Forms.TabControl();
            this.pgDownload = new System.Windows.Forms.TabPage();
            this.gpInfo = new System.Windows.Forms.GroupBox();
            this.btnMp4 = new System.Windows.Forms.Button();
            this.pgbMp4 = new System.Windows.Forms.ProgressBar();
            this.btnMp3Download = new System.Windows.Forms.Button();
            this.pgbMP3 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSaveTo = new System.Windows.Forms.Label();
            this.cbFilePath = new System.Windows.Forms.ComboBox();
            this.lblVideoQuality = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.subtitleCheck = new System.Windows.Forms.CheckBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.cbList = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblUrl = new System.Windows.Forms.Label();
            this.pgList = new System.Windows.Forms.TabPage();
            this.pgSetting = new System.Windows.Forms.TabPage();
            this.lblVideoTitle = new System.Windows.Forms.Label();
            this.lblVideoInfo = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.page.SuspendLayout();
            this.pgDownload.SuspendLayout();
            this.gpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // urlBox
            // 
            this.urlBox.Font = new System.Drawing.Font("新細明體", 15F);
            this.urlBox.Location = new System.Drawing.Point(137, 22);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(542, 31);
            this.urlBox.TabIndex = 1;
            // 
            // page
            // 
            this.page.Controls.Add(this.pgDownload);
            this.page.Controls.Add(this.pgList);
            this.page.Controls.Add(this.pgSetting);
            this.page.Cursor = System.Windows.Forms.Cursors.Default;
            this.page.Location = new System.Drawing.Point(0, 0);
            this.page.Name = "page";
            this.page.SelectedIndex = 0;
            this.page.Size = new System.Drawing.Size(801, 456);
            this.page.TabIndex = 11;
            // 
            // pgDownload
            // 
            this.pgDownload.Controls.Add(this.gpInfo);
            this.pgDownload.Controls.Add(this.btnSearch);
            this.pgDownload.Controls.Add(this.lblUrl);
            this.pgDownload.Controls.Add(this.urlBox);
            this.pgDownload.Location = new System.Drawing.Point(4, 22);
            this.pgDownload.Name = "pgDownload";
            this.pgDownload.Padding = new System.Windows.Forms.Padding(3);
            this.pgDownload.Size = new System.Drawing.Size(793, 430);
            this.pgDownload.TabIndex = 0;
            this.pgDownload.Text = "Download";
            this.pgDownload.UseVisualStyleBackColor = true;
            // 
            // gpInfo
            // 
            this.gpInfo.Controls.Add(this.lblVideoInfo);
            this.gpInfo.Controls.Add(this.lblVideoTitle);
            this.gpInfo.Controls.Add(this.btnMp4);
            this.gpInfo.Controls.Add(this.pgbMp4);
            this.gpInfo.Controls.Add(this.btnMp3Download);
            this.gpInfo.Controls.Add(this.pgbMP3);
            this.gpInfo.Controls.Add(this.button1);
            this.gpInfo.Controls.Add(this.lblSaveTo);
            this.gpInfo.Controls.Add(this.cbFilePath);
            this.gpInfo.Controls.Add(this.lblVideoQuality);
            this.gpInfo.Controls.Add(this.comboBox1);
            this.gpInfo.Controls.Add(this.subtitleCheck);
            this.gpInfo.Controls.Add(this.lblLanguage);
            this.gpInfo.Controls.Add(this.cbList);
            this.gpInfo.Font = new System.Drawing.Font("新細明體", 12F);
            this.gpInfo.Location = new System.Drawing.Point(12, 59);
            this.gpInfo.Name = "gpInfo";
            this.gpInfo.Size = new System.Drawing.Size(771, 357);
            this.gpInfo.TabIndex = 11;
            this.gpInfo.TabStop = false;
            this.gpInfo.Text = "Result";
            // 
            // btnMp4
            // 
            this.btnMp4.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnMp4.Location = new System.Drawing.Point(698, 310);
            this.btnMp4.Name = "btnMp4";
            this.btnMp4.Size = new System.Drawing.Size(66, 31);
            this.btnMp4.TabIndex = 16;
            this.btnMp4.Text = "ＭＰ4";
            this.btnMp4.UseVisualStyleBackColor = true;
            this.btnMp4.Click += new System.EventHandler(this.btnMp4_Click);
            // 
            // pgbMp4
            // 
            this.pgbMp4.Location = new System.Drawing.Point(37, 310);
            this.pgbMp4.Name = "pgbMp4";
            this.pgbMp4.Size = new System.Drawing.Size(655, 31);
            this.pgbMp4.TabIndex = 15;
            // 
            // btnMp3Download
            // 
            this.btnMp3Download.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnMp3Download.Location = new System.Drawing.Point(698, 273);
            this.btnMp3Download.Name = "btnMp3Download";
            this.btnMp3Download.Size = new System.Drawing.Size(66, 31);
            this.btnMp3Download.TabIndex = 14;
            this.btnMp3Download.Text = "ＭＰ３";
            this.btnMp3Download.UseVisualStyleBackColor = true;
            // 
            // pgbMP3
            // 
            this.pgbMP3.Location = new System.Drawing.Point(37, 273);
            this.pgbMP3.Name = "pgbMP3";
            this.pgbMP3.Size = new System.Drawing.Size(655, 31);
            this.pgbMP3.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 12F);
            this.button1.Location = new System.Drawing.Point(696, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "FP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSaveTo
            // 
            this.lblSaveTo.AutoSize = true;
            this.lblSaveTo.Font = new System.Drawing.Font("新細明體", 15F);
            this.lblSaveTo.Location = new System.Drawing.Point(41, 194);
            this.lblSaveTo.Name = "lblSaveTo";
            this.lblSaveTo.Size = new System.Drawing.Size(69, 20);
            this.lblSaveTo.TabIndex = 12;
            this.lblSaveTo.Text = "Save To";
            // 
            // cbFilePath
            // 
            this.cbFilePath.Font = new System.Drawing.Font("新細明體", 15F);
            this.cbFilePath.FormattingEnabled = true;
            this.cbFilePath.Items.AddRange(new object[] {
            "Default",
            "English",
            "Chinese (traditional)"});
            this.cbFilePath.Location = new System.Drawing.Point(125, 191);
            this.cbFilePath.Name = "cbFilePath";
            this.cbFilePath.Size = new System.Drawing.Size(565, 28);
            this.cbFilePath.TabIndex = 13;
            // 
            // lblVideoQuality
            // 
            this.lblVideoQuality.AutoSize = true;
            this.lblVideoQuality.Font = new System.Drawing.Font("新細明體", 15F);
            this.lblVideoQuality.Location = new System.Drawing.Point(419, 137);
            this.lblVideoQuality.Name = "lblVideoQuality";
            this.lblVideoQuality.Size = new System.Drawing.Size(114, 20);
            this.lblVideoQuality.TabIndex = 10;
            this.lblVideoQuality.Text = "Video Quality";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("新細明體", 15F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Default",
            "English",
            "Chinese (traditional)"});
            this.comboBox1.Location = new System.Drawing.Point(555, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 28);
            this.comboBox1.TabIndex = 11;
            // 
            // subtitleCheck
            // 
            this.subtitleCheck.AutoSize = true;
            this.subtitleCheck.Font = new System.Drawing.Font("新細明體", 15F);
            this.subtitleCheck.Location = new System.Drawing.Point(28, 136);
            this.subtitleCheck.Name = "subtitleCheck";
            this.subtitleCheck.Size = new System.Drawing.Size(88, 24);
            this.subtitleCheck.TabIndex = 4;
            this.subtitleCheck.Text = "subtitles";
            this.subtitleCheck.UseVisualStyleBackColor = true;
            this.subtitleCheck.CheckedChanged += new System.EventHandler(this.subtitleCheck_CheckedChanged);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("新細明體", 15F);
            this.lblLanguage.Location = new System.Drawing.Point(122, 137);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(74, 20);
            this.lblLanguage.TabIndex = 6;
            this.lblLanguage.Text = "language";
            // 
            // cbList
            // 
            this.cbList.Font = new System.Drawing.Font("新細明體", 15F);
            this.cbList.FormattingEnabled = true;
            this.cbList.Items.AddRange(new object[] {
            "Default",
            "English",
            "Chinese (traditional)"});
            this.cbList.Location = new System.Drawing.Point(202, 132);
            this.cbList.Name = "cbList";
            this.cbList.Size = new System.Drawing.Size(166, 28);
            this.cbList.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnSearch.Location = new System.Drawing.Point(685, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 31);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("新細明體", 15F);
            this.lblUrl.Location = new System.Drawing.Point(12, 25);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(115, 20);
            this.lblUrl.TabIndex = 9;
            this.lblUrl.Text = "Youtube URL";
            // 
            // pgList
            // 
            this.pgList.Location = new System.Drawing.Point(4, 22);
            this.pgList.Name = "pgList";
            this.pgList.Padding = new System.Windows.Forms.Padding(3);
            this.pgList.Size = new System.Drawing.Size(793, 430);
            this.pgList.TabIndex = 1;
            this.pgList.Text = "List";
            this.pgList.UseVisualStyleBackColor = true;
            // 
            // pgSetting
            // 
            this.pgSetting.Location = new System.Drawing.Point(4, 22);
            this.pgSetting.Name = "pgSetting";
            this.pgSetting.Padding = new System.Windows.Forms.Padding(3);
            this.pgSetting.Size = new System.Drawing.Size(793, 430);
            this.pgSetting.TabIndex = 2;
            this.pgSetting.Text = "Setting";
            this.pgSetting.UseVisualStyleBackColor = true;
            // 
            // lblVideoTitle
            // 
            this.lblVideoTitle.AutoSize = true;
            this.lblVideoTitle.Font = new System.Drawing.Font("新細明體", 15F);
            this.lblVideoTitle.Location = new System.Drawing.Point(33, 45);
            this.lblVideoTitle.Name = "lblVideoTitle";
            this.lblVideoTitle.Size = new System.Drawing.Size(155, 20);
            this.lblVideoTitle.TabIndex = 17;
            this.lblVideoTitle.Text = "Video Infomation : ";
            this.lblVideoTitle.Click += new System.EventHandler(this.lblVideoTitle_Click);
            // 
            // lblVideoInfo
            // 
            this.lblVideoInfo.AutoSize = true;
            this.lblVideoInfo.Font = new System.Drawing.Font("新細明體", 15F);
            this.lblVideoInfo.Location = new System.Drawing.Point(198, 45);
            this.lblVideoInfo.Name = "lblVideoInfo";
            this.lblVideoInfo.Size = new System.Drawing.Size(114, 20);
            this.lblVideoInfo.TabIndex = 18;
            this.lblVideoInfo.Text = "Video Quality";
            this.lblVideoInfo.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 453);
            this.Controls.Add(this.page);
            this.Name = "Form1";
            this.Text = "YTransfer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.page.ResumeLayout(false);
            this.pgDownload.ResumeLayout(false);
            this.pgDownload.PerformLayout();
            this.gpInfo.ResumeLayout(false);
            this.gpInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.TabControl page;
        private System.Windows.Forms.TabPage pgDownload;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TabPage pgList;
        private System.Windows.Forms.TabPage pgSetting;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gpInfo;
        private System.Windows.Forms.CheckBox subtitleCheck;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.ComboBox cbList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSaveTo;
        private System.Windows.Forms.ComboBox cbFilePath;
        private System.Windows.Forms.Label lblVideoQuality;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnMp4;
        private System.Windows.Forms.ProgressBar pgbMp4;
        private System.Windows.Forms.Button btnMp3Download;
        private System.Windows.Forms.ProgressBar pgbMP3;
        private System.Windows.Forms.Label lblVideoInfo;
        private System.Windows.Forms.Label lblVideoTitle;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

