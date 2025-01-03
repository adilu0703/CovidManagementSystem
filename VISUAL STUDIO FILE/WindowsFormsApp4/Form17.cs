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
    public partial class Form17 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KHVK50V;Initial Catalog=COVID;Integrated Security=True");
        public Form17()
        {
            InitializeComponent();
        }

        private void IND_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into QUARANTINE values('" + TB1Q.Text.ToString() + "','" + TB2Q.Text.ToString() + "','" + TB3Q.Text.ToString() + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            TB1Q.Text = "";
            TB2Q.Text = "";
            TB3Q.Text = "";


            MessageBox.Show("SucessfullY inserted");
        }

        private void SD_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from QUARANTINE where WARD_ID = '" + TB1Q.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            QUAMGRIDVIEW.DataSource = dt;
            con.Close();
            MessageBox.Show("Successfully Founded");
        }

        private void UD_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "update QUARANTINE set BEDS = '" + TB2Q.Text + "',CITY = '" + TB3Q.Text + "' where WARD_ID = '" + TB1Q.Text + "'";

            cmd.ExecuteNonQuery();
            con.Close();

            TB1Q.Text = "";
            TB2Q.Text = "";
            TB3Q.Text = "";
        }

        private void DD_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "delete from QUARANTINE where WARD_ID='" + TB1Q.Text.ToString() + "'";

            cmd.ExecuteNonQuery();
            con.Close();

            TB1Q.Text = "";
            TB2Q.Text = "";
            TB3Q.Text = "";

        }

        private void VD_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from QUARANTINE";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            QUAMGRIDVIEW.DataSource = dt;
            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void HD_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8();
            f8.ShowDialog();
        }
    }
}
