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
    public partial class Daily_Cost_2 : Form
    {
        public Daily_Cost_2()
        {
            InitializeComponent();
        }

        int counter = 0;
        int len = 0;
        string txt;


        private void button10_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Order ss = new Order();
            ss.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Daily_Cost_M ss = new Daily_Cost_M();
            ss.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
           Monthly_Cost ss = new Monthly_Cost();
            ss.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Yearly_Cost ss = new Yearly_Cost();
            ss.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Employee ss = new Employee();
            ss.Show();
        }

        private void Daily_Cost_2_Load(object sender, EventArgs e)
        {
            txt = label5.Text;
            len = txt.Length;
            label5.Text = "";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter > len)
            {
                counter = 0;
                label5.Text = "";
            }

            else
            {
                label5.Text = txt.Substring(0, counter);

                if (label5.ForeColor == Color.Green)
                    label5.ForeColor = Color.Navy;
                else
                    label5.ForeColor = Color.Green;

            }
        }
    }
}
