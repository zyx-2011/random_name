namespace romdon
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
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            checkBox1 = new CheckBox();
            label2 = new Label();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(43, 307);
            button1.Name = "button1";
            button1.Size = new Size(104, 43);
            button1.TabIndex = 0;
            button1.Text = "开始抽问";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 83);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 1;
            label1.Text = "未抽取";
            label1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(153, 307);
            button2.Name = "button2";
            button2.Size = new Size(104, 41);
            button2.TabIndex = 2;
            button2.Text = "设置";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(43, 356);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(99, 21);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "使用权重抽取";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(12, 424);
            label2.Name = "label2";
            label2.Size = new Size(128, 17);
            label2.TabIndex = 4;
            label2.Text = "错误信息：未发现错误";
            // 
            // button3
            // 
            button3.Location = new Point(153, 354);
            button3.Name = "button3";
            button3.Size = new Size(104, 40);
            button3.TabIndex = 5;
            button3.Text = "权重调整";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(263, 307);
            button4.Name = "button4";
            button4.Size = new Size(104, 41);
            button4.TabIndex = 6;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "随机抽问";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private CheckBox checkBox1;
        private Label label2;
        private Button button3;
        private Button button4;
    }
}
