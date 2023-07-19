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

namespace CRUD_Practice_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadRecord()
        {
            dataGridView1.Rows.Clear();
            SqlConnection con = new SqlConnection("Data Source=jayy\\sqlexpress;Initial Catalog=\"CRUD Practice Project\";Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from crud", con);
            cmd.ExecuteReader();
            while (cmd.ExecuteReader().Read())
            {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, "@id".ToString(), "@first_name".ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=jayy\\sqlexpress;Initial Catalog=\"CRUD Practice Project\";Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into crud values (@id,@first_name , @last_name, @major, @age)",con);
            cmd.Parameters.AddWithValue("@id", int.Parse(tbID.Text));
            cmd.Parameters.AddWithValue("@first_name", tbFirstName.Text);
            cmd.Parameters.AddWithValue("@last_name", tbLastName.Text);
            cmd.Parameters.AddWithValue("@major", tbMajor.Text);
            cmd.Parameters.AddWithValue("@age", int.Parse(tbAge.Text));

            MessageBox.Show("Successfully added.");

            cmd.ExecuteNonQuery();
            con.Close();

            SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from crud", con);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);

            dataGridView1.DataSource = dt;








        }
    }
}
