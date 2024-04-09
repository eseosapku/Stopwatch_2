namespace Stopwatch
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
            hour = new Label();
            Start = new Button();
            label1 = new Label();
            minute = new Label();
            label3 = new Label();
            seconds = new Label();
            pause = new Button();
            reset = new Button();
            resume = new Button();
            button1stop = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // hour
            // 
            hour.AutoSize = true;
            hour.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            hour.Location = new Point(113, 101);
            hour.Name = "hour";
            hour.Size = new Size(67, 54);
            hour.TabIndex = 0;
            hour.Text = "00";
            // 
            // Start
            // 
            Start.Location = new Point(12, 221);
            Start.Name = "Start";
            Start.Size = new Size(75, 23);
            Start.TabIndex = 1;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(177, 101);
            label1.Name = "label1";
            label1.Size = new Size(32, 54);
            label1.TabIndex = 2;
            label1.Text = ":";
            label1.Click += label1_Click;
            // 
            // minute
            // 
            minute.AutoSize = true;
            minute.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            minute.Location = new Point(195, 101);
            minute.Name = "minute";
            minute.Size = new Size(78, 54);
            minute.TabIndex = 3;
            minute.Text = " 00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(263, 101);
            label3.Name = "label3";
            label3.Size = new Size(32, 54);
            label3.TabIndex = 4;
            label3.Text = ".";
            // 
            // seconds
            // 
            seconds.AutoSize = true;
            seconds.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            seconds.Location = new Point(279, 118);
            seconds.Name = "seconds";
            seconds.Size = new Size(40, 32);
            seconds.TabIndex = 5;
            seconds.Text = "00";
            // 
            // pause
            // 
            pause.Location = new Point(93, 221);
            pause.Name = "pause";
            pause.Size = new Size(75, 23);
            pause.TabIndex = 6;
            pause.Text = "Pause";
            pause.UseVisualStyleBackColor = true;
            pause.Click += pause_Click;
            // 
            // reset
            // 
            reset.Location = new Point(255, 221);
            reset.Name = "reset";
            reset.Size = new Size(75, 23);
            reset.TabIndex = 7;
            reset.Text = "Reset";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // resume
            // 
            resume.Location = new Point(174, 221);
            resume.Name = "resume";
            resume.Size = new Size(75, 23);
            resume.TabIndex = 8;
            resume.Text = "Resume";
            resume.UseVisualStyleBackColor = true;
            resume.Click += button1_Click;
            // 
            // button1stop
            // 
            button1stop.Location = new Point(336, 221);
            button1stop.Name = "button1stop";
            button1stop.Size = new Size(75, 23);
            button1stop.TabIndex = 9;
            button1stop.Text = "Stop";
            button1stop.UseVisualStyleBackColor = true;
            button1stop.Click += button1stop_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 324);
            Controls.Add(button1stop);
            Controls.Add(resume);
            Controls.Add(reset);
            Controls.Add(pause);
            Controls.Add(seconds);
            Controls.Add(label3);
            Controls.Add(minute);
            Controls.Add(label1);
            Controls.Add(Start);
            Controls.Add(hour);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label hour;
        private Button Start;
        private Label label1;
        private Label minute;
        private Label label3;
        private Label seconds;
        private Button pause;
        private Button reset;
        private Button resume;
        private Button button1stop;
        private System.Windows.Forms.Timer timer1;
    }
}