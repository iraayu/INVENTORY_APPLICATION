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
    public partial class pengeluaranbarangform : Form
    {
        public pengeluaranbarangform()
        {
            InitializeComponent();
        }
        //Connection String
        string ira = @"Data Source=DESKTOP-B6U6OVN\SQLEXPRESS;Initial Catalog=Ira;Integrated Security=True;";

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
                {
                    MessageBox.Show("isi semua data!!!");
                    return;
                }
                try
                {
                    //Create SqlConnection
                    SqlConnection con = new SqlConnection(ira);
                    SqlCommand cmd = new SqlCommand("Select * from pengeluaranbarangform where No Barang Keluar=@No_Barang_Keluar and tanggal=@Tanggal and id=@Id_Customer and pemesanan=@No_Pemesanan and pesan=@Tanggal_Pesan", con);
                    cmd.Parameters.AddWithValue("@No_Barang_Keluar", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Tanggal", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Id_Customer", textBox3.Text);
                    cmd.Parameters.AddWithValue("@No_Pemesanan", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Tanggal_Pesan", textBox5.Text);
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }




    }
}
