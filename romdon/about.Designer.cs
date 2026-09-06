namespace romdon
{
    partial class about
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F);
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(157, 21);
            label1.TabIndex = 0;
            label1.Text = "版本：Release-1.0.0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 18F);
            label2.Location = new Point(106, 9);
            label2.Name = "label2";
            label2.Size = new Size(110, 31);
            label2.TabIndex = 1;
            label2.Text = "抽问程序";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 12F);
            label3.Location = new Point(12, 78);
            label3.Name = "label3";
            label3.Size = new Size(108, 21);
            label3.TabIndex = 2;
            label3.Text = "github地址：";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Microsoft YaHei UI", 12F);
            linkLabel1.Location = new Point(12, 99);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(392, 21);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://github.com/zyx-2011/-/tree/main/romdon";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.Location = new Point(340, 407);
            button1.Name = "button1";
            button1.Size = new Size(88, 31);
            button1.TabIndex = 4;
            button1.Text = "确定";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // about
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 450);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "about";
            Text = "关于";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private LinkLabel linkLabel1;
        private Button button1;
    }
}