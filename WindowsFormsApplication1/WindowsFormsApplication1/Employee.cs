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

namespace WindowsFormsApplication1
{
    public partial class Employee : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-N4O1QUK;Initial Catalog=shop;Integrated Security=True");
        public Employee()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

     

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

      

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO employee (id_no,f_name,l_name,father_name,mother_name,mobail_num1,mobail_num2,present_address,parmanent_address,nid_no,blood_group,date_birth,sallery,given_sallery,due,image) 
VALUES ('" + comboBox1.Text + "','" + textBox2 + "','" + textBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox10.Text + "','" + textBox9.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + comboBox2.Text + "','" + dateTimePicker1.Text + "','" + textBox11.Text + "','" + textBox12 + "','" + textBox13 + "','" + textBox14 + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Susscefully Save :)");
            Display();

        }

        void Display()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from employee", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();
                dataGridView1.Rows[n].Cells[10].Value = item[10].ToString();
                dataGridView1.Rows[n].Cells[11].Value = item[11].ToString();
                dataGridView1.Rows[n].Cells[12].Value = item[12].ToString();
                dataGridView1.Rows[n].Cells[13].Value = item[13].ToString();
                dataGridView1.Rows[n].Cells[14].Value = item[14].ToString();
                dataGridView1.Rows[n].Cells[15].Value = item[15].ToString();

            }


        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox10.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox9.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            textBox8.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            textBox11.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
            textBox12.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
            textBox13.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();
            textBox14.Text = dataGridView1.SelectedRows[0].Cells[15].Value.ToString();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Employee ss = new Employee();
            ss.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Yearly_Cost ss = new Yearly_Cost();
            ss.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Monthly_Cost ss = new Monthly_Cost();
            ss.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
         Daily_Cost_M ss = new Daily_Cost_M();
            ss.Show();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Order ss = new Order();
            ss.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
