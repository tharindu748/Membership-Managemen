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
    public partial class All_members : Form
    {
        public All_members()
        {
            InitializeComponent();
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
        int scr_val=0;
        SqlDataAdapter da;
        DataSet ds;
        private void btnS_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\tlakm\Videos\vs\ict project\alumini association\alumini association\alumini.mdf"";Integrated Security=True";
                    string sql = "SELECT * FROM memberAM UNION SELECT * FROM memberTM UNION SELECT * FROM memberMF UNION SELECT * FROM memberAC UNION SELECT * FROM memberAE UNION SELECT * FROM memberDM UNION SELECT * FROM memberBRP UNION SELECT * FROM memberIMT UNION SELECT * FROM memberPE UNION SELECT * FROM memberWE ORDER BY Memberyear DESC ";
                    SqlConnection conn = new SqlConnection(str);

                    da = new SqlDataAdapter(sql, conn);
                    ds = new DataSet();
                    conn.Open();
                    da.Fill(ds, scr_val, 30, "CombinedData"); // Use a more generic name like "CombinedData" instead of "memberAM"
                    conn.Close();
                    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                    dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10);
                    dataGridView1.DataSource = ds;
                    // dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    // Assuming you have a DataGridView named dataGridView1
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    // Set the row height to 150 pixels
                    dataGridView1.RowTemplate.Height = 35;

                    // Set the AutoSizeRowsMode to None to prevent automatic resizing
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;


                    dataGridView1.DataMember = "CombinedData";

                    int m = dataGridView1.Rows.Count;
                    m = m - 1;
                    ROWlbl.Text = m.ToString();



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            try
            {
                int totalRecords = 50000; // Assuming total records is 100
                int pageSize = 30;       // Assuming page size is 5

                if (scr_val > 0)
                {
                    scr_val = Math.Max(0, scr_val - pageSize); // Ensure scr_val is not less than 0
                }

                ds.Clear();
                da.Fill(ds, scr_val, pageSize, "CombinedData");

                int currentPage = (scr_val / pageSize) + 1;
                int totalPages = (totalRecords / pageSize) + (totalRecords % pageSize == 0 ? 0 : 1);
               PAGElbl.Text = "Page " + currentPage + " of " + totalPages;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void previosbutton_Click(object sender, EventArgs e)
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

                int pageSize = 30 ;

                if (scr_val + pageSize < totalRecords)
                {
                    scr_val = scr_val + 5;
                }
                else
                {
                    scr_val = totalRecords - pageSize;
                }

                ds.Clear();
                da.Fill(ds, scr_val, pageSize, "CombinedData");

                int currentPage = (scr_val / pageSize) + 1;
               PAGElbl.Text = "Page " + currentPage + " of " + (totalRecords / pageSize + (totalRecords % pageSize == 0 ? 0 : 1));
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Sbtn_Click(object sender, EventArgs e)
        {

            try
            {
                string searchdata = STxt.Text.Trim();


                if (string.IsNullOrEmpty(searchdata))
                {
                    MessageBox.Show("Please enter search criteria before pressing the search button.");
                    return;
                }

                string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\tlakm\Videos\vs\ict project\alumini association\alumini association\alumini.mdf"";Integrated Security=True";

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
                        dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
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

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Members_registration obj=new Members_registration();
            obj.Show();
            this.Close();

        }

        private void label28_Click_1(object sender, EventArgs e)
        {
            Members_registration obj = new Members_registration();
            obj.Show();
            this.Close();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Admin_registration obj = new Admin_registration();
            obj.Show();
            this.Close();
        }

        private void label30_Click_1(object sender, EventArgs e)
        {
            Admin_registration obj = new Admin_registration();
            obj.Show();
            this.Close();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            main_window obj = new main_window();
            obj.Show();
            this.Close();
        }

        private void label31_Click_1(object sender, EventArgs e)
        {
            main_window obj = new main_window();
            obj.Show();
            this.Close();
        }
    }
    
}
