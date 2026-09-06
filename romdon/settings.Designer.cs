namespace romdon
{
    partial class settings
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(147, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(490, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 31);
            label1.Name = "label1";
            label1.Size = new Size(43, 17);
            label1.TabIndex = 1;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 48);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // button1
            // 
            button1.Location = new Point(697, 408);
            button1.Name = "button1";
            button1.Size = new Size(91, 30);
            button1.TabIndex = 3;
            button1.Text = "确定";
            button1.UseVisualStyleBackColor = true;
            button1.Click += botton1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(600, 408);
            button2.Name = "button2";
            button2.Size = new Size(91, 30);
            button2.TabIndex = 4;
            button2.Text = "应用";
            button2.UseVisualStyleBackColor = true;
            button2.Click += botton2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 63);
            label3.Name = "label3";
            label3.Size = new Size(43, 17);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 117);
            label4.Name = "label4";
            label4.Size = new Size(43, 17);
            label4.TabIndex = 6;
            label4.Text = "label4";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(147, 117);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(490, 23);
            textBox2.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(147, 143);
            label5.Name = "label5";
            label5.Size = new Size(43, 17);
            label5.TabIndex = 8;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 158);
            label6.Name = "label6";
            label6.Size = new Size(43, 17);
            label6.TabIndex = 9;
            label6.Text = "label6";
            // 
            // button3
            // 
            button3.Location = new Point(643, 24);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = "选取文件";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(643, 117);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 11;
            button4.Text = "选取文件";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(643, 53);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 12;
            button5.Text = "创建文件";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(643, 146);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 13;
            button6.Text = "创建文件";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // settings
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "settings";
            Text = "设置";
            Click += botton2_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}