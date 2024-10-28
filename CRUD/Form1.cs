using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-M561BCP\\;Initial Catalog=crud;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into crudapp values(@id,@name,@age)", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@age", double.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-M561BCP\\;Initial Catalog=crud;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update crudapp set name=@name, age=@age where id=@id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@age", double.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-M561BCP\\;Initial Catalog=crud;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete crudapp where id=@id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Deleted");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-M561BCP\\;Initial Catalog=crud;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from crudapp", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
