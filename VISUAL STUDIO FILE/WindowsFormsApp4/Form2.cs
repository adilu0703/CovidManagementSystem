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

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KHVK50V;Initial Catalog=COVID;Integrated Security=True");

        public Form2()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void IND_Click(object sender, EventArgs e) //INSERTING DR
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into DR values('" + TB1D.Text.ToString() + "','" + TB2D.Text.ToString() + "','" + TB3D.Text.ToString() + "','" + TB4D.Text.ToString() + "','" + TB5D.Text.ToString() + "','" + TB6D.Text.ToString() + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            TB1D.Text = "";
            TB2D.Text = "";
            TB3D.Text = "";
            TB4D.Text = "";
            TB5D.Text = "";

            MessageBox.Show("SucessfullY inserted");
        }

        private void VD_Click(object sender, EventArgs e)  //VIEW GRID
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from DR";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void DD_Click(object sender, EventArgs e) // DELETE DR
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "delete from DR where DR_ID='" + TB1D.Text.ToString() + "'";

            cmd.ExecuteNonQuery();
            con.Close();

            TB1D.Text = "";
            TB2D.Text = "";
            TB3D.Text = "";
            TB4D.Text = "";
            TB5D.Text = "";

            MessageBox.Show("Successfully deleted");
        }

        private void UD_Click(object sender, EventArgs e) //UPDATE
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "update DR set DR_NAME = '" + TB2D.Text + "',GENDER = '" + TB3D.Text + "', AGE = '" + TB4D.Text + "', WARD_NAME = '" + TB5D.Text + "',WARD_ID = '" + TB6D.Text + "' where DR_ID = '" + TB1D.Text + "'";

            cmd.ExecuteNonQuery();
            con.Close();

            TB1D.Text = "";
            TB2D.Text = "";
            TB3D.Text = "";
            TB4D.Text = "";
            TB5D.Text = "";

            MessageBox.Show("Successfully Updated");
        }

        private void SD_Click(object sender, EventArgs e) //SEARCH DR
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from DR where DR_ID = '" + TB1D.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
            MessageBox.Show("Successfully Founded");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
