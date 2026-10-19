using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b, s = 0;

                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);

                char c = textBox3.Text[0];

                switch (c)
                {
                    case '+':
                        s = a + b;
                        break;

                    case '-':
                        s = a - b;
                        break;

                    case '*':
                        s = a * b;
                        break;

                    case '/':
                        if (b == 0)
                        {
                            MessageBox.Show("Ділення на нуль неможливе!");
                            return;
                        }
                        s = a / b;
                        break;

                    default:
                        MessageBox.Show("Невірний знак операції!");
                        return;
                }

                textBox4.Text = s.ToString();
            }
            catch
            {
                MessageBox.Show("Помилка введення даних!");
            }
        }
    }
}
