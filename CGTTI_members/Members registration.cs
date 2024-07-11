using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alumini_association
{
    public partial class Members_registration : Form
    {

        private int currentPage = 1;
        private int pageSize = 10;
        public Members_registration()
        {
            InitializeComponent();
            
        }
        int scr_val;
        SqlDataAdapter da;
        DataSet ds;

        private void sBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\alumini.mdf;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(cn))
                {
                    conn.Open();

                    if (comboBox1.SelectedIndex == 0)
                    {
                        string memberAMQuery = "INSERT INTO memberAM (Traningnumber, Memberyear, Membershipnumber, MemberName, Section, Addrass, District, Nic, Mobile, Paide, LivingorDead) " +
                            "VALUES (@Traningnumber, @Memberyear, @Membershipnumber, @MemberName, @Section, @Addrass, @District, @Nic, @Mobile, @paid, @status)";

                        using (SqlCommand AMmemberCmd = new SqlCommand(memberAMQuery, conn))
                        {
                            AMmemberCmd.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            AMmemberCmd.Parameters.AddWithValue("@Memberyear", myTxt.Text);
                            AMmemberCmd.Parameters.AddWithValue("@Membershipnumber", mnTxt.Text);
                            AMmemberCmd.Parameters.AddWithValue("@MemberName", nTxt.Text);
                            AMmemberCmd.Parameters.AddWithValue("@Section", comboBox1.SelectedItem);
                            AMmemberCmd.Parameters.AddWithValue("@Addrass", addTxt.Text);
                            AMmemberCmd.Parameters.AddWithValue("@District", distxt.Text);
                            AMmemberCmd.Parameters.AddWithValue("@Mobile", mTxt.Text);
                            AMmemberCmd.Parameters.AddWithValue("@Nic", nicTxt.Text);
                            AMmemberCmd.Parameters.AddWithValue("@paid", radioButton1.Checked ? 1 : 0);

                            String Live = "living";
                            string dade = "dath";
                            if (checkBox1.Checked)
                            {
                                AMmemberCmd.Parameters.AddWithValue("status", dade);
                            }
                            else
                            {
                                AMmemberCmd.Parameters.AddWithValue("status", Live);
                            }


                            // AMmemberCmd.Parameters.AddWithValue("@paid", radioButton2.Checked ? 0 : 1);
                            //AMmemberCmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);

                            AMmemberCmd.ExecuteNonQuery();
                        }
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        string memberTMQuery = "INSERT INTO memberTM (Traningnumber, Memberyear, Membershipnumber, MemberName, Section, Addrass, District, Nic, Mobile, Paide, LivingorDead) " +
                            "VALUES (@Traningnumber, @Memberyear, @Membershipnumber, @MemberName, @Section, @Addrass, @District, @Nic, @Mobile, @paid, @status)";

                        using (SqlCommand TMmemberCmd = new SqlCommand(memberTMQuery, conn))
                        {
                            TMmemberCmd.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@Memberyear", myTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@Membershipnumber", mnTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@MemberName", nTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@Section", comboBox1.SelectedItem);
                            TMmemberCmd.Parameters.AddWithValue("@Addrass", addTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@District", distxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@Mobile", mTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@Nic", nicTxt.Text);
                            //TMmemberCmd.Parameters.AddWithValue("@dath", checkBox1.Checked ? 1 : 0);

                            string dade = "dath";
                            string live = "living";
                            if (checkBox1.Checked)
                            {
                                TMmemberCmd.Parameters.AddWithValue("@status", dade);
                            }
                            else
                            {
                                TMmemberCmd.Parameters.AddWithValue("@status", live);
                            }


                            TMmemberCmd.Parameters.AddWithValue("@paid", radioButton1.Checked ? 1 : 0);
                            // TMmemberCmd.Parameters.AddWithValue("@paid", radioButton2.Checked ? 0 : 1);

                            //TMmemberCmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);

                            TMmemberCmd.ExecuteNonQuery();
                        }
                    }
                    else if (comboBox1.SelectedIndex == 2)
                    {
                        string memberTMQuery = "INSERT INTO memberMF (Traningnumber, Memberyear, Membershipnumber, MemberName, Section, Addrass, District, Nic, Mobile, Paide, LivingorDead) " +
                            "VALUES (@Traningnumber, @Memberyear, @Membershipnumber, @MemberName, @Section, @Addrass, @District, @Nic, @Mobile, @paid, @status)";

                        using (SqlCommand TMmemberCmd = new SqlCommand(memberTMQuery, conn))
                        {
                            TMmemberCmd.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@Memberyear", myTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@Membershipnumber", mnTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@MemberName", nTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@Section", comboBox1.SelectedItem);
                            TMmemberCmd.Parameters.AddWithValue("@Addrass", addTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@District", distxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@Mobile", mTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@Nic", nicTxt.Text);
                            //TMmemberCmd.Parameters.AddWithValue("@dath", checkBox1.Checked ? 1 : 0);

                            string dade = "dath";
                            string live = "living";
                            if (checkBox1.Checked)
                            {
                                TMmemberCmd.Parameters.AddWithValue("@status", dade);
                            }
                            else
                            {
                                TMmemberCmd.Parameters.AddWithValue("@status", live);
                            }


                            TMmemberCmd.Parameters.AddWithValue("@paid", radioButton1.Checked ? 1 : 0);
                            // TMmemberCmd.Parameters.AddWithValue("@paid", radioButton2.Checked ? 0 : 1);

                            //TMmemberCmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);

                            TMmemberCmd.ExecuteNonQuery();
                        }
                    }

                    else if (comboBox1.SelectedIndex == 3)
                    {
                        string memberMFQuery = "INSERT INTO memberAC (Traningnumber, Memberyear, Membershipnumber, MemberName, Section, Addrass, District, Nic, Mobile, paid, [dead-or-living]) " +
                            "VALUES (@Traningnumber, @Memberyear, @Membershipnumber, @MemberName, @Section, @Addrass, @District, @Nic, @Mobile, @paid, @dathorliving)";

                        using (SqlCommand MFmemberCmd = new SqlCommand(memberMFQuery, conn))
                        {
                            MFmemberCmd.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            MFmemberCmd.Parameters.AddWithValue("@Memberyear", myTxt.Text);
                            MFmemberCmd.Parameters.AddWithValue("@Membershipnumber", mnTxt.Text);
                            MFmemberCmd.Parameters.AddWithValue("@MemberName", nTxt.Text);
                            MFmemberCmd.Parameters.AddWithValue("@Section", comboBox1.SelectedItem);
                            MFmemberCmd.Parameters.AddWithValue("@Addrass", addTxt.Text);
                            MFmemberCmd.Parameters.AddWithValue("@District", distxt.Text);
                            MFmemberCmd.Parameters.AddWithValue("@Mobile", mTxt.Text);
                            MFmemberCmd.Parameters.AddWithValue("@Nic", nicTxt.Text);
                            MFmemberCmd.Parameters.AddWithValue("@paid", radioButton1.Checked ? 1 : 0);


                            string dade = "dath";
                            string live = "living";
                            if (checkBox1.Checked)
                            {
                                MFmemberCmd.Parameters.AddWithValue("@dathorliving", dade);
                            }
                            else
                            {
                                MFmemberCmd.Parameters.AddWithValue("@dathorliving", live);
                            }


                            // AMmemberCmd.Parameters.AddWithValue("@paid", radioButton2.Checked ? 0 : 1);
                            //AMmemberCmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);

                            MFmemberCmd.ExecuteNonQuery();
                        }
                    }


                    else if (comboBox1.SelectedIndex == 4)
                    {
                        string memberTMQuery = "INSERT INTO memberAE (Traningnumber, Memberyear, Membershipnumber, MemberName, Section, Addrass, District, Nic, Mobile, Paide, LivingorDead) " +
                            "VALUES (@Traningnumber, @Memberyear, @Membershipnumber, @MemberName, @Section, @Addrass, @District, @Nic, @Mobile, @paid, @status)";

                        using (SqlCommand TMmemberCmd = new SqlCommand(memberTMQuery, conn))
                        {
                            TMmemberCmd.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@Memberyear", myTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@Membershipnumber", mnTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@MemberName", nTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@Section", comboBox1.SelectedItem);
                            TMmemberCmd.Parameters.AddWithValue("@Addrass", addTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@District", distxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@Mobile", mTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@Nic", nicTxt.Text);
                            //TMmemberCmd.Parameters.AddWithValue("@dath", checkBox1.Checked ? 1 : 0);

                            string dade = "dath";
                            string live = "living";
                            if (checkBox1.Checked)
                            {
                                TMmemberCmd.Parameters.AddWithValue("@status", dade);
                            }
                            else
                            {
                                TMmemberCmd.Parameters.AddWithValue("@status", live);
                            }


                            TMmemberCmd.Parameters.AddWithValue("@paid", radioButton1.Checked ? 1 : 0);
                            // TMmemberCmd.Parameters.AddWithValue("@paid", radioButton2.Checked ? 0 : 1);

                            //TMmemberCmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);

                            TMmemberCmd.ExecuteNonQuery();
                        }
                    }

                    else if (comboBox1.SelectedIndex == 5)
                    {
                        string memberTMQuery = "INSERT INTO memberDM (Traningnumber, Memberyear, Membershipnumber, MemberName, Section, Addrass, District, Nic, Mobile, Paide, LivingorDead) " +
                            "VALUES (@Traningnumber, @Memberyear, @Membershipnumber, @MemberName, @Section, @Addrass, @District, @Nic, @Mobile, @paid, @status)";

                        using (SqlCommand TMmemberCmd = new SqlCommand(memberTMQuery, conn))
                        {
                            TMmemberCmd.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@Memberyear", myTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@Membershipnumber", mnTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@MemberName", nTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@Section", comboBox1.SelectedItem);
                            TMmemberCmd.Parameters.AddWithValue("@Addrass", addTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@District", distxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@Mobile", mTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@Nic", nicTxt.Text);
                            //TMmemberCmd.Parameters.AddWithValue("@dath", checkBox1.Checked ? 1 : 0);

                            string dade = "dath";
                            string live = "living";
                            if (checkBox1.Checked)
                            {
                                TMmemberCmd.Parameters.AddWithValue("@status", dade);
                            }
                            else
                            {
                                TMmemberCmd.Parameters.AddWithValue("@status", live);
                            }


                            TMmemberCmd.Parameters.AddWithValue("@paid", radioButton1.Checked ? 1 : 0);
                            // TMmemberCmd.Parameters.AddWithValue("@paid", radioButton2.Checked ? 0 : 1);

                            //TMmemberCmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);

                            TMmemberCmd.ExecuteNonQuery();
                        }
                    }
                    else if (comboBox1.SelectedIndex == 6)
                    {
                        string memberTMQuery = "INSERT INTO memberBRP (Traningnumber, Memberyear, Membershipnumber, MemberName, Section, Addrass, District, Nic, Mobile, Paide, LivingorDead) " +
                            "VALUES (@Traningnumber, @Memberyear, @Membershipnumber, @MemberName, @Section, @Addrass, @District, @Nic, @Mobile, @paid, @status)";

                        using (SqlCommand TMmemberCmd = new SqlCommand(memberTMQuery, conn))
                        {
                            TMmemberCmd.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@Memberyear", myTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@Membershipnumber", mnTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@MemberName", nTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@Section", comboBox1.SelectedItem);
                            TMmemberCmd.Parameters.AddWithValue("@Addrass", addTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@District", distxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@Mobile", mTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@Nic", nicTxt.Text);
                            //TMmemberCmd.Parameters.AddWithValue("@dath", checkBox1.Checked ? 1 : 0);

                            string dade = "dath";
                            string live = "living";
                            if (checkBox1.Checked)
                            {
                                TMmemberCmd.Parameters.AddWithValue("@status", dade);
                            }
                            else
                            {
                                TMmemberCmd.Parameters.AddWithValue("@status", live);
                            }


                            TMmemberCmd.Parameters.AddWithValue("@paid", radioButton1.Checked ? 1 : 0);
                            // TMmemberCmd.Parameters.AddWithValue("@paid", radioButton2.Checked ? 0 : 1);

                            //TMmemberCmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);

                            TMmemberCmd.ExecuteNonQuery();
                        }
                    }
                    else if (comboBox1.SelectedIndex == 7)
                    {
                        string memberTMQuery = "INSERT INTO memberIMT(Traningnumber, Memberyear, Membershipnumber, MemberName, Section, Addrass, District, Nic, Mobile, Paide, LivingorDead) " +
                            "VALUES (@Traningnumber, @Memberyear, @Membershipnumber, @MemberName, @Section, @Addrass, @District, @Nic, @Mobile, @paid, @status)";

                        using (SqlCommand TMmemberCmd = new SqlCommand(memberTMQuery, conn))
                        {
                            TMmemberCmd.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@Memberyear", myTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@Membershipnumber", mnTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@MemberName", nTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@Section", comboBox1.SelectedItem);
                            TMmemberCmd.Parameters.AddWithValue("@Addrass", addTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@District", distxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@Mobile", mTxt.Text);
                            TMmemberCmd.Parameters.AddWithValue("@Nic", nicTxt.Text);
                            //TMmemberCmd.Parameters.AddWithValue("@dath", checkBox1.Checked ? 1 : 0);

                            string dade = "dath";
                            string live = "living";
                            if (checkBox1.Checked)
                            {
                                TMmemberCmd.Parameters.AddWithValue("@status", dade);
                            }
                            else
                            {
                                TMmemberCmd.Parameters.AddWithValue("@status", live);
                            }


                            TMmemberCmd.Parameters.AddWithValue("@paid", radioButton1.Checked ? 1 : 0);
                            // TMmemberCmd.Parameters.AddWithValue("@paid", radioButton2.Checked ? 0 : 1);

                            //TMmemberCmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);

                            TMmemberCmd.ExecuteNonQuery();
                        }
                    }

                    else if (comboBox1.SelectedIndex == 8)
                    {
                        string memberPEQuery = "INSERT INTO memberPE (Traningnumber, Memberyear, Membershipnumber, MemberName, Section, Addrass, District, Nic, Mobile, Paide, LivingorDead) " +
                            "VALUES (@Traningnumber, @Memberyear, @Membershipnumber, @MemberName, @Section, @Addrass, @District, @Nic, @Mobile, @paid, @status)";

                        using (SqlCommand PEmemberCmd = new SqlCommand(memberPEQuery, conn))
                        {
                            PEmemberCmd.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            PEmemberCmd.Parameters.AddWithValue("@Memberyear", myTxt.Text);
                            PEmemberCmd.Parameters.AddWithValue("@Membershipnumber", mnTxt.Text);
                            PEmemberCmd.Parameters.AddWithValue("@MemberName", nTxt.Text);
                            PEmemberCmd.Parameters.AddWithValue("@Section", comboBox1.SelectedItem);
                            PEmemberCmd.Parameters.AddWithValue("@Addrass", addTxt.Text);
                            PEmemberCmd.Parameters.AddWithValue("@District", distxt.Text);
                            PEmemberCmd.Parameters.AddWithValue("@Mobile", mTxt.Text);
                            PEmemberCmd.Parameters.AddWithValue("@Nic", nicTxt.Text);
                            //TMmemberCmd.Parameters.AddWithValue("@dath", checkBox1.Checked ? 1 : 0);

                            string dade = "dath";
                            string live = "living";
                            if (checkBox1.Checked)
                            {
                                PEmemberCmd.Parameters.AddWithValue("@status", dade);
                            }
                            else
                            {
                                PEmemberCmd.Parameters.AddWithValue("@status", live);
                            }


                            PEmemberCmd.Parameters.AddWithValue("@paid", radioButton1.Checked ? 1 : 0);
                            // TMmemberCmd.Parameters.AddWithValue("@paid", radioButton2.Checked ? 0 : 1);

                            //TMmemberCmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);

                            PEmemberCmd.ExecuteNonQuery();
                        }
                    }
                    else if (comboBox1.SelectedIndex == 9)
                    {
                        string memberWEQuery = "INSERT INTO memberWE (Traningnumber, Memberyear, Membershipnumber, MemberName, Section, Addrass, District, Nic, Mobile, Paide, LivingorDead) " +
                            "VALUES (@Traningnumber, @Memberyear, @Membershipnumber, @MemberName, @Section, @Addrass, @District, @Nic, @Mobile, @paid, @status)";

                        using (SqlCommand WEmemberCmd = new SqlCommand(memberWEQuery, conn))
                        {
                            WEmemberCmd.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            WEmemberCmd.Parameters.AddWithValue("@Memberyear", myTxt.Text);
                            WEmemberCmd.Parameters.AddWithValue("@Membershipnumber", mnTxt.Text);
                            WEmemberCmd.Parameters.AddWithValue("@MemberName", nTxt.Text);
                            WEmemberCmd.Parameters.AddWithValue("@Section", comboBox1.SelectedItem);
                            WEmemberCmd.Parameters.AddWithValue("@Addrass", addTxt.Text);
                            WEmemberCmd.Parameters.AddWithValue("@District", distxt.Text);
                            WEmemberCmd.Parameters.AddWithValue("@Mobile", mTxt.Text);
                            WEmemberCmd.Parameters.AddWithValue("@Nic", nicTxt.Text);
                            //TMmemberCmd.Parameters.AddWithValue("@dath", checkBox1.Checked ? 1 : 0);

                            string dade = "dath";
                            string live = "living";
                            if (checkBox1.Checked)
                            {
                                WEmemberCmd.Parameters.AddWithValue("@status", dade);
                            }
                            else
                            {
                                WEmemberCmd.Parameters.AddWithValue("@status", live);
                            }


                            WEmemberCmd.Parameters.AddWithValue("@paid", radioButton1.Checked ? 1 : 0);
                            // TMmemberCmd.Parameters.AddWithValue("@paid", radioButton2.Checked ? 0 : 1);

                            //TMmemberCmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);

                            WEmemberCmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Successfully saved");

                    // Clear your form fields as needed
                    tnTxt.Clear();
                    mnTxt.Clear();
                    nTxt.Clear();
                    addTxt.Clear();
                    distxt.Clear();
                    mTxt.Clear();
                    distxt.Clear();
                    nicTxt.Clear();
                    myTxt.Clear();
                    comboBox1.SelectedItem = null;
                    checkBox1.CheckState = CheckState.Unchecked;
                    checkBox2.CheckState = CheckState.Unchecked;
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\alumini.mdf;Integrated Security=True"))
            {
                try
                {
                    conn.Open();

                    // Update Memberyear
                    if (!string.IsNullOrEmpty(myTxt.Text))
                    {
                        string queryTM = "UPDATE memberTM SET Memberyear = @Memberyear WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdTM = new SqlCommand(queryTM, conn))
                        {
                            cmdTM.Parameters.AddWithValue("@Memberyear", myTxt.Text);
                            cmdTM.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdTM.ExecuteNonQuery();
                         
                        }

                        string queryAM = "UPDATE memberAM SET Memberyear = @Memberyear WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdAM = new SqlCommand(queryAM, conn))
                        {
                            cmdAM.Parameters.AddWithValue("@Memberyear", myTxt.Text);
                            cmdAM.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdAM.ExecuteNonQuery();
                            

                        }
                        string queryMF = "UPDATE memberMF SET Memberyear = @Memberyear WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdMF = new SqlCommand(queryMF, conn))
                        {
                            cmdMF.Parameters.AddWithValue("@Memberyear", myTxt.Text);
                            cmdMF.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdMF.ExecuteNonQuery();
                         
                        }
                        string queryAC = "UPDATE memberAC SET Memberyear = @Memberyear WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdAC = new SqlCommand(queryAC, conn))
                        {
                            cmdAC.Parameters.AddWithValue("@Memberyear", myTxt.Text);
                            cmdAC.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdAC.ExecuteNonQuery();
                          
                        }
                        string queryAE = "UPDATE memberAE SET Memberyear = @Memberyear WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdAE = new SqlCommand(queryAE, conn))
                        {
                            cmdAE.Parameters.AddWithValue("@Memberyear", myTxt.Text);
                            cmdAE.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdAE.ExecuteNonQuery();
                          
                        }
                        string queryDM = "UPDATE memberDM SET Memberyear = @Memberyear WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdDM = new SqlCommand(queryDM, conn))
                        {
                            cmdDM.Parameters.AddWithValue("@Memberyear", myTxt.Text);
                            cmdDM.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdDM.ExecuteNonQuery();
                            

                        }
                        string queryBRP = "UPDATE memberBRP SET Memberyear = @Memberyear WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdBRP = new SqlCommand(queryBRP, conn))
                        {
                            cmdBRP.Parameters.AddWithValue("@Memberyear", myTxt.Text);
                            cmdBRP.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdBRP.ExecuteNonQuery();
                      
                        }
                        string queryIMT = "UPDATE memberIMT SET Memberyear = @Memberyear WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdIMT = new SqlCommand(queryIMT, conn))
                        {
                            cmdIMT.Parameters.AddWithValue("@Memberyear", myTxt.Text);
                            cmdIMT.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdIMT.ExecuteNonQuery();
                     
                        }
                        string queryPE = "UPDATE memberPE SET Memberyear = @Memberyear WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdPE = new SqlCommand(queryPE, conn))
                        {
                            cmdPE.Parameters.AddWithValue("@Memberyear", myTxt.Text);
                            cmdPE.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdPE.ExecuteNonQuery();
                       
                        }
                        string queryWE = "UPDATE memberWE SET Memberyear = @Memberyear WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdWE = new SqlCommand(queryWE, conn))
                        {
                            cmdWE.Parameters.AddWithValue("@Memberyear", myTxt.Text);
                            cmdWE.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdWE.ExecuteNonQuery();
                           
                         

                        }
                        tnTxt.Clear();
                        myTxt.Clear();
                        MessageBox.Show("Memberyear for membership year updated successfully");
                    }

                    // Update District
                    if (!string.IsNullOrEmpty(distxt.Text))
                    {
                        string[] tableNames = { "memberTM", "memberAM", "memberMF", "memberAC", "memberAE", "memberDM", "memberBRP", "memberIMT", "memberPE", "memberWE" };

                        try
                        {
                            foreach (var tableName in tableNames)
                            {
                                string query = $"UPDATE {tableName} SET District = @District WHERE Traningnumber = @Traningnumber";
                                using (SqlCommand cmd = new SqlCommand(query, conn))
                                {
                                    cmd.Parameters.AddWithValue("@District", distxt.Text);
                                    cmd.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                                    cmd.ExecuteNonQuery();
                                }
                            }

                            MessageBox.Show("District updated successfully");
                            distxt.Clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message);
                        }
                    }


                    // Update Paide
                    if (radioButton1.Checked || radioButton2.Checked)
                    {
                        string queryTM = "UPDATE memberTM SET Paide = @paid  WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdTM = new SqlCommand(queryTM, conn))
                        {
                            cmdTM.Parameters.AddWithValue("@paid", radioButton1.Checked);
                            
                            cmdTM.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdTM.ExecuteNonQuery();
                          
                        }

                        string queryAM = "UPDATE memberAM SET Paide = @paid WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdAM = new SqlCommand(queryAM, conn))
                        {
                            cmdAM.Parameters.AddWithValue("@paid", radioButton1.Checked);
                           
                            cmdAM.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdAM.ExecuteNonQuery();
                            
                        }
                        string queryMF = "UPDATE memberMF SET Paide = @paid  WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdMF = new SqlCommand(queryMF, conn))
                        {
                            cmdMF.Parameters.AddWithValue("@paid", radioButton1.Checked);

                            cmdMF.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdMF.ExecuteNonQuery();
                          
                        }
                        string queryAC = "UPDATE memberAC SET Paide = @paid  WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdAC = new SqlCommand(queryAC, conn))
                        {
                            cmdAC.Parameters.AddWithValue("@paid", radioButton1.Checked);

                            cmdAC.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdAC.ExecuteNonQuery();
                           
                        }
                        string queryAE = "UPDATE memberAE SET Paide = @paid  WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdAE = new SqlCommand(queryAE, conn))
                        {
                            cmdAE.Parameters.AddWithValue("@paid", radioButton1.Checked);

                            cmdAE.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdAE.ExecuteNonQuery();
                           
                        }
                        string queryDM = "UPDATE memberDM SET Paide = @paid  WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdDM = new SqlCommand(queryDM, conn))
                        {
                            cmdDM.Parameters.AddWithValue("@paid", radioButton1.Checked);

                            cmdDM.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdDM.ExecuteNonQuery();
                           
                        }
                        string queryBRP = "UPDATE memberBRP SET Paide = @paid  WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdBRP = new SqlCommand(queryBRP, conn))
                        {
                            cmdBRP.Parameters.AddWithValue("@paid", radioButton1.Checked);

                            cmdBRP.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdBRP.ExecuteNonQuery();
                           
                        }
                        string queryIMT = "UPDATE memberIMT SET Paide = @paid  WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdIMT = new SqlCommand(queryIMT, conn))
                        {
                            cmdIMT.Parameters.AddWithValue("@paid", radioButton1.Checked);

                            cmdIMT.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdIMT.ExecuteNonQuery();
                          
                        }
                        string queryPE = "UPDATE memberPE SET Paide = @paid  WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdPE = new SqlCommand(queryPE, conn))
                        {
                            cmdPE.Parameters.AddWithValue("@paid", radioButton1.Checked);

                            cmdPE.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdPE.ExecuteNonQuery();
                           
                        }
                        string queryWE = "UPDATE memberWE SET Paide = @paid  WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdWE = new SqlCommand(queryWE, conn))
                        {
                            cmdWE.Parameters.AddWithValue("@paid", radioButton1.Checked);

                            cmdWE.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdWE.ExecuteNonQuery();
                           
                        }
                        
                        MessageBox.Show("Paide status updated successfully");



                    }

                    // Update LivingorDead
                    if (checkBox2.Checked)
                    {
                        string queryTM = "UPDATE memberTM SET LivingorDead = @dathorliving WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdTM = new SqlCommand(queryTM, conn))
                        {
                            cmdTM.Parameters.AddWithValue("@dathorliving", checkBox2.Checked ? "living" : "dead");
                            cmdTM.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdTM.ExecuteNonQuery();
                        }

                        string queryAM = "UPDATE memberAM SET LivingorDead = @dathorliving WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdAM = new SqlCommand(queryAM, conn))
                        {
                            cmdAM.Parameters.AddWithValue("@dathorliving", checkBox2.Checked ? "living" : "dead");
                            cmdAM.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdAM.ExecuteNonQuery();
                       
                        }

                        string queryMF = "UPDATE memberMF SET LivingorDead = @dathorliving WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdMF = new SqlCommand(queryMF, conn))
                        {
                            cmdMF.Parameters.AddWithValue("@dathorliving", checkBox2.Checked ? "living" : "dead");
                            cmdMF.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdMF.ExecuteNonQuery();

                        }

                        string queryAC = "UPDATE memberAC SET LivingorDead = @dathorliving WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdAC = new SqlCommand(queryAC, conn))
                        {
                            cmdAC.Parameters.AddWithValue("@dathorliving", checkBox2.Checked ? "living" : "dead");
                            cmdAC.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdAC.ExecuteNonQuery();

                        }
                        string queryAE = "UPDATE memberAE SET LivingorDead = @dathorliving WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdAE = new SqlCommand(queryAE, conn))
                        {
                            cmdAE.Parameters.AddWithValue("@dathorliving", checkBox2.Checked ? "living" : "dead");
                            cmdAE.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdAE.ExecuteNonQuery();

                        }
                        string queryDM = "UPDATE memberAM SET LivingorDead = @dathorliving WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdDM = new SqlCommand(queryDM, conn))
                        {
                            cmdDM.Parameters.AddWithValue("@dathorliving", checkBox2.Checked ? "living" : "dead");
                            cmdDM.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdDM.ExecuteNonQuery();

                        }
                        string queryBRP = "UPDATE memberBRP SET LivingorDead = @dathorliving WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdBRP = new SqlCommand(queryBRP, conn))
                        {
                            cmdBRP.Parameters.AddWithValue("@dathorliving", checkBox2.Checked ? "living" : "dead");
                            cmdBRP.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdBRP.ExecuteNonQuery();

                        }
                        string queryIMT = "UPDATE memberIMT SET LivingorDead = @dathorliving WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdIMT = new SqlCommand(queryIMT, conn))
                        {
                            cmdIMT.Parameters.AddWithValue("@dathorliving", checkBox2.Checked ? "living" : "dead");
                            cmdIMT.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdIMT.ExecuteNonQuery();

                        }
                        string queryPE = "UPDATE memberPE SET LivingorDead = @dathorliving WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdPE = new SqlCommand(queryPE, conn))
                        {
                            cmdPE.Parameters.AddWithValue("@dathorliving", checkBox2.Checked ? "living" : "dead");
                            cmdPE.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdPE.ExecuteNonQuery();

                        }
                        string queryWE = "UPDATE memberWE SET LivingorDead = @dathorliving WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdWE = new SqlCommand(queryWE, conn))
                        {
                            cmdWE.Parameters.AddWithValue("@dathorliving", checkBox2.Checked ? "living" : "dead");
                            cmdWE.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdWE.ExecuteNonQuery();

                        }


                    }
                    if (checkBox1.Checked)
                    {
                        string queryTM = "UPDATE memberTM SET LivingorDead = @dathorliving WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdTM = new SqlCommand(queryTM, conn))
                        {
                            cmdTM.Parameters.AddWithValue("@dathorliving", checkBox1.Checked ? "dead" : "living" );
                            cmdTM.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdTM.ExecuteNonQuery();
                        }

                        string queryAM = "UPDATE memberAM SET LivingorDead = @dathorliving WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdAM = new SqlCommand(queryAM, conn))
                        {
                            cmdAM.Parameters.AddWithValue("@dathorliving", checkBox1.Checked ? "dead" : "living");
                            cmdAM.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdAM.ExecuteNonQuery();
                        }

                        string queryMF = "UPDATE memberMF SET LivingorDead = @dathorliving WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdMF = new SqlCommand(queryMF, conn))
                        {
                            cmdMF.Parameters.AddWithValue("@dathorliving", checkBox1.Checked ? "dead" : "living");
                            cmdMF.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdMF.ExecuteNonQuery();
                        }

                        string queryAC = "UPDATE memberAC SET LivingorDead = @dathorliving WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdAC = new SqlCommand(queryAC, conn))
                        {
                            cmdAC.Parameters.AddWithValue("@dathorliving", checkBox1.Checked ? "dead" : "living");
                            cmdAC.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdAC.ExecuteNonQuery();
                        }

                        string queryAE = "UPDATE memberAE SET LivingorDead = @dathorliving WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdAE = new SqlCommand(queryAE, conn))
                        {
                            cmdAE.Parameters.AddWithValue("@dathorliving", checkBox1.Checked ? "dead" : "living");
                            cmdAE.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdAE.ExecuteNonQuery();
                        }

                        string queryDM = "UPDATE memberDM SET LivingorDead = @dathorliving WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdDM = new SqlCommand(queryDM, conn))
                        {
                            cmdDM.Parameters.AddWithValue("@dathorliving", checkBox1.Checked ? "dead" : "living");
                            cmdDM.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdDM.ExecuteNonQuery();
                        }
                        string queryBRP = "UPDATE memberBRP SET LivingorDead = @dathorliving WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdBRP = new SqlCommand(queryBRP, conn))
                        {
                            cmdBRP.Parameters.AddWithValue("@dathorliving", checkBox1.Checked ? "dead" : "living");
                            cmdBRP.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdBRP.ExecuteNonQuery();
                        }
                        string queryIMT = "UPDATE memberIMT SET LivingorDead = @dathorliving WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdIMT = new SqlCommand(queryIMT, conn))
                        {
                            cmdIMT.Parameters.AddWithValue("@dathorliving", checkBox1.Checked ? "dead" : "living");
                            cmdIMT.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdIMT.ExecuteNonQuery();
                        }
                        string queryPE = "UPDATE memberPE SET LivingorDead = @dathorliving WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdPE = new SqlCommand(queryPE, conn))
                        {
                            cmdPE.Parameters.AddWithValue("@dathorliving", checkBox1.Checked ? "dead" : "living");
                            cmdPE.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdPE.ExecuteNonQuery();
                        }
                        string queryWE = "UPDATE memberWE SET LivingorDead = @dathorliving WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdWE = new SqlCommand(queryWE, conn))
                        {
                            cmdWE.Parameters.AddWithValue("@dathorliving", checkBox1.Checked ? "dead" : "living");
                            cmdWE.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdWE.ExecuteNonQuery();
                        }


                    }

                    // Update MemberName
                    if (!string.IsNullOrEmpty(nTxt.Text))
                    {
                        string queryTM = "UPDATE memberTM SET MemberName = @MemberName WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdTM = new SqlCommand(queryTM, conn))
                        {
                            cmdTM.Parameters.AddWithValue("@MemberName", nTxt.Text);
                            cmdTM.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdTM.ExecuteNonQuery();
                          
                    
                        }

                        string queryAM = "UPDATE memberAM SET MemberName = @MemberName WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdAM = new SqlCommand(queryAM, conn))
                        {
                            cmdAM.Parameters.AddWithValue("@MemberName", nTxt.Text);
                            cmdAM.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdAM.ExecuteNonQuery();
                          
                           
                        }
                        string queryMF = "UPDATE memberMF SET MemberName = @MemberName WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdMF = new SqlCommand(queryMF, conn))
                        {
                            cmdMF.Parameters.AddWithValue("@MemberName", nTxt.Text);
                            cmdMF.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdMF.ExecuteNonQuery();
                        

                        }
                        string queryAC = "UPDATE memberAC SET MemberName = @MemberName WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdAC = new SqlCommand(queryAC, conn))
                        {
                            cmdAC.Parameters.AddWithValue("@MemberName", nTxt.Text);
                            cmdAC.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdAC.ExecuteNonQuery();
                           

                        }
                        string queryAE = "UPDATE memberAE SET MemberName = @MemberName WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdAE = new SqlCommand(queryAE, conn))
                        {
                            cmdAE.Parameters.AddWithValue("@MemberName", nTxt.Text);
                            cmdAE.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdAE.ExecuteNonQuery();
                           

                        }
                        string queryDM = "UPDATE memberDM SET MemberName = @MemberName WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdDM = new SqlCommand(queryDM, conn))
                        {
                            cmdDM.Parameters.AddWithValue("@MemberName", nTxt.Text);
                            cmdDM.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdDM.ExecuteNonQuery();
                         

                        }
                        string queryBRP = "UPDATE memberBRP SET MemberName = @MemberName WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdBRP = new SqlCommand(queryBRP, conn))
                        {
                            cmdBRP.Parameters.AddWithValue("@MemberName", nTxt.Text);
                            cmdBRP.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdBRP.ExecuteNonQuery();
                    

                        }
                        string queryIMT = "UPDATE memberIMT SET MemberName = @MemberName WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdIMT = new SqlCommand(queryIMT, conn))
                        {
                            cmdIMT.Parameters.AddWithValue("@MemberName", nTxt.Text);
                            cmdIMT.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdIMT.ExecuteNonQuery();
              

                        }
                        string queryPE = "UPDATE memberPE SET MemberName = @MemberName WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdPE = new SqlCommand(queryPE, conn))
                        {
                            cmdPE.Parameters.AddWithValue("@MemberName", nTxt.Text);
                            cmdPE.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdPE.ExecuteNonQuery();
                         

                        }
                        string queryWE = "UPDATE memberWE SET MemberName = @MemberName WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdWE = new SqlCommand(queryWE, conn))
                        {
                            cmdWE.Parameters.AddWithValue("@MemberName", nTxt.Text);
                            cmdWE.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdWE.ExecuteNonQuery();
                            

                        }
                        MessageBox.Show("MemberName updated successfully");
                        nTxt.Clear();
                    }
                    // Update MemberYear
                    if (!string.IsNullOrEmpty(myTxt.Text))
                    {
                        string queryTM= "UPDATE memberTM SET Memberyear = @memberyear WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdTM = new SqlCommand(queryTM, conn))
                        {
                            cmdTM.Parameters.AddWithValue("@memberyear", myTxt.Text);
                            cmdTM.Parameters.AddWithValue("@Traningnumber",tnTxt.Text);
                            cmdTM.ExecuteNonQuery();
                            MessageBox.Show("Membership Year update successfully");
                            

                        }
                        string queryAM = "UPDATE MmemberAM SET Memberyear =@memberyear WHERE Traningnumber = @Traningnumber";
                        using (SqlCommand cmdAM = new SqlCommand(queryAM, conn))
                        {
                            cmdAM.Parameters.AddWithValue("@memberyear", myTxt.Text);
                            cmdAM.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                            cmdAM.ExecuteNonQuery();
                            MessageBox.Show("Membership Year update successfully");
                            

                        }
                        myTxt.Clear();
                    }

                    //Update Address
                  
                    if (!string.IsNullOrEmpty(addTxt.Text))
                    {
                        string[] tableNames = { "memberTM", "memberAM", "memberMF", "memberAC", "memberAE", "memberDM", "memberBRP", "memberIMT", "memberPE", "memberWE" };

                        try
                        {
                            foreach (var tableName in tableNames)
                            {
                                string query = $"UPDATE {tableName} SET Addrass = @Address WHERE Traningnumber = @Traningnumber";
                                using (SqlCommand cmd = new SqlCommand(query, conn))
                                {
                                    cmd.Parameters.AddWithValue("@Address", addTxt.Text);
                                    cmd.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                                    cmd.ExecuteNonQuery();
                                }
                            }

                            MessageBox.Show("Addrass updated successfully");
                            addTxt.Clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message);
                        }
                    }
                    // Update NIC
                    if (!string.IsNullOrEmpty(nicTxt.Text))
                    {
                        string[] tableNames = { "memberTM", "memberAM", "memberMF", "memberAC", "memberAE", "memberDM", "memberBRP", "memberIMT", "memberPE", "memberWE" };

                        try
                        {
                            foreach (var tableName in tableNames)
                            {
                                string query = $"UPDATE {tableName} SET Nic = @nic WHERE Traningnumber = @Traningnumber";
                                using (SqlCommand cmd = new SqlCommand(query, conn))
                                {
                                    cmd.Parameters.AddWithValue("@nic",nicTxt.Text);
                                    cmd.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                                    cmd.ExecuteNonQuery();
                                }
                            }

                            MessageBox.Show("NIC updated successfully");
                            nicTxt.Clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message);
                        }
                    }

                    //Update Membershipnumber Number
                    if (!string.IsNullOrEmpty(mnTxt.Text))
                    {
                        string[] tableNames = { "memberTM", "memberAM", "memberMF", "memberAC", "memberAE", "memberDM", "memberBRP", "memberIMT", "memberPE", "memberWE" };

                        try
                        {
                            foreach (var tableName in tableNames)
                            {
                                string query = $"UPDATE {tableName} SET Membershipnumber =@Membershipnumber WHERE Traningnumber = @Traningnumber";
                                using (SqlCommand cmd = new SqlCommand(query, conn))
                                {
                                    cmd.Parameters.AddWithValue("@Membershipnumber",mnTxt.Text);
                                    cmd.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                                    cmd.ExecuteNonQuery();
                                }
                            }

                            MessageBox.Show(" Membershipnumber Number updated successfully");
                            mnTxt.Clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message);
                        }
                    }

                    if (!string.IsNullOrEmpty(mTxt.Text))
                    {
                        string[] tableNames = { "memberTM", "memberAM", "memberMF", "memberAC", "memberAE", "memberDM", "memberBRP", "memberIMT", "memberPE", "memberWE" };

                        try
                        {
                            foreach (var tableName in tableNames)
                            {
                                string query = $"UPDATE {tableName} SET Mobile =@mobile WHERE Traningnumber = @Traningnumber";
                                using (SqlCommand cmd = new SqlCommand(query, conn))
                                {
                                    cmd.Parameters.AddWithValue("@mobile", mTxt.Text);
                                    cmd.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                                    cmd.ExecuteNonQuery();
                                }
                            }

                            MessageBox.Show("mobile number updated successfully");
                            mTxt.Clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message);
                        }
                    }


                    // Add more conditions for updating other columns here

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

            private void dBtn_Click(object sender, EventArgs e) { 
       

            string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\alumini.mdf;Integrated Security=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(cn))
                {
                    conn.Open();

                    // Delete from 'memberAM' table
                    string memberAMQuery = "DELETE FROM memberAM WHERE Traningnumber = @Traningnumber";

                    using (SqlCommand cmdAM = new SqlCommand(memberAMQuery, conn))
                    {
                        cmdAM.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                        cmdAM.ExecuteNonQuery();
                    }

                    // Delete from 'memberTM' table
                    string memberTMQuery = "DELETE FROM memberTM WHERE Traningnumber = @Traningnumber";

                    using (SqlCommand cmdTM = new SqlCommand(memberTMQuery, conn))
                    {
                        cmdTM.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                        cmdTM.ExecuteNonQuery();
                    }

                    string memberMFQuery = "DELETE FROM memberMF WHERE Traningnumber = @Traningnumber";

                    using (SqlCommand cmdMF = new SqlCommand(memberMFQuery, conn))
                    {
                        cmdMF.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                        cmdMF.ExecuteNonQuery();
                    }
                    string memberACQuery = "DELETE FROM memberAC WHERE Traningnumber = @Traningnumber";

                    using (SqlCommand cmdAC = new SqlCommand(memberACQuery, conn))
                    {
                        cmdAC.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                        cmdAC.ExecuteNonQuery();
                    }
                    string memberAEQuery = "DELETE FROM memberAE WHERE Traningnumber = @Traningnumber";

                    using (SqlCommand cmdAE = new SqlCommand(memberAEQuery, conn))
                    {
                        cmdAE.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                        cmdAE.ExecuteNonQuery();
                    }
                    string memberDMQuery = "DELETE FROM memberDM WHERE Traningnumber = @Traningnumber";

                    using (SqlCommand cmdDM = new SqlCommand(memberDMQuery, conn))
                    {
                        cmdDM.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                        cmdDM.ExecuteNonQuery();
                    }
                    string memberBRPQuery = "DELETE FROM memberBRP WHERE Traningnumber = @Traningnumber";

                    using (SqlCommand cmdBRP = new SqlCommand(memberBRPQuery, conn))
                    {
                        cmdBRP.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                        cmdBRP.ExecuteNonQuery();
                    }
                    string memberIMTQuery = "DELETE FROM memberIMT WHERE Traningnumber = @Traningnumber";

                    using (SqlCommand cmdIMT = new SqlCommand(memberIMTQuery, conn))
                    {
                        cmdIMT.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                        cmdIMT.ExecuteNonQuery();
                    }
                    string memberPEQuery = "DELETE FROM memberPE WHERE Traningnumber = @Traningnumber";

                    using (SqlCommand cmdPE = new SqlCommand(memberPEQuery, conn))
                    {
                        cmdPE.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                        cmdPE.ExecuteNonQuery();
                    }
                    string memberWEQuery = "DELETE FROM memberWE WHERE Traningnumber = @Traningnumber";

                    using (SqlCommand cmdWE = new SqlCommand(memberWEQuery, conn))
                    {
                        cmdWE.Parameters.AddWithValue("@Traningnumber", tnTxt.Text);
                        cmdWE.ExecuteNonQuery();
                    }

                    MessageBox.Show("Delete successful");

                    // Clear your form fields as needed
                    tnTxt.Clear();
                    myTxt.Clear();
                    mnTxt.Clear();
                    STxt.Clear();
                    nTxt.Clear();
                    addTxt.Clear();
                    mnTxt.Clear();
                    nicTxt.Clear();
                    mTxt.Clear();
                    comboBox1.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            try
            {
                {
                    string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\alumini.mdf;Integrated Security=True";
                    string sql = "SELECT * FROM memberAM UNION SELECT * FROM memberTM UNION SELECT * FROM memberMF UNION SELECT * FROM memberAC UNION SELECT * FROM memberAE UNION SELECT * FROM memberDM UNION SELECT * FROM memberBRP UNION SELECT * FROM memberIMT UNION SELECT * FROM memberPE UNION SELECT * FROM memberWE ORDER BY Memberyear DESC ";
                    SqlConnection conn = new SqlConnection(str);

                    da = new SqlDataAdapter(sql, conn);
                    ds = new DataSet();
                    conn.Open();
                    da.Fill(ds, scr_val, 30, "CombinedData"); 
                    conn.Close();
                    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
                    dataGridView1.DefaultCellStyle.Font =new Font("Arial", 10);
                    dataGridView1.DataSource = ds;
               
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                
                    dataGridView1.RowTemplate.Height = 35;

                 
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;


                    dataGridView1.DataMember = "CombinedData";

                    int m = dataGridView1.Rows.Count;
                    m = m - 1;
                    rowlbl.Text = m.ToString();



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            try
            {
                string searchdata = STxt.Text.Trim();

               
                if (string.IsNullOrEmpty(searchdata))
                {
                    MessageBox.Show("Please enter search criteria before pressing the search button.");
                    return;
                }

                string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\alumini.mdf;Integrated Security=True";

                using (SqlConnection con = new SqlConnection(cn))
                {
                    con.Open();

                    string query = "SELECT * FROM memberAM WHERE Traningnumber LIKE @Traningnumber OR MemberName LIKE @MemberName OR Addrass LIKE @Addrass OR Memberyear LIKE @Memberyear OR District LIKE @District " +
                                 "UNION " +
                                 "SELECT * FROM memberTM WHERE Traningnumber LIKE @Traningnumber OR MemberName LIKE @MemberName OR Addrass LIKE @Addrass OR Memberyear LIKE @Memberyear OR District LIKE @District " +
                                 "UNION " + 
                                  "SELECT * FROM memberMF WHERE Traningnumber LIKE @Traningnumber OR MemberName LIKE @MemberName OR Addrass LIKE @Addrass OR Memberyear LIKE @Memberyear OR District LIKE @District " +
                                 "UNION " +
                                  "SELECT * FROM memberAC WHERE Traningnumber LIKE @Traningnumber OR MemberName LIKE @MemberName OR Addrass LIKE @Addrass OR Memberyear LIKE @Memberyear OR District LIKE @District " +
                                 "UNION " +
                                  "SELECT * FROM memberAE WHERE Traningnumber LIKE @Traningnumber OR MemberName LIKE @MemberName OR Addrass LIKE @Addrass OR Memberyear LIKE @Memberyear OR District LIKE @District " +
                                 "UNION " +
                                  "SELECT * FROM memberBRP WHERE Traningnumber LIKE @Traningnumber OR MemberName LIKE @MemberName OR Addrass LIKE @Addrass OR Memberyear LIKE @Memberyear OR District LIKE @District " +
                                 "UNION " +
                                  "SELECT * FROM memberIMT WHERE Traningnumber LIKE @Traningnumber OR MemberName LIKE @MemberName OR Addrass LIKE @Addrass OR Memberyear LIKE @Memberyear OR District LIKE @District " +
                                 "UNION " +
                                  "SELECT * FROM memberPE WHERE Traningnumber LIKE @Traningnumber OR MemberName LIKE @MemberName OR Addrass LIKE @Addrass OR Memberyear LIKE @Memberyear OR District LIKE @District " +
                                 "UNION " +
                                  "SELECT * FROM memberWE WHERE Traningnumber LIKE @Traningnumber OR MemberName LIKE @MemberName OR Addrass LIKE @Addrass OR Memberyear LIKE @Memberyear OR District LIKE @District " +
                                 "UNION " +
                                 "SELECT * FROM memberDM WHERE Traningnumber LIKE @Traningnumber OR MemberName LIKE @MemberName OR Addrass LIKE @Addrass OR Memberyear LIKE @Memberyear OR District LIKE @District ";


                    using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@Traningnumber", "%" + searchdata + "%");
                        da.SelectCommand.Parameters.AddWithValue("@MemberName", "%" + searchdata + "%");
                        da.SelectCommand.Parameters.AddWithValue("@Addrass", "%" + searchdata + "%");
                        da.SelectCommand.Parameters.AddWithValue("@Memberyear", "%" + searchdata + "%");
                        da.SelectCommand.Parameters.AddWithValue("@District", "%" + searchdata + "%");
                        //da.SelectCommand.Parameters.AddWithValue("@Section", "%" + searchdata + "%");

                        DataTable searchData = new DataTable();
                        da.Fill(searchData);
                        dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
                        dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10);
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dataGridView1.RowTemplate.Height = 35;
                        dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                        dataGridView1.DataSource = searchData;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int totalRecords = 50000; 
                int pageSize = 30;       

                if (scr_val > 0)
                {
                    scr_val = Math.Max(0, scr_val - pageSize); 
                }

                ds.Clear();
                da.Fill(ds, scr_val, pageSize, "CombinedData");

                int currentPage = (scr_val / pageSize) + 1;
                int totalPages = (totalRecords / pageSize) + (totalRecords % pageSize == 0 ? 0 : 1);
                pagelbl.Text = "Page " + currentPage;//+ " of " + totalPages;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int totalRecords = 50000;

                if (scr_val < 0)
                {
                    scr_val = 0;
                }
                else if (scr_val >= totalRecords)
                {
                    scr_val = totalRecords - 1;
                }

                int pageSize = 30;

                if (scr_val + pageSize < totalRecords)
                {
                    scr_val = scr_val + 30;
                }
                else
                {
                    scr_val = totalRecords - pageSize;
                }

                ds.Clear();
                da.Fill(ds, scr_val, pageSize, "CombinedData");

                int currentPage = (scr_val / pageSize) + 1;
                pagelbl.Text = "Page " + currentPage;//+ " of " + (totalRecords / pageSize + (totalRecords % pageSize == 0 ? 0 : 1));
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }


        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tnTxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void myTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tnTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                myTxt.Focus();
            }
        }

        private void nTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                distxt.Focus();
            }
        }

        private void distxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mnTxt.Focus();
            }
        }

        private void mnTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               addTxt.Focus();
            }
        }

        private void addTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mTxt.Focus();
            }
        }

        private void mTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nicTxt.Focus();
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nTxt.Focus();
            }

        }

        private void myTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBox1.Focus();
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

        private void sBtn_KeyDown(object sender, KeyEventArgs e)
        {
      
        }

        private void STxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnS.Focus();

            }

        }
    }
}
