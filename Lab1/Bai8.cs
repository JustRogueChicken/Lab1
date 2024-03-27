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
    public partial class Bai8 : Form
    {
        public Bai8()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string newFood = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(newFood))
            {
                textBox3.Text += newFood.ToString()+Environment.NewLine;
                textBox1.Clear();
                
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string[] foodList = textBox3.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            if (foodList.Length > 0)
            {
                Random random = new Random();
                int index = random.Next(0, foodList.Length);
                string chosenFood = foodList[index];
                textBox2.Text = chosenFood;
            }
            else
            {
                MessageBox.Show("Danh sách món ăn trống. Vui lòng thêm món ăn trước.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
    }

