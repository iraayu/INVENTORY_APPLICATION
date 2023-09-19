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
    public partial class barangmasukform : Form
    {
        public barangmasukform()
        {
            InitializeComponent();
        }
        //Connection String
        string ira = @"Data Source=DESKTOP-B6U6OVN\SQLEXPRESS;Initial Catalog=Ira;Integrated Security=True;";

        private void button1_Click(object sender, EventArgs e)
        {
             {
                 if (txtbarang.Text == "" || txttanggal.Text == "" || txtid.Text == "" || txtsurat.Text == "" || txttanggalsj.Text == "" || txtmobil.Text == "" || txttotal.Text == "")
                {
                    MessageBox.Show("isi semua data!!!");
                    return;
                }
                try
                {
                    //Create SqlConnection
                    SqlConnection con = new SqlConnection(ira);
                    SqlCommand cmd = new SqlCommand("Select * from Barang_Masuk where No Barang Masuk=@No_Barang_Masuk and tanggal=@Tanggal and id=@Id_Supplier and surat=@No_Surat_Jalan and tanggalsj=@Tanggal_SJ and mobil=@No_Mobil and total=@Total_Harga", con);
                    cmd.Parameters.AddWithValue("@No_Barang_Masuk", txtbarang.Text);
                    cmd.Parameters.AddWithValue("@Tanggal", txttanggal.Text);
                    cmd.Parameters.AddWithValue("@Id_Supplier", txtid.Text);
                    cmd.Parameters.AddWithValue("@No_Surat_Jalan", txtsurat.Text);
                    cmd.Parameters.AddWithValue("@Tanggal_SJ", txttanggalsj.Text);
                    cmd.Parameters.AddWithValue("@No_Mobil", txtmobil.Text);
                    cmd.Parameters.AddWithValue("@Total_Harga", txttotal.Text);
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
            txtbarang.Clear();
            txttanggal.Clear();
            txtid.Clear();
            txtsurat.Clear();
            txttanggalsj.Clear();
            txtmobil.Clear();
            txttotal.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

       

       
      

       
    }
}
