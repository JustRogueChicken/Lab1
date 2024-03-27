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
    public partial class Bai3_1 : Form
    {
        public Bai3_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string number = textBox1.Text.Trim();
            if (number.Length != 12 || !number.All(char.IsDigit))
            {
                MessageBox.Show("Vui lòng nhập số có 12 chữ số.");
                return;
            }

            string[] units = { "", "nghìn,", "triệu,", "tỷ," };
            string[] digits = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string result = "";

            for (int i = 0; i < 4; i++)
            {
                string block = number.Substring(number.Length - (i + 1) * 3, 3);
                int num = int.Parse(block);

                if (num != 0)
                {
                    string blockResult = "";

                    int hundreds = num / 100;
                    if (hundreds > 0)
                        blockResult += digits[hundreds] + " trăm ";

                    int tens = (num % 100) / 10;
                    if (tens > 1)
                    {
                        blockResult += digits[tens] + " mươi ";
                        int ones = num % 10;
                        if (ones > 0)
                            blockResult += digits[ones];
                    }
                    else if (tens == 1)
                    {
                        blockResult += "mười ";
                        int ones = num % 10;
                        if (ones > 0)
                            blockResult += digits[ones];
                    }
                    else
                    {
                        int ones = num % 10;
                        if (ones > 0)
                            blockResult += "lẻ " + digits[ones];
                    }

                    result = blockResult + " " + units[i] + " " + result;
                }
            }

            textBox2.Text = result.Trim();
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
