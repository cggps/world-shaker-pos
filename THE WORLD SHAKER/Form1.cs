using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THE_WORLD_SHAKER
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        textBox1.Text="0";
        textBox2.Text = "0";
        textBox3.Text = "0";
        textBox4.Text = "0";
        textBox5.Text = "0";
        textBox6.Text = "0";
        textBox7.Text = "0";
        textBox8.Text = "0";

   
            double a,b;

            if (checkBox1.Checked)
            {
                a = Convert.ToDouble(textBox1.Text);
                b = a * 60;
                textBox7.Text = Convert.ToString(b);
            }
            else if (checkBox2.Checked)
            {
                a = Convert.ToDouble(textBox2.Text);
                b = a *60;
                textBox7.Text = Convert.ToString(b);
            }
            else if (checkBox3.Checked)
            {
                a = Convert.ToDouble(textBox3.Text);
                b = a * 60;
                textBox7.Text = Convert.ToString(b);
            }
            else if (checkBox4.Checked)
            {
                a = Convert.ToDouble(textBox4.Text);
                b = a * 60;
                textBox7.Text = Convert.ToString(b);
            }
            else if (checkBox5.Checked)
            {
                a = Convert.ToDouble(textBox5.Text);
                b = a * 60;
                textBox7.Text = Convert.ToString(b);
            }
            else if (checkBox6.Checked)
            {
                a = Convert.ToDouble(textBox6.Text);
                b = a *60;
                textBox7.Text = Convert.ToString(b);
            }
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a,a1, b,b1, c,c1, d,d1, z,z1, f,f1, y;
            a = Convert.ToDouble(textBox1.Text);
            a1 = a * 60;
            b = Convert.ToDouble(textBox2.Text);
            b1 =b * 50;
            c = Convert.ToDouble(textBox3.Text);
            c1 =c* 55;
            d= Convert.ToDouble(textBox4.Text);
            d1 = d * 45;
            z= Convert.ToDouble(textBox5.Text);
            z1 = z * 40;
            f = Convert.ToDouble(textBox6.Text);
            f1 = f * 70;

            y = a1 + b1 + c1 + d1 + z1 + f1;
            textBox8.Text = Convert.ToString(y);
            textBox10.Text = Convert.ToString(y);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int z, a, b;

            z = Convert.ToInt32(textBox7.Text);
            a = Convert.ToInt32(textBox8.Text);
            b = (z - a);
            if (a < z)
            {
                MessageBox.Show("Your change is: " + b);
            }
            else if (a > z)
            {
                MessageBox.Show("YOUR MONEY IS NOT ENOUGH!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a, b;

            a = Convert.ToDouble(textBox10.Text);
            b = (a + (a * 0.1));
            textBox11.Text = Convert.ToString(b);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
