using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            string[] tokens = input.Split(',');
            if (tokens.Length < 2)
            {
                MessageBox.Show("Đã nhập sai định dạng!");
                return;
            }
            
            string studentName = tokens[0];

            // Chuyển đổi các phần tử còn lại thành điểm số
            double[] grades = new double[tokens.Length - 1];
            for (int i = 1; i < tokens.Length; i++)
            {
                if (!double.TryParse(tokens[i].Trim(), out grades[i - 1]))
                {
                    MessageBox.Show("Đã nhập sai định dạng!");
                    return;
                }
            }

            // Xuất ra danh sách điểm kèm tiêu đề Môn
            string subjectScores = "";
            for (int i = 0; i < grades.Length; i++)
            {
                subjectScores += $"Môn {i + 1}:{grades[i]}; ";
            }


            // Tính điểm trung bình
            double averageGrade = grades.Average();


            // Tìm môn điểm cao nhất và thấp nhất
            double maxGrade = grades.Max();
            double minGrade = grades.Min();

            textBox2.Text = "Họ và tên:" + studentName.ToString() + Environment.NewLine + subjectScores.ToString() + Environment.NewLine
          + "Điểm trung bình:" + averageGrade.ToString() + Environment.NewLine + "Điểm cao nhất:" + maxGrade.ToString() + Environment.NewLine
          + "Điểm thấp nhất:" + minGrade.ToString();

            // Tìm số môn đậu và không đậu
            int passedCount = grades.Count(grade => grade >= 5);
            int failedCount = grades.Count(grade => grade < 5);
            textBox3.Text = "Số môn đậu:" + passedCount.ToString() + Environment.NewLine + "Số môn không đậu:" + failedCount.ToString();
            
            // Xếp loại sinh viên
            string classification = "";
            if (averageGrade >= 8 && grades.All(grade => grade >= 6.5))
            {
                classification = "Giỏi";
            }
            else if (averageGrade >= 6.5 && grades.All(grade => grade >= 5))
            {
                classification = "Khá";
            }
            else if (averageGrade >= 5 && grades.All(grade => grade >= 3.5))
            {
                classification = "Trung bình";
            }
            else
            {
                classification = "Yếu";
            }
            textBox4.Text = $"Xếp loại: {classification}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
