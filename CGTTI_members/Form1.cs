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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\alumini.mdf;Integrated Security=True");
        public static string User;
        private void lgn_Click(object sender, EventArgs e)
        {
            if (Usertxt.Text == "" || txtpass.Text == "")
            {
                MessageBox.Show("Enter both username and password");

            }
            else
            {
                con.Open();
                SqlDataAdapter Sda = new SqlDataAdapter("select count(*) from login where UserName='" + Usertxt.Text + "'and UserPassword='" + txtpass.Text + "'", con);
                DataTable dt = new DataTable();
                Sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    User = Usertxt.Text;
                    main_window obj = new main_window();
                    obj.Show();
                    this.Hide();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("wrong user name or password");
                    Usertxt.Text = "";
                    txtpass.Text = "";

                }
                con.Close();

            }

        }

        private void Usertxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpass.Focus();
            }
        }

        private void Usertxt_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                lgn.Focus();

            }
        }
    }
}
