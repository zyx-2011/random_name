using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace romdon
{
    public partial class ChanceOfDrawing : Form
    {
        private string studentPath = "";
        private string weightPath = "";

        public ChanceOfDrawing()
        {
            InitializeComponent();
            Load += ChanceOfDrawing_Load;
        }

        private void ChanceOfDrawing_Load(object sender, EventArgs e)
        {
            string configDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config");

            string studentPort = Path.Combine(configDir, "path_studentlist.flieport");
            string weightPort = Path.Combine(configDir, "path_weightlist.flieport");

            if (File.Exists(studentPort))
                studentPath = File.ReadAllText(studentPort, Encoding.UTF8).Trim();

            if (File.Exists(weightPort))
                weightPath = File.ReadAllText(weightPort, Encoding.UTF8).Trim();

            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Name", "姓名");
            dataGridView1.Columns.Add("Weight", "权重");

            if (string.IsNullOrEmpty(studentPath) || !File.Exists(studentPath))
            {
                MessageBox.Show("找不到学生列表文件，请先在设置中指定");
                return;
            }

            string[] names = File.ReadAllLines(studentPath, Encoding.UTF8);
            string[] weights = (!string.IsNullOrEmpty(weightPath) && File.Exists(weightPath))
                ? File.ReadAllLines(weightPath, Encoding.UTF8)
                : new string[0];

            for (int i = 0; i < names.Length; i++)
            {
                string w = i < weights.Length ? weights[i] : "1";
                int n;
                if (!int.TryParse(w, out n) || n < 1)
                    n = 1;

                dataGridView1.Rows.Add(names[i], n.ToString());
            }
        }

        private void SaveData()
        {
            try
            {
                if (string.IsNullOrEmpty(studentPath))
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "未指定学生列表路径";
                    return;
                }

                string weightDir = Path.GetDirectoryName(weightPath);
                if (!string.IsNullOrEmpty(weightDir))
                    Directory.CreateDirectory(weightDir);

                using (StreamWriter nameSw = new StreamWriter(studentPath, false, Encoding.UTF8))
                using (StreamWriter weightSw = new StreamWriter(weightPath, false, Encoding.UTF8))
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string name = row.Cells["Name"].Value?.ToString() ?? "";
                        string w = row.Cells["Weight"].Value?.ToString() ?? "1";

                        int n;
                        if (!int.TryParse(w, out n) || n < 1)
                        {
                            n = 1;
                            row.Cells["Weight"].Value = "1";
                        }

                        nameSw.WriteLine(name);
                        weightSw.WriteLine(n);
                    }
                }

                label1.ForeColor = Color.Green;
                label1.Text = "保存成功";
            }
            catch (Exception ex)
            {
                label1.ForeColor = Color.Red;
                label1.Text = "保存失败：" + ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.AutoSize = false;
            label1.Size = new System.Drawing.Size(200, 50);
            label1.Font = new Font("楷体", 12, FontStyle.Bold);
        }
    }
}