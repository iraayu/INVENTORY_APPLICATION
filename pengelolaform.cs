using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PrjIraAyuRiyanto
{
    public partial class pengelolaform : Form
    {
        public pengelolaform()
        {
            InitializeComponent();
        }
        //Connection String
        string ira = @"Data Source=DESKTOP-B6U6OVN\SQLEXPRESS;Initial Catalog=Ira;Integrated Security=True;";

        private void btnback_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtnama.Clear();
            txtpass.Clear();
            txtjabatan.Clear();
            txtroles.Clear();
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            {
                if (txtid.Text == "" || txtnama.Text == "" || txtpass.Text == "" || txtjabatan.Text == "" || txtroles.Text == "")
                {
                    MessageBox.Show("isi semua data!!!");
                    return;
                }
                try
                {
                    //Create SqlConnection
                    SqlConnection con = new SqlConnection(ira);
                    SqlCommand cmd = new SqlCommand("Select * from Pengelola where id=@Id_Pengelola and nama=@Nama_User and Password=@Password and Jabatan=@Jabatan and Roles=@Roles", con);
                    cmd.Parameters.AddWithValue("@Id_Pengelola", txtid.Text);
                    cmd.Parameters.AddWithValue("@Nama_User", txtnama.Text);
                    cmd.Parameters.AddWithValue("@Password", txtpass.Text);
                    cmd.Parameters.AddWithValue("@Jabatan", txtjabatan.Text);
                    cmd.Parameters.AddWithValue("@Roles", txtroles.Text);
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    con.Close();
                    int count = ds.Tables[0].Rows.Count;
                    //If count is equal to 1, than show frmMain form
                    if (count == 1)
                    {
                        MessageBox.Show("data disimpan!");
                        this.Hide();
                        Form1 fm = new Form1();
                        fm.Show();
                    }
                    else
                    {
                        MessageBox.Show("data tidak tersimpan");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

      

      

      
      
    }
}
