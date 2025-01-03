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

    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KHVK50V;Initial Catalog=COVID;Integrated Security=True");
        public Form4()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void TB2P_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //INSERT PATIENTS
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into PATIENT values('" + TB1P.Text.ToString() + "','" + TB2P.Text.ToString() + "','" + TB3P.Text.ToString() + "','" + TB4P.Text.ToString() + "','" + TB5P.Text.ToString() + "','" + TB6P.Text.ToString() + "','" + TB7P.Text.ToString() + "','" + TB8P.Text.ToString() + "','" + TB9P.Text.ToString() + "','" + TB10P.Text.ToString() + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            TB1P.Text = "";
            TB2P.Text = "";
            TB3P.Text = "";
            TB4P.Text = "";
            TB5P.Text = "";
            TB6P.Text = "";
            TB7P.Text = "";
            TB8P.Text = "";
            TB9P.Text = "";
            TB10P.Text = "";

            MessageBox.Show("Sucessfull inserted");
        }

        private void VP_Click(object sender, EventArgs e)  // VIEW PATIENTS
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from PATIENT";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            P_GRIDVIEW.DataSource = dt;
            con.Close();
        }

        private void P_GRIDVIEW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VS_Click(object sender, EventArgs e) // SEARCH PATIENT
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from PATIENT where PATIENT_ID = '" + TB1P.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            P_GRIDVIEW.DataSource = dt;
            con.Close();
            MessageBox.Show("Successfully Founded");
        }

        private void VU_Click(object sender, EventArgs e) //UPDATE
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "update PATIENT set PATIENT_NAME = '" + TB2P.Text + "', PATIENT_GENDER = '" + TB3P.Text + "',PATIENT_AGE = '" + TB4P.Text + "', PATIENT_BLOODGP = '" + TB5P.Text + "', PATIENT_ADDRESS = '" + TB6P.Text + "', PATIENT_CITY = '" + TB7P.Text + "',WARD_ID = '" + TB8P.Text + "',WARD_NAME = '" + TB9P.Text + "',STATUS = '" + TB10P.Text + "' where PATIENT_ID = '" + TB1P.Text + "'";

            cmd.ExecuteNonQuery();
            con.Close();

            TB1P.Text = "";
            TB2P.Text = "";
            TB3P.Text = "";
            TB4P.Text = "";
            TB5P.Text = "";
            TB6P.Text = "";
            TB7P.Text = "";
            TB8P.Text = "";
            TB9P.Text = "";
            TB10P.Text = "";

            MessageBox.Show("Successfully Updated");
        }

        private void VD_Click(object sender, EventArgs e) // DELETE PATIENT
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "delete from PATIENT where PATIENT_ID = '" + TB1P.Text.ToString() + "'";

            cmd.ExecuteNonQuery();
            con.Close();

            TB1P.Text = "";
            TB2P.Text = "";
            TB3P.Text = "";
            TB4P.Text = "";
            TB5P.Text = "";
            TB6P.Text = "";
            TB7P.Text = "";
            TB8P.Text = "";
            TB9P.Text = "";
            TB10P.Text = "";
            MessageBox.Show("Successfully deleted");
        }
    }
}
