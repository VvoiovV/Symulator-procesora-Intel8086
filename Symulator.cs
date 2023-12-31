using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Symulator_Michał_Grzegorzewski
{
    public partial class Symulator : Form
    {

        private string x;
        private string y;


        public Symulator()
        { 
            InitializeComponent();
        }

        private void Symulator_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
            x = textBox1.Text;
            y = textBox2.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (comboBox1.SelectedIndex == comboBox2.SelectedIndex)
            {
                MessageBox.Show("Zły Rejestr");
            }


            if (comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = x;
            }

            if (comboBox2.SelectedIndex == 1)
            {
                textBox2.Text = x;
            }

            if (comboBox2.SelectedIndex == 2)
            {
                textBox3.Text = x;
            }

            if (comboBox2.SelectedIndex == 3)
            {
                textBox4.Text = x;
            }
            if (comboBox2.SelectedIndex == 4)
            {
                textBox5.Text = x;
            }
            if (comboBox2.SelectedIndex == 5)
            {
                textBox6.Text = x;
            }
            if (comboBox2.SelectedIndex == 6)
            {
                textBox7.Text = x;
            }
            if (comboBox2.SelectedIndex == 7)
            {
                textBox8.Text = x;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == comboBox2.SelectedIndex)
            {
                MessageBox.Show("Zły Rejestr");
            }

            if (comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = x;
            }

            if (comboBox2.SelectedIndex == 1)
            {
                textBox2.Text = x;
            }

            if (comboBox2.SelectedIndex == 2)
            {
                textBox3.Text = x;
            }

            if (comboBox2.SelectedIndex == 3)
            {
                textBox4.Text = x;
            }
            if (comboBox2.SelectedIndex == 4)
            {
                textBox5.Text = x;
            }
            if (comboBox2.SelectedIndex == 5)
            {
                textBox6.Text = x;
            }
            if (comboBox2.SelectedIndex == 6)
            {
                textBox7.Text = x;
            }
            if (comboBox2.SelectedIndex == 7)
            {
                textBox8.Text = x;
            }


            if (comboBox1.SelectedIndex == 0)
            {
                textBox1.Text = y;
            }

            if (comboBox1.SelectedIndex == 1)
            {
                textBox2.Text = y;
            }

            if (comboBox1.SelectedIndex == 2)
            {
                textBox3.Text = y;
            }

            if (comboBox1.SelectedIndex == 3)
            {
                textBox4.Text = y;
            }
            if (comboBox1.SelectedIndex == 4)
            {
                textBox5.Text = y;
            }
            if (comboBox1.SelectedIndex == 5)
            {
                textBox6.Text = y;
            }
            if (comboBox1.SelectedIndex == 6)
            {
                textBox7.Text = y;
            }
            if (comboBox1.SelectedIndex == 7)
            {
                textBox8.Text = y;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
            textBox1.Text = "1111";
            textBox2.Text = "2222";
            textBox3.Text = "3333";
            textBox4.Text = "4444";
            textBox5.Text = "1111";
            textBox6.Text = "1111";
            textBox7.Text = "1111";
            textBox8.Text = "1111";
            x = "";
            y = "";
        }
    

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                x = textBox1.Text.ToString();
            }

            if (comboBox1.SelectedIndex == 1)
            {
                x = textBox2.Text.ToString();
            }

            if (comboBox1.SelectedIndex == 2)
            {
                x = textBox3.Text.ToString();
            }

            if (comboBox1.SelectedIndex == 3)
            {
                x = textBox4.Text.ToString();
            }
            if (comboBox1.SelectedIndex == 4)
            {
                x = textBox5.Text.ToString();
            }
            if (comboBox1.SelectedIndex == 5)
            {
                x = textBox6.Text.ToString();
            }
            if (comboBox1.SelectedIndex == 6)
            {
                x = textBox7.Text.ToString();
            }
            if (comboBox1.SelectedIndex == 7)
            {
                x = textBox8.Text.ToString();
            }
        }
    

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                y = textBox1.Text.ToString();
            }

            if (comboBox2.SelectedIndex == 1)
            {
                y = textBox2.Text.ToString();
            }

            if (comboBox2.SelectedIndex == 2)
            {
                y = textBox3.Text.ToString();
            }

            if (comboBox2.SelectedIndex == 3)
            {
                y = textBox4.Text.ToString();
            }
            if (comboBox2.SelectedIndex == 4)
            {
                y = textBox5.Text.ToString();
            }
            if (comboBox2.SelectedIndex == 5)
            {
                y = textBox6.Text.ToString();
            }
            if (comboBox2.SelectedIndex == 6)
            {
                y = textBox7.Text.ToString();
            }
            if (comboBox2.SelectedIndex == 7)
            {
                y = textBox8.Text.ToString();
            }
        }
    

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
