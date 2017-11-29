namespace DogStancer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnResizeAll = new System.Windows.Forms.Button();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNotADog = new System.Windows.Forms.Button();
            this.btnOther = new System.Windows.Forms.Button();
            this.btnLaying = new System.Windows.Forms.Button();
            this.btnStanding = new System.Windows.Forms.Button();
            this.btnJumping = new System.Windows.Forms.Button();
            this.btnRolling = new System.Windows.Forms.Button();
            this.btnSitting = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rtbUrlList = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnImagesDownloadPath = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbImagesDownloadPath = new System.Windows.Forms.TextBox();
            this.btnDownloadGoogleImages = new System.Windows.Forms.Button();
            this.lblUrl = new System.Windows.Forms.Label();
            this.tbGoogleImagesUrl = new System.Windows.Forms.TextBox();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.btnSortedImages = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSortedImagesBasePath = new System.Windows.Forms.TextBox();
            this.btnImagesToSort = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbImagesToSort = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderDialogSettings = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPageSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(921, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 10;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPageSettings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1741, 1321);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.btnResizeAll);
            this.tabPage1.Controls.Add(this.tbFilePath);
            this.tabPage1.Controls.Add(this.btnBack);
            this.tabPage1.Controls.Add(this.btnNotADog);
            this.tabPage1.Controls.Add(this.btnOther);
            this.tabPage1.Controls.Add(this.btnLaying);
            this.tabPage1.Controls.Add(this.btnStanding);
            this.tabPage1.Controls.Add(this.btnJumping);
            this.tabPage1.Controls.Add(this.btnRolling);
            this.tabPage1.Controls.Add(this.btnSitting);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1725, 1274);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Classification";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(324, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1395, 1069);
            this.panel1.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1395, 1069);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnResizeAll
            // 
            this.btnResizeAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResizeAll.Location = new System.Drawing.Point(1096, 13);
            this.btnResizeAll.Name = "btnResizeAll";
            this.btnResizeAll.Size = new System.Drawing.Size(303, 146);
            this.btnResizeAll.TabIndex = 22;
            this.btnResizeAll.Text = "Resize All";
            this.btnResizeAll.UseVisualStyleBackColor = true;
            this.btnResizeAll.Click += new System.EventHandler(this.btnResizeAll_Click);
            // 
            // tbFilePath
            // 
            this.tbFilePath.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbFilePath.Location = new System.Drawing.Point(3, 1240);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(1719, 31);
            this.tbFilePath.TabIndex = 21;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(173, 146);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNotADog
            // 
            this.btnNotADog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNotADog.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotADog.Location = new System.Drawing.Point(586, 3);
            this.btnNotADog.Name = "btnNotADog";
            this.btnNotADog.Size = new System.Drawing.Size(303, 146);
            this.btnNotADog.TabIndex = 19;
            this.btnNotADog.Text = "Not A Dog";
            this.btnNotADog.UseVisualStyleBackColor = false;
            this.btnNotADog.Click += new System.EventHandler(this.btnNotADog_Click);
            // 
            // btnOther
            // 
            this.btnOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOther.Location = new System.Drawing.Point(208, 3);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(303, 146);
            this.btnOther.TabIndex = 18;
            this.btnOther.Text = "Unsure";
            this.btnOther.UseVisualStyleBackColor = true;
            this.btnOther.Click += new System.EventHandler(this.btnOther_Click);
            // 
            // btnLaying
            // 
            this.btnLaying.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaying.Location = new System.Drawing.Point(12, 670);
            this.btnLaying.Name = "btnLaying";
            this.btnLaying.Size = new System.Drawing.Size(303, 146);
            this.btnLaying.TabIndex = 17;
            this.btnLaying.Text = "Laying Down";
            this.btnLaying.UseVisualStyleBackColor = false;
            this.btnLaying.Click += new System.EventHandler(this.btnLaying_Click);
            // 
            // btnStanding
            // 
            this.btnStanding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnStanding.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStanding.Location = new System.Drawing.Point(12, 334);
            this.btnStanding.Name = "btnStanding";
            this.btnStanding.Size = new System.Drawing.Size(303, 146);
            this.btnStanding.TabIndex = 16;
            this.btnStanding.Text = "Standing";
            this.btnStanding.UseVisualStyleBackColor = false;
            this.btnStanding.Click += new System.EventHandler(this.btnStanding_Click);
            // 
            // btnJumping
            // 
            this.btnJumping.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJumping.Location = new System.Drawing.Point(12, 170);
            this.btnJumping.Name = "btnJumping";
            this.btnJumping.Size = new System.Drawing.Size(303, 146);
            this.btnJumping.TabIndex = 15;
            this.btnJumping.Text = "Jumping";
            this.btnJumping.UseVisualStyleBackColor = true;
            this.btnJumping.Click += new System.EventHandler(this.btnJumping_Click);
            // 
            // btnRolling
            // 
            this.btnRolling.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRolling.Location = new System.Drawing.Point(12, 839);
            this.btnRolling.Name = "btnRolling";
            this.btnRolling.Size = new System.Drawing.Size(303, 146);
            this.btnRolling.TabIndex = 14;
            this.btnRolling.Text = "Rolling";
            this.btnRolling.UseVisualStyleBackColor = true;
            this.btnRolling.Click += new System.EventHandler(this.btnRolling_Click);
            // 
            // btnSitting
            // 
            this.btnSitting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSitting.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSitting.Location = new System.Drawing.Point(12, 502);
            this.btnSitting.Name = "btnSitting";
            this.btnSitting.Size = new System.Drawing.Size(303, 146);
            this.btnSitting.TabIndex = 13;
            this.btnSitting.Text = "Sitting";
            this.btnSitting.UseVisualStyleBackColor = false;
            this.btnSitting.Click += new System.EventHandler(this.btnSitting_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1725, 1274);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Find Images";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.rtbUrlList);
            this.panel3.Location = new System.Drawing.Point(6, 338);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1707, 880);
            this.panel3.TabIndex = 1;
            // 
            // rtbUrlList
            // 
            this.rtbUrlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbUrlList.Location = new System.Drawing.Point(0, 0);
            this.rtbUrlList.Name = "rtbUrlList";
            this.rtbUrlList.Size = new System.Drawing.Size(1707, 880);
            this.rtbUrlList.TabIndex = 0;
            this.rtbUrlList.Text = "";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnImagesDownloadPath);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbImagesDownloadPath);
            this.panel2.Controls.Add(this.btnDownloadGoogleImages);
            this.panel2.Controls.Add(this.lblUrl);
            this.panel2.Controls.Add(this.tbGoogleImagesUrl);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1707, 326);
            this.panel2.TabIndex = 0;
            // 
            // btnImagesDownloadPath
            // 
            this.btnImagesDownloadPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImagesDownloadPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagesDownloadPath.Location = new System.Drawing.Point(1521, 77);
            this.btnImagesDownloadPath.Name = "btnImagesDownloadPath";
            this.btnImagesDownloadPath.Size = new System.Drawing.Size(174, 98);
            this.btnImagesDownloadPath.TabIndex = 6;
            this.btnImagesDownloadPath.Text = "Change";
            this.btnImagesDownloadPath.UseVisualStyleBackColor = true;
            this.btnImagesDownloadPath.Click += new System.EventHandler(this.btnImagesDownloadPath_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(267, 241);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 44);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Download Folder";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbImagesDownloadPath
            // 
            this.tbImagesDownloadPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbImagesDownloadPath.Location = new System.Drawing.Point(328, 93);
            this.tbImagesDownloadPath.Name = "tbImagesDownloadPath";
            this.tbImagesDownloadPath.Size = new System.Drawing.Size(1187, 31);
            this.tbImagesDownloadPath.TabIndex = 3;
            this.tbImagesDownloadPath.Text = "C:\\Data\\GoogleImages\\Rolling";
            this.tbImagesDownloadPath.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnDownloadGoogleImages
            // 
            this.btnDownloadGoogleImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadGoogleImages.Location = new System.Drawing.Point(19, 212);
            this.btnDownloadGoogleImages.Name = "btnDownloadGoogleImages";
            this.btnDownloadGoogleImages.Size = new System.Drawing.Size(223, 98);
            this.btnDownloadGoogleImages.TabIndex = 2;
            this.btnDownloadGoogleImages.Text = "Download";
            this.btnDownloadGoogleImages.UseVisualStyleBackColor = true;
            this.btnDownloadGoogleImages.Click += new System.EventHandler(this.btnDownloadGoogleImages_Click);
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(14, 29);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(129, 25);
            this.lblUrl.TabIndex = 1;
            this.lblUrl.Text = "Google URL";
            // 
            // tbGoogleImagesUrl
            // 
            this.tbGoogleImagesUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGoogleImagesUrl.Location = new System.Drawing.Point(328, 23);
            this.tbGoogleImagesUrl.Name = "tbGoogleImagesUrl";
            this.tbGoogleImagesUrl.Size = new System.Drawing.Size(1367, 31);
            this.tbGoogleImagesUrl.TabIndex = 0;
            this.tbGoogleImagesUrl.Text = "https://www.google.com.au/search?q=pictures+of+dogs+rolling+over&rlz=1C1CHBF_en-G" +
    "BAU750AU750&source=lnms&tbm=isch&sa=X&ved=0ahUKEwiCibrY08rXAhUEj5QKHR-WA0wQ_AUIC" +
    "igB&biw=1529&bih=870&dpr=1.1";
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.btnSortedImages);
            this.tabPageSettings.Controls.Add(this.label4);
            this.tabPageSettings.Controls.Add(this.tbSortedImagesBasePath);
            this.tabPageSettings.Controls.Add(this.btnImagesToSort);
            this.tabPageSettings.Controls.Add(this.label3);
            this.tabPageSettings.Controls.Add(this.tbImagesToSort);
            this.tabPageSettings.Location = new System.Drawing.Point(8, 39);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(1725, 1274);
            this.tabPageSettings.TabIndex = 2;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // btnSortedImages
            // 
            this.btnSortedImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortedImages.Location = new System.Drawing.Point(1529, 115);
            this.btnSortedImages.Name = "btnSortedImages";
            this.btnSortedImages.Size = new System.Drawing.Size(174, 100);
            this.btnSortedImages.TabIndex = 12;
            this.btnSortedImages.Text = "Change";
            this.btnSortedImages.UseVisualStyleBackColor = true;
            this.btnSortedImages.Click += new System.EventHandler(this.btnSortedImages_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sorted Images Base Path";
            // 
            // tbSortedImagesBasePath
            // 
            this.tbSortedImagesBasePath.Location = new System.Drawing.Point(283, 131);
            this.tbSortedImagesBasePath.Name = "tbSortedImagesBasePath";
            this.tbSortedImagesBasePath.Size = new System.Drawing.Size(1240, 31);
            this.tbSortedImagesBasePath.TabIndex = 10;
            this.tbSortedImagesBasePath.Text = "C:\\Data\\GoogleImages\\Rolling";
            // 
            // btnImagesToSort
            // 
            this.btnImagesToSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagesToSort.Location = new System.Drawing.Point(1531, 3);
            this.btnImagesToSort.Name = "btnImagesToSort";
            this.btnImagesToSort.Size = new System.Drawing.Size(174, 98);
            this.btnImagesToSort.TabIndex = 9;
            this.btnImagesToSort.Text = "Change";
            this.btnImagesToSort.UseVisualStyleBackColor = true;
            this.btnImagesToSort.Click += new System.EventHandler(this.btnImagesToSort_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Images To Sort";
            // 
            // tbImagesToSort
            // 
            this.tbImagesToSort.Location = new System.Drawing.Point(285, 19);
            this.tbImagesToSort.Name = "tbImagesToSort";
            this.tbImagesToSort.Size = new System.Drawing.Size(1240, 31);
            this.tbImagesToSort.TabIndex = 7;
            this.tbImagesToSort.Text = "C:\\Data\\GoogleImages\\Rolling";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1741, 1321);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(3000, 3000);
            this.MinimumSize = new System.Drawing.Size(800, 650);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnResizeAll;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNotADog;
        private System.Windows.Forms.Button btnOther;
        private System.Windows.Forms.Button btnLaying;
        private System.Windows.Forms.Button btnStanding;
        private System.Windows.Forms.Button btnJumping;
        private System.Windows.Forms.Button btnRolling;
        private System.Windows.Forms.Button btnSitting;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbImagesDownloadPath;
        private System.Windows.Forms.Button btnDownloadGoogleImages;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox tbGoogleImagesUrl;
        private System.Windows.Forms.Button btnImagesDownloadPath;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox rtbUrlList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.Button btnSortedImages;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSortedImagesBasePath;
        private System.Windows.Forms.Button btnImagesToSort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbImagesToSort;
        private System.Windows.Forms.FolderBrowserDialog folderDialogSettings;
    }
}

