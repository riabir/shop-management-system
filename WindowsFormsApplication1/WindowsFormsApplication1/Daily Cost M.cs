using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Daily_Cost_M : Form
    {
        public Daily_Cost_M()
        {
            InitializeComponent();
        }
        int counter = 0;
        int len = 0;
        string txt;

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order ss = new Order();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Daily_Cost_M ss = new Daily_Cost_M();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Monthly_Cost ss = new Monthly_Cost();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Yearly_Cost ss = new Yearly_Cost();
            ss.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
           Employee ss = new Employee();
            ss.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Daily_Cost_2 ss = new Daily_Cost_2();
            ss.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex == 1)
            {
                label14.Visible = true;
                textBox4.Visible = true;
                comboBox2.Visible = true;
                
            }
            else
            {
                label14.Visible = false;
                textBox4.Visible = false;
                comboBox2.Visible = false;
                
            }

            if (comboBox1.SelectedIndex == 2)

            {
                //label10.Visible = true;
                textBox1.Visible = true;
            }

            else
            {
               // label10.Visible = false;
                textBox1.Visible = false;              

            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
               textBox11.Text = (float.Parse(textBox2.Text) + float.Parse(textBox9.Text) + float.Parse(textBox8.Text)).ToString();
            }
            catch
            { }


        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter > len)
            {
                counter = 0;
                label4.Text = "";
            }

            else
            {
                label4.Text = txt.Substring(0, counter);

                if (label4.ForeColor == Color.Black)
                    label4.ForeColor = Color.Blue;
                else
                    label4.ForeColor = Color.Black;

            }
            
        }

        private void Daily_Cost_M_Load_1(object sender, EventArgs e)
        {
            txt = label4.Text;
            len = txt.Length;
            label4.Text = "";
            timer1.Start();
        }
    }
}
