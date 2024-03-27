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
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                int a, b;
                a = Int32.Parse(textBox1.Text.Trim());
                b = Int32.Parse(textBox2.Text.Trim());
                int c = b - a;
                for (int i = 1; i <= 10; i++)
                {
                    int d = c * i;
                    textBox4.Text += c.ToString() + " * " +i.ToString() + " = " + d.ToString() + Environment.NewLine;
                    //textBox4.Text = string.Concat(b.ToString()," - ",a.ToString()," = ",c.ToString());
                }
                
            }
            if (comboBox1.SelectedIndex == 1)
            {
                int a, b;
                a = Int32.Parse(textBox1.Text.Trim());
                b = Int32.Parse(textBox2.Text.Trim());
                double S = Math.Pow(a, b + 1) - a;
                S /= (a - 1);
                int f = Math.Abs(b - a);
                textBox4.Text ="(A - B)! = " + f.ToString() + Environment.NewLine +"S = " + S.ToString();

            }
        }

        private int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
    }

