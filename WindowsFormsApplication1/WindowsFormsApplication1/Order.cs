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
    
    public partial class Order : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-N4O1QUK;Initial Catalog=test1;Integrated Security=True");
        int alltotal = 0;
        public Order()
        {
            InitializeComponent();
        }
        int counter = 0;
        int len = 0;
        string txt;

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order ss = new Order();
            ss.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee ss = new Employee();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Yearly_Cost ss = new Yearly_Cost();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Monthly_Cost ss = new Monthly_Cost();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO P_Order (date,order_no,f_name,l_name, p_number,Address,sold_tottal,payment,due,listview) 
VALUES ('" + dateTimePicker1.Text + "','" + textBox13 + "',','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + listView1.Text + "')", con);

                
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Susscefully Save :)");
                Display();
            }
            catch
            {

            }

          

        }

        void Display()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from P_Order", con);
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
               
            }

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox13.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            listView1.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();

        }

      

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Daily_Cost_2 ss = new Daily_Cost_2();
            ss.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ListViewItem item1;
            item1 = listView1.SelectedItems[0];
            item1.Remove();
           //evel12.text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ListViewItem item1,item2,item3;
            item1 = listView1.Items.Add(comboBox1.Text);
            item1.SubItems.Add(comboBox5.Text);
            item1.SubItems.Add(textBox10.Text);
            item1.SubItems.Add(textBox9.Text);
            item1.SubItems.Add(textBox14.Text); 


            item2=listView1.Items.Add(comboBox2.Text);
            item2.SubItems.Add(comboBox6.Text);
            item2.SubItems.Add(textBox11.Text);
            item2.SubItems.Add("");
            item2.SubItems.Add(textBox11.Text);


            item3 = listView1.Items.Add(comboBox3.Text);
            item3.SubItems.Add(comboBox7.Text);
            item3.SubItems.Add(textBox12.Text);
            item3.SubItems.Add("");
            item3.SubItems.Add(textBox12.Text);

            alltotal += Convert.ToInt32(textBox14.Text+textBox11.Text+textBox12.Text);
            textBox5.Text = alltotal.ToString();

            comboBox1.Text = "";
            comboBox5.Text = "";
            textBox10.Text = "";
            textBox9.Text = "";
            textBox14.Text = "";


            comboBox2.Text = "";
            comboBox6.Text = "";
            textBox11.Text = "";
            textBox11.Text = "";

            comboBox3.Text = "";
            comboBox7.Text = "";
            textBox12.Text = "";
            textBox12.Text = "";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox7.Text = (float.Parse(textBox5.Text) - float.Parse(textBox6.Text)).ToString();
            }
            catch
                {

                }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox14.Text = (float.Parse(textBox10.Text) + float.Parse(textBox9.Text)).ToString();
            }
            catch
            {

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
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

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select *from ord Where ( order_no  Like  '%" + textBox13.Text + "%')", con);
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
               


            }
        }

        private void Order_Load(object sender, EventArgs e)
            
        {
            comboBox1.Items.Clear();           
            comboBox1.Items.Add("Febrics");
            comboBox1.Items.Add("Cotton");
            comboBox1.Items.Add("Other");
            //this.comboBox1.SelectedIndex = Febrics;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Order ss = new Order();
            ss.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Daily_Cost_M ss = new Daily_Cost_M();
            ss.Show();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Monthly_Cost ss = new Monthly_Cost();
            ss.Show();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Yearly_Cost ss = new Yearly_Cost();
            ss.Show();
        }

        private void button8_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Employee ss = new Employee();
            ss.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Daily_Cost_2 ss = new Daily_Cost_2();
            ss.Show();
        }

        private void Order_Load_1(object sender, EventArgs e)
        {
            txt = label10.Text;
            len = txt.Length;
            label10.Text = "";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter > len)
            {
                counter = 0;
                label10.Text = "";
            }

            else
            {
                label10.Text = txt.Substring(0, counter);

                if (label10.ForeColor == Color.Black)
                    label10.ForeColor = Color.Blue;
                else
                    label10.ForeColor = Color.Black;

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
