using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace romdon
{
    public partial class settings : Form
    {
        public string fliepath;

        public settings()
        {
            InitializeComponent();
            label1_Click(null, null);
            label2_Click(null, null);
            label3_Click(null, null);
            label4_Click(null, null);
            label5_Click(null, null);
            label6_Click(null, null);
            LoadPathsFromPort();
        }

        private void LoadPathsFromPort()
        {
            string configDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config");

            string studentPort = Path.Combine(configDir, "path_studentlist.flieport");
            string weightPort = Path.Combine(configDir, "path_weightlist.flieport");

            if (File.Exists(studentPort))
                textBox1.Text = File.ReadAllText(studentPort, Encoding.UTF8).Trim();

            if (File.Exists(weightPort))
                textBox2.Text = File.ReadAllText(weightPort, Encoding.UTF8).Trim();
        }

        private static char[] InitializeCharArray(char[] array)
        {
            int length = array.Length;
            char[] out_array = new char[length];
            return out_array;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "学生列表文件路径";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label2.ForeColor = Color.Red;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = "学生权重文件路径";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            label5.ForeColor = Color.Red;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void Textbox1_Change(object sender, EventArgs e)
        {
            string tempNameList = textBox1.Text;
            if (File.Exists(tempNameList))
            {
                fliepath = tempNameList;
                returnpath_studentlist(fliepath);
                label2.Visible = false;
            }
            else
            {
                label2.Text = "文件不存在";
                label2.Visible = true;
            }
        }

        private void Textbox2_Change(object sender, EventArgs e)
        {
            string tempPath = textBox2.Text;
            if (File.Exists(tempPath))
            {
                fliepath = tempPath;
                returnpath_weightlist(fliepath);
                label5.Visible = false;
            }
            else
            {
                label5.Text = "文件不存在";
                label5.Visible = true;
            }
        }

        public void returnpath_studentlist(string temppath)
        {
            string filePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "config",
                "path_studentlist.flieport"
            );

            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));

                using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
                {
                    writer.WriteLine(temppath);
                }

                label3.Visible = true;
                label3.ForeColor = Color.Green;
                label3.Text = "success in writing port";
                Console.WriteLine("success in writing port: " + filePath);
            }
            catch (Exception ex)
            {
                label3.Visible = true;
                label3.ForeColor = Color.Red;
                label3.Text = "failed to write port: " + ex.Message;
                Console.WriteLine("failed in writing port: " + ex.Message);
            }
        }

        public void returnpath_weightlist(string temppath)
        {
            string filePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "config",
                "path_weightlist.flieport"
            );

            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));

                using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
                {
                    writer.WriteLine(temppath);
                }

                label6.Visible = true;
                label6.ForeColor = Color.Green;
                label6.Text = "success in writing port";
                Console.WriteLine("success in writing port: " + filePath);
            }
            catch (Exception ex)
            {
                label6.Visible = true;
                label6.ForeColor = Color.Red;
                label6.Text = "failed to write port: " + ex.Message;
                Console.WriteLine("failed in writing port: " + ex.Message);
            }
        }

        public void botton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void botton2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
                Textbox1_Change(null, null);
            if (!string.IsNullOrWhiteSpace(textBox2.Text))
                Textbox2_Change(null, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "文本文件|*.txt|所有文件|*.*";
                ofd.Title = "选择学生列表文件";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = ofd.FileName;
                    // TextChanged
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "文本文件|*.txt|所有文件|*.*";
                ofd.Title = "选择权重文件";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBox2.Text = ofd.FileName;
                    // TextChanged
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "文本文件|*.txt|所有文件|*.*";
                sfd.Title = "创建学生列表文件";
                sfd.FileName = "studentlist.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, "", Encoding.UTF8);
                    textBox1.Text = sfd.FileName;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "文本文件|*.txt|所有文件|*.*";
                sfd.Title = "创建权重文件";
                sfd.FileName = "weightlist.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, "", Encoding.UTF8);
                    textBox2.Text = sfd.FileName;
                }
            }
        }
    }
}