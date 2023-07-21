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
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadRecord();
        }
        private void LoadRecord()
        {
            
            SqlConnection con = new SqlConnection("Data Source=jayy\\sqlexpress;Initial Catalog=\"CRUD Practice Project\";Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from crud", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
            
            
            con.Close();

        }
        public void clear()
        {
            tbAge.Clear();
            tbID.Clear();
            tbFirstName.Clear();
            tbLastName.Clear();
            tbMajor.Clear();
        }

 
        private void btn_insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=jayy\\sqlexpress;Initial Catalog=\"CRUD Practice Project\";Integrated Security=True");
            con.Open();


            SqlCommand cmd = new SqlCommand("insert into crud values (@id,@first_name , @last_name, @major, @age)", con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", int.Parse(tbID.Text));
            cmd.Parameters.AddWithValue("@first_name", tbFirstName.Text);
            cmd.Parameters.AddWithValue("@last_name", tbLastName.Text);
            cmd.Parameters.AddWithValue("@major", tbMajor.Text);
            cmd.Parameters.AddWithValue("@age", int.Parse(tbAge.Text));

            MessageBox.Show("Successfully added.");

            cmd.ExecuteNonQuery();
            con.Close();

            LoadRecord();
            clear();
        }

        
    }
}
