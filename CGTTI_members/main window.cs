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
    public partial class main_window : Form
    {
        public main_window()
        {
            InitializeComponent();
        }
         SqlConnection pdconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\alumini.mdf;Integrated Security=True");
        private void main_window_Load(object sender, EventArgs e)
        {

            try
            {


                pdconn.Open();
                SqlCommand cmd = new SqlCommand("select count(*) From memberAM", pdconn);
                var count1 = (int)cmd.ExecuteScalar();
                atocount.Text = count1.ToString();
                // conn.Close();


                //  SqlConnection TMconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\tlakm\Videos\vs\ict project\database check software\database check software\Database1.mdf"";Integrated Security=True");
                //pdconn.Open();
                SqlCommand TMcmd = new SqlCommand("select count(*) From memberTM", pdconn);
                var count2 = (int)TMcmd.ExecuteScalar();
                tmcount.Text = count2.ToString();
                // TMconn.Close();

                SqlCommand MFcmd = new SqlCommand("select count(*) From memberMF", pdconn);
                var count3 = (int)MFcmd.ExecuteScalar();
                MFlbl.Text = count3.ToString();

                SqlCommand ACcmd = new SqlCommand("select count(*) From memberAC", pdconn);
                var count4 = (int)MFcmd.ExecuteScalar();
                AClbl.Text = count4.ToString();

                SqlCommand AEcmd = new SqlCommand("select count(*) From memberAE", pdconn);
                var count5 = (int)AEcmd.ExecuteScalar();
                AElbl.Text = count5.ToString();

                SqlCommand DMcmd = new SqlCommand("select count(*) From memberDM", pdconn);
                var count6 = (int)DMcmd.ExecuteScalar();
                DMlbl.Text = count6.ToString();

                SqlCommand BRPcmd = new SqlCommand("select count(*) From memberBRP", pdconn);
                var count7 = (int)BRPcmd.ExecuteScalar();
                BRPlbl.Text = count7.ToString();

                SqlCommand IMTcmd = new SqlCommand("select count(*) From memberIMT", pdconn);
                var count8 = (int)IMTcmd.ExecuteScalar();
                IMTlbl.Text = count8.ToString();

                SqlCommand PEcmd = new SqlCommand("select count(*) From memberPE", pdconn);
                var count9 = (int)PEcmd.ExecuteScalar();
                PElbl.Text = count3.ToString();

                SqlCommand WEcmd = new SqlCommand("select count(*) From memberWE", pdconn);
                var count10 = (int)WEcmd.ExecuteScalar();
                WElbl.Text = count10.ToString();

                int total = count1 + count2 + count3 + count4 + count5 + count6 + count7 + count8 + count9 + count10;
                totacountlbl.Text = total.ToString();





                //  SqlConnection pdconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\tlakm\Videos\vs\ict project\database check software\database check software\Database1.mdf"";Integrated Security=True");
               // pdconn.Open();
                SqlCommand pdcmd = new SqlCommand("SELECT COUNT(*) FROM memberAM WHERE Paide = 1", pdconn);
                var countpd = (int)pdcmd.ExecuteScalar();
                // paideuplbl.Text = countpd.ToString();
                //pdconn.Close();





                //SqlConnection tpdconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\tlakm\Videos\vs\ict project\database check software\database check software\Database1.mdf"";Integrated Security=True");
               // pdconn.Open();
                SqlCommand tpdcmd = new SqlCommand("SELECT COUNT(*) FROM memberTM WHERE Paide = 1", pdconn);
                var tcountpd = (int)tpdcmd.ExecuteScalar();
                // paideuplbl.Text = tcountpd.ToString();
                //tpdconn.Close();


                int totalpaide = tcountpd + countpd;
                paideuplbl.Text = totalpaide.ToString();


                int nonpaide = total - totalpaide;
                nonpaidelbl.Text = nonpaide.ToString();


                using (SqlConnection pdconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\alumini.mdf;Integrated Security=True"))
                {
                    pdconn.Open();

                    // Count of living members in memberAM
                    using (SqlCommand pddpth = new SqlCommand("SELECT COUNT(*) FROM memberAM WHERE LivingorDead = 'dead'", pdconn))
                    {
                        var amdathcount = (int)pddpth.ExecuteScalar();

                        // Count of living members in memberTM
                        using (SqlCommand tmpddpth = new SqlCommand("SELECT COUNT(*) FROM memberTM WHERE LivingorDead = 'dead'", pdconn))
                        {
                            var tmdathcount = (int)tmpddpth.ExecuteScalar();

                            // Total count of living members
                            int totaldath = tmdathcount + amdathcount;
                            dathlbl.Text = totaldath.ToString();

                            // Count of living members
                            int totalliving = total - totaldath;
                            livinglbl.Text = totalliving.ToString();
                        }
                    }
                }

            }
            catch
            {


            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Members_registration obj= new Members_registration();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Admin_registration obj = new Admin_registration();
            obj.Show();
            this.Close();
        }

        private void label30_Click(object sender, EventArgs e)
        {
            Admin_registration obj = new Admin_registration();
            obj.Show();
            this.Close();
        }
    }
}
