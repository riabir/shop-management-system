using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//Data Source = DESKTOP - N4O1QUK; Initial Catalog = shop; Integrated Security = True
namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-N4O1QUK;Initial Catalog=test1;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        int counter = 0;
        int len = 0;
        string txt;

       

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter > len)
            {
                counter = 0;
                label3.Text = "";
            }

            else
            {
                label3.Text = txt.Substring(0, counter);

                if (label3.ForeColor == Color.Green)
                    label3.ForeColor = Color.Navy;
                else
                    label3.ForeColor = Color.Green;

            }
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if// (textBox1.Text == "Abir" &&
                (textBox2.Text == "2544")

            {
                this.Hide();
                Order ss = new Order();
                ss.Show();
            }
            else
            {

                MessageBox.Show("Please check your password");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load_1(object sender, EventArgs e)
        {
            txt = label3.Text;
            len = txt.Length;
            label3.Text = "";
            timer1.Start();
        }
    }
    }

