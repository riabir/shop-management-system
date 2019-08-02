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
    public partial class Monthly_Cost : Form
    {
        public Monthly_Cost()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

      

        private void button4_Click_1(object sender, EventArgs e)
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
    }
}
