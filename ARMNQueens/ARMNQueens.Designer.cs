namespace ARMNQueens
{
    partial class ARMNQueens
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ARMNQueens));
            this.num_NumberOfQueens = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_AttemptShow = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_GetAll = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.num_Delay = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btn_About = new System.Windows.Forms.Button();
            this.btn_StopThread = new System.Windows.Forms.Button();
            this.btn_Statistics = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_NumberOfQueens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Delay)).BeginInit();
            this.SuspendLayout();
            // 
            // num_NumberOfQueens
            // 
            this.num_NumberOfQueens.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.num_NumberOfQueens.Location = new System.Drawing.Point(293, 17);
            this.num_NumberOfQueens.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.num_NumberOfQueens.Name = "num_NumberOfQueens";
            this.num_NumberOfQueens.Size = new System.Drawing.Size(120, 20);
            this.num_NumberOfQueens.TabIndex = 0;
            this.num_NumberOfQueens.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.num_NumberOfQueens.ValueChanged += new System.EventHandler(this.num_NumberOfQueens_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Queens:";
            // 
            // btn_Start
            // 
            this.btn_Start.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Start.Location = new System.Drawing.Point(253, 449);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(89, 45);
            this.btn_Start.TabIndex = 3;
            this.btn_Start.Text = "Go for it !";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(113, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Reset.Location = new System.Drawing.Point(154, 460);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 4;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_AttemptShow
            // 
            this.btn_AttemptShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_AttemptShow.Location = new System.Drawing.Point(516, 62);
            this.btn_AttemptShow.Name = "btn_AttemptShow";
            this.btn_AttemptShow.Size = new System.Drawing.Size(91, 23);
            this.btn_AttemptShow.TabIndex = 5;
            this.btn_AttemptShow.Text = "Attempt Show!";
            this.btn_AttemptShow.UseVisualStyleBackColor = true;
            this.btn_AttemptShow.Click += new System.EventHandler(this.btn_AttemptShow_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Stop.Location = new System.Drawing.Point(516, 131);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(91, 23);
            this.btn_Stop.TabIndex = 6;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_GetAll
            // 
            this.btn_GetAll.Location = new System.Drawing.Point(12, 43);
            this.btn_GetAll.Name = "btn_GetAll";
            this.btn_GetAll.Size = new System.Drawing.Size(95, 23);
            this.btn_GetAll.TabIndex = 7;
            this.btn_GetAll.Text = "Get All Possible";
            this.btn_GetAll.UseVisualStyleBackColor = true;
            this.btn_GetAll.Click += new System.EventHandler(this.btn_GetAll_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(33, 72);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 371);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // num_Delay
            // 
            this.num_Delay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.num_Delay.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.num_Delay.Location = new System.Drawing.Point(516, 105);
            this.num_Delay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_Delay.Name = "num_Delay";
            this.num_Delay.Size = new System.Drawing.Size(91, 20);
            this.num_Delay.TabIndex = 9;
            this.num_Delay.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.num_Delay.ValueChanged += new System.EventHandler(this.num_Delay_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Delay (ms):";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Refresh.Location = new System.Drawing.Point(522, 160);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 11;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 5000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "queen1.png");
            this.imageList1.Images.SetKeyName(1, "queen2.png");
            this.imageList1.Images.SetKeyName(2, "queen3.png");
            this.imageList1.Images.SetKeyName(3, "Knight.png");
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.listView1.LargeImageList = this.imageList2;
            this.listView1.Location = new System.Drawing.Point(521, 189);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(86, 305);
            this.listView1.SmallImageList = this.imageList2;
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "queen1.png");
            this.imageList2.Images.SetKeyName(1, "queen2.png");
            this.imageList2.Images.SetKeyName(2, "queen3.png");
            this.imageList2.Images.SetKeyName(3, "Knight.png");
            // 
            // btn_About
            // 
            this.btn_About.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_About.Location = new System.Drawing.Point(438, 464);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(75, 23);
            this.btn_About.TabIndex = 13;
            this.btn_About.Text = "About";
            this.btn_About.UseVisualStyleBackColor = true;
            this.btn_About.Click += new System.EventHandler(this.btn_About_Click);
            // 
            // btn_StopThread
            // 
            this.btn_StopThread.Location = new System.Drawing.Point(12, 449);
            this.btn_StopThread.Name = "btn_StopThread";
            this.btn_StopThread.Size = new System.Drawing.Size(91, 23);
            this.btn_StopThread.TabIndex = 14;
            this.btn_StopThread.Text = "Stop";
            this.btn_StopThread.UseVisualStyleBackColor = true;
            this.btn_StopThread.Click += new System.EventHandler(this.btn_StopThread_Click);
            // 
            // btn_Statistics
            // 
            this.btn_Statistics.Location = new System.Drawing.Point(12, 475);
            this.btn_Statistics.Name = "btn_Statistics";
            this.btn_Statistics.Size = new System.Drawing.Size(91, 23);
            this.btn_Statistics.TabIndex = 15;
            this.btn_Statistics.Text = "Statistics";
            this.btn_Statistics.UseVisualStyleBackColor = true;
            this.btn_Statistics.Click += new System.EventHandler(this.btn_Statistics_Click);
            // 
            // ARMNQueens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(610, 499);
            this.Controls.Add(this.btn_Statistics);
            this.Controls.Add(this.btn_StopThread);
            this.Controls.Add(this.btn_About);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num_Delay);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btn_GetAll);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_AttemptShow);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_NumberOfQueens);
            this.Name = "ARMNQueens";
            this.Text = "ARM N Queens";
            this.Load += new System.EventHandler(this.ARMNQueens_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ARMNQueens_Paint);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ARMNQueens_FormClosing);
            this.Resize += new System.EventHandler(this.ARMNQueens_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.num_NumberOfQueens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Delay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown num_NumberOfQueens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_AttemptShow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_GetAll;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.NumericUpDown num_Delay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button btn_About;
        private System.Windows.Forms.Button btn_StopThread;
        private System.Windows.Forms.Button btn_Statistics;
    }
}

