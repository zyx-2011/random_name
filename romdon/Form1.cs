using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json.Serialization;

namespace romdon
{
    public struct student
    {
        public string name;
        public int weight;
    }

    public partial class Form1 : Form
    {
        private void flieinit()
        {
            string configDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config");
            Directory.CreateDirectory(configDir);

            string studentPort = Path.Combine(configDir, "path_studentlist.flieport");
            string weightPort = Path.Combine(configDir, "path_weightlist.flieport");

            if (!File.Exists(studentPort)) File.WriteAllText(studentPort, "");
            if (!File.Exists(weightPort)) File.WriteAllText(weightPort, "");
        }
        public Form1()
        {
            InitializeComponent();
            flieinit();
            button4.Text = "关于";
            //button1_Click(null, null);
            label2_click(null, null);
            student[] students;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1_Click(null, null);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            settings settings_window = new settings();
            settings_window.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ChanceOfDrawing ChanceOfDrawing_window = new ChanceOfDrawing();
            ChanceOfDrawing_window.ShowDialog();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            label1.AutoSize = false;
            label1.Size = new System.Drawing.Size(200, 50);
            label1.Font = new Font("宋体", 20, FontStyle.Bold);
            string name = Random_name();
            if (name == null)
            {
                label1.Text = "未抽取";
            }
            else
            {
                label1.Text = name;
            }
        }
        private void label2_click(object sender, EventArgs e)
        {
            label2.Text = "错误信息：未发现错误";
        }
        private string[] Read_namelist()
        {
            string portFile = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "config",
                "path_studentlist.flieport"
            );

            if (!File.Exists(portFile))
            {
                MessageBox.Show("port 文件不存在:\n" + portFile);
                label2.Text = "错误：port 文件不存在";
                return null;
            }

            string studentFilePath = File.ReadAllText(portFile, Encoding.UTF8).Trim();

            if (string.IsNullOrWhiteSpace(studentFilePath) || !File.Exists(studentFilePath))
            {
                label2.Text = "学生列表文件不存在:\n" + studentFilePath + "\n\nport 文件在:\n" + portFile + "";
                return null;
            }

            return File.ReadAllLines(studentFilePath, Encoding.UTF8);
        }

        private string Random_name()
        {
            try
            {
                student[] students = get_students();

                if (students == null || students.Length == 0)
                {
                    label2.Text = "错误：学生列表为空";
                    return null;
                }

                Random rand = new Random();
                if (!checkBox1.Checked)
                {
                    int num = rand.Next(students.Length);
                    return students[num].name;
                }
                int totalWeight = 0;
                for (int i = 0; i < students.Length; i++)
                {
                    totalWeight += students[i].weight > 0 ? students[i].weight : 1;
                }

                int roll = rand.Next(totalWeight);
                int current = 0;
                for (int i = 0; i < students.Length; i++)
                {
                    current += students[i].weight > 0 ? students[i].weight : 1;
                    if (roll < current)
                    {
                        return students[i].name;
                    }
                }

                return students[students.Length - 1].name;
            }
            catch (Exception ex)
            {
                label2.Text = "错误：" + ex.Message + "";
                return null;
            }
        }
        private int[] Read_weightlist()
        {
            string portFile = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "config",
                "path_weightlist.flieport"
            );

            if (!File.Exists(portFile))
            {
                label2.Text = "错误：port_weight 文件不存在";
                return null;
            }

            string weightFilePath = File.ReadAllText(portFile, Encoding.UTF8).Trim();

            if (string.IsNullOrWhiteSpace(weightFilePath) || !File.Exists(weightFilePath))
            {
                label2.Text = "错误：权重文件不存在";
                return null;
            }

            string[] lines = File.ReadAllLines(weightFilePath, Encoding.UTF8);
            int[] weights = new int[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                int.TryParse(lines[i].Trim(), out weights[i]);
            }
            return weights;
        }
        private student[] get_students()
        {
            string[] tempnamelist = Read_namelist();
            int[] tempweightlist = Read_weightlist();

            if (tempnamelist == null || tempnamelist.Length == 0)
                return null;

            int count = tempnamelist.Length;
            student[] students = new student[count];
            for (int i = 0; i < count; i++)
            {
                students[i].name = tempnamelist[i];
                students[i].weight = 1;
            }
            if (checkBox1.Checked && tempweightlist != null)
            {
                int weightCount = Math.Min(count, tempweightlist.Length);
                for (int i = 0; i < weightCount; i++)
                {
                    students[i].weight = tempweightlist[i];
                }
            }

            return students;
        }
        public void checkbox_Click(object sender, EventArgs e)
        {
            ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            about about_window = new about();
            about_window.ShowDialog();
        }
    }
}
