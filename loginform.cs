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
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }
        //Connection String
        string ira = @"Data Source=DESKTOP-B6U6OVN\SQLEXPRESS;Initial Catalog=Ira;Integrated Security=True;";



        private void button2_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
              {
                if (txt_user.Text == "" || txt_pass.Text == "")
                {
                    MessageBox.Show("Please provide UserName and Password");
                    return;
                }
                try
                {
                    //Create SqlConnection
                    SqlConnection con = new SqlConnection(ira);
                    SqlCommand cmd = new SqlCommand("Select * from Login where UserName=@username and Password=@password", con);
                    cmd.Parameters.AddWithValue("@username", txt_user.Text);
                    cmd.Parameters.AddWithValue("@password", txt_pass.Text);
                    con.Open();
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    con.Close();
                    int count = ds.Tables[0].Rows.Count;
                    //If count is equal to 1, than show frmMain form
                    if (count == 1)
                    {
                        MessageBox.Show("Selamat Datang");
                        this.Hide();
                        Form1 fm = new Form1();
                        fm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed!");
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

