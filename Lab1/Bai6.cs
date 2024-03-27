using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dateString = textBox1.Text.Trim();
            if (DateTime.TryParseExact(dateString, "dd/MM", null, System.Globalization.DateTimeStyles.None, out DateTime date))
            {
                string zodiacSign = GetZodiacSign(date);
                textBox2.Text = zodiacSign;
            }
            else
            {
                MessageBox.Show("Ngày tháng không hợp lệ. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetZodiacSign(DateTime birthDate)
        {
            int day = birthDate.Day;
            int month = birthDate.Month;

            switch (month)
            {
                case 3:
                    if (day >= 21)
                        return "Bạch Dương";
                    else
                        return "Song Ngư";
                case 4:
                    if (day <= 20)
                        return "Bạch Dương";
                    else
                        return "Kim Ngưu";
                case 5:
                    if (day <= 21)
                        return "Kim Ngưu";
                    else
                        return "Song Tử";
                case 6:
                    if (day <= 21)
                        return "Song Tử";
                    else
                        return "Cự Giải";
                case 7:
                    if (day <= 22)
                        return "Cự Giải";
                    else
                        return "Sư Tử";
                case 8:
                    if (day <= 22)
                        return "Sư Tử";
                    else
                        return "Xử Nữ";
                case 9:
                    if (day <= 23)
                        return "Xử Nữ";
                    else
                        return "Thiên Bình";
                case 10:
                    if (day <= 23)
                        return "Thiên Bình";
                    else
                        return "Thần Nông";
                case 11:
                    if (day <= 22)
                        return "Thần Nông";
                    else
                        return "Nhân Mã";
                case 12:
                    if (day <= 21)
                        return "Nhân Mã";
                    else
                        return "Ma Kết";
                case 1:
                    if (day <= 20)
                        return "Ma Kết";
                    else
                        return "Bảo Bình";
                case 2:
                    if (day <= 19)
                        return "Bảo Bình";
                    else
                        return "Song Ngư";
                default:
                    return "Không xác định";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}