using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1
{
    public partial class Bai2 : Form
    {
       

        
        public Bai2()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            if (double.TryParse(textBox1.Text, out double num1) &&
                double.TryParse(textBox2.Text, out double num2) &&
                double.TryParse(textBox3.Text, out double num3))
            {

                double maxNumber = Math.Max(Math.Max(num1, num2), num3);
                double minNumber = Math.Min(Math.Min(num1, num2), num3);

                textBox4.Text = maxNumber.ToString();
                textBox5.Text = minNumber.ToString();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();


        }

        private void button3_Click(object sender, EventArgs e)
        {
           
                Application.Exit();
        }

        
    }
}
