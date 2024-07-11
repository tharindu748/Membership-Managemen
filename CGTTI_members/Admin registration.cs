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

namespace alumini_association
{
    public partial class Admin_registration : Form
    {
        public Admin_registration()
        {
            InitializeComponent();
        }



        private void Asave_Click(object sender, EventArgs e)
        {

            try
            {
                string cnString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\alumini.mdf;Integrated Security=True";

                using (SqlConnection cn = new SqlConnection(cnString))
                {
                    cn.Open();

                    string insertQuery = "INSERT INTO login(UserName, Userpassword) VALUES (@UN, @UP)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, cn))
                    {
                        cmd.Parameters.AddWithValue("@UN", USEtxt.Text);
                        cmd.Parameters.AddWithValue("@UP", PASStxt.Text);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("User added successfully");
                }

            USEtxt.Clear();
                PASStxt.Clear();
            }
            catch (Exception ex)
            {
                // Handle exceptions, log them, or take appropriate action
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            main_window obj = new main_window();
            obj.Show();
            this.Close();
        }

        private void label31_Click(object sender, EventArgs e)
        {
            main_window obj = new main_window();
            obj.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Members_registration obj = new Members_registration();
            obj.Show();
            this.Close();
        }

        private void label28_Click(object sender, EventArgs e)
        {
            Members_registration obj = new Members_registration();
            obj.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            All_members obj = new All_members();
            obj.Show();
            this.Close();
        }

        private void label29_Click(object sender, EventArgs e)
        {
            All_members obj = new All_members();
            obj.Show();
            this.Close();
        }
    }
}
