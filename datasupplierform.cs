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
    public partial class datasupplierform : Form
    {
        public datasupplierform()
        {
            InitializeComponent();
        }
        //Connection String
        string ira = @"Data Source=DESKTOP-B6U6OVN\SQLEXPRESS;Initial Catalog=Ira;Integrated Security=True;";
        private void btnsimpan_Click(object sender, EventArgs e)
        {
            {
                if (txtId.Text == "" || txtAlamat.Text == "" || txtkontak.Text == "" || txtnama.Text == "" || txttelepon.Text == "" || txtsaldo.Text == "" || txtjenis.Text == "")
                {
                    MessageBox.Show("isi semua data!!!");
                    return;
                }
                try
                {
                    //Create SqlConnection
                    SqlConnection con = new SqlConnection(ira);
                    SqlCommand cmd = new SqlCommand("Select * from Customer where id=@Id_Customer and Alamat=@Alamat and Kontak=@Kontak_Person and Nama=@Nama_Customer and Telepon=@Telepon and Saldo=@Saldo_Utang and Jenis=@Jenis", con);
                    cmd.Parameters.AddWithValue("@Id_Customer", txtId.Text);
                    cmd.Parameters.AddWithValue("@Alamat", txtAlamat.Text);
                    cmd.Parameters.AddWithValue("@Kontak_Person", txtkontak.Text);
                    cmd.Parameters.AddWithValue("@Nama_Customer", txtnama.Text);
                    cmd.Parameters.AddWithValue("@Telepon", txttelepon.Text);
                    cmd.Parameters.AddWithValue("@Saldo_Utang", txtsaldo.Text);
                    cmd.Parameters.AddWithValue("@Jenis", txtjenis.Text);
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

        private void btnback_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtnama.Clear();
            txtAlamat.Clear();
            txttelepon.Clear();
            txtkontak.Clear();
            txtsaldo.Clear();
            txtjenis.Clear();
        }
    }
}
        
