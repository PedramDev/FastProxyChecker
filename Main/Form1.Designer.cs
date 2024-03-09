namespace Main
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnStart = new Button();
            openFileDialog1 = new OpenFileDialog();
            button2 = new Button();
            rtx_bad = new RichTextBox();
            rtx_good = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            lblTotalProxyCount = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            lblRemains = new Label();
            btnStop = new Button();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Enabled = false;
            btnStart.Location = new Point(195, 16);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "OpenFile";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // rtx_bad
            // 
            rtx_bad.Location = new Point(12, 104);
            rtx_bad.Name = "rtx_bad";
            rtx_bad.Size = new Size(258, 244);
            rtx_bad.TabIndex = 2;
            rtx_bad.Text = "";
            // 
            // rtx_good
            // 
            rtx_good.Location = new Point(276, 104);
            rtx_good.Name = "rtx_good";
            rtx_good.Size = new Size(258, 244);
            rtx_good.TabIndex = 2;
            rtx_good.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 74);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 3;
            label1.Text = "Bad :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 74);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Good :";
            // 
            // lblTotalProxyCount
            // 
            lblTotalProxyCount.AutoSize = true;
            lblTotalProxyCount.Location = new Point(102, 16);
            lblTotalProxyCount.Name = "lblTotalProxyCount";
            lblTotalProxyCount.Size = new Size(51, 15);
            lblTotalProxyCount.TabIndex = 3;
            lblTotalProxyCount.Text = "Proxies :";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 45);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "Remains :";
            // 
            // lblRemains
            // 
            lblRemains.AutoSize = true;
            lblRemains.Location = new Point(166, 45);
            lblRemains.Name = "lblRemains";
            lblRemains.Size = new Size(13, 15);
            lblRemains.TabIndex = 4;
            lblRemains.Text = "0";
            // 
            // btnStop
            // 
            btnStop.Enabled = false;
            btnStop.Location = new Point(12, 41);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 23);
            btnStop.TabIndex = 5;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 358);
            Controls.Add(btnStop);
            Controls.Add(lblRemains);
            Controls.Add(label3);
            Controls.Add(lblTotalProxyCount);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtx_good);
            Controls.Add(rtx_bad);
            Controls.Add(button2);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private OpenFileDialog openFileDialog1;
        private Button button2;
        private RichTextBox rtx_bad;
        private RichTextBox rtx_good;
        private Label label1;
        private Label label2;
        private Label lblTotalProxyCount;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
        private Label lblRemains;
        private Button btnStop;
    }
}
