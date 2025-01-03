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
    public partial class Form16 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KHVK50V;Initial Catalog=COVID;Integrated Security=True");
        public Form16()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void IND_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into ISOLATION values('" + TB1I.Text.ToString() + "','" + TB2I.Text.ToString() + "','" + TB3I.Text.ToString() + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            TB1I.Text = "";
            TB2I.Text = "";
            TB3I.Text = "";
            

            MessageBox.Show("SucessfullY inserted");
        }

        private void VD_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from ISOLATION";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            ISOMGRIDVIEW.DataSource = dt;
            con.Close();
        }

        private void DD_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "delete from ISOLATION where WARD_ID='" + TB1I.Text.ToString() + "'";

            cmd.ExecuteNonQuery();
            con.Close();

            TB1I.Text = "";
            TB2I.Text = "";
            TB3I.Text = "";
            

            MessageBox.Show("Successfully deleted");
        }

        private void UD_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "update ISOLATION set BEDS = '" + TB2I.Text + "',CITY = '" + TB3I.Text + "' where WARD_ID = '" + TB1I.Text + "'";

            cmd.ExecuteNonQuery();
            con.Close();

            TB1I.Text = "";
            TB2I.Text = "";
            TB3I.Text = "";
            

            MessageBox.Show("Successfully Updated");
        }

        private void SD_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from ISOLATION where WARD_ID = '" + TB1I.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            ISOMGRIDVIEW.DataSource = dt;
            con.Close();
            MessageBox.Show("Successfully Founded");
        }

        private void HD_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }
    }
}
