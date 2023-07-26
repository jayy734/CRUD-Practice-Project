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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=jayy\\sqlexpress;Initial Catalog=\"CRUD Practice Project\";Integrated Security=True");
            con.Open();


            SqlCommand cmd = new SqlCommand("Update crud set first_name = @first_name , last_name = @last_name, major = @major , age=@age where id=@id ", con);


            cmd.Parameters.Clear();
            
            cmd.Parameters.AddWithValue("@first_name", tbFirstName.Text);
            cmd.Parameters.AddWithValue("@last_name", tbLastName.Text);
            cmd.Parameters.AddWithValue("@major", tbMajor.Text);
            cmd.Parameters.AddWithValue("@age", int.Parse(tbAge.Text));
            cmd.Parameters.AddWithValue("@id", int.Parse(tbID.Text));

            MessageBox.Show("Successfully Updated.");

            cmd.ExecuteNonQuery();
            con.Close();

            LoadRecord();
            clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=jayy\\sqlexpress;Initial Catalog=\"CRUD Practice Project\";Integrated Security=True");
            con.Open();


            SqlCommand cmd = new SqlCommand("Delete crud where id=@id ", con);


            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@id", int.Parse(tbID.Text));

            MessageBox.Show("Successfully Deleted.");

            cmd.ExecuteNonQuery();
            con.Close();

            LoadRecord();
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbFirstName.Text = dataGridView1.CurrentRow.Cells["first_Name"].Value.ToString();
            tbLastName.Text = dataGridView1.CurrentRow.Cells["last_name"].Value.ToString();
            tbMajor.Text = dataGridView1.CurrentRow.Cells["major"].Value.ToString();
            tbAge.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=jayy\\sqlexpress;Initial Catalog=\"CRUD Practice Project\";Integrated Security=True");
            
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from crud Where id Like '%"+ tbSearch.Text+"%' OR first_name Like '%"+tbSearch.Text+"%' Or last_name Like '%"+tbSearch.Text+"%' Or major Like '%"+tbSearch.Text+"%' Or age Like '%"+ tbSearch.Text+"%'", con);
            
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;


            con.Close();

        }

        
    }
}
