using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrjIraAyuRiyanto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void managePengelolaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda Yakin Ingin Keluar?", "confirm",
                MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }


        private void loginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            loginform rto = new loginform();
            rto.ShowDialog(); rto.Focus();
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            databarangform rto = new databarangform();
            rto.ShowDialog(); rto.Focus();
        }

        private void costumerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CostumerForm rto = new CostumerForm();
            rto.ShowDialog(); rto.Focus();
        }

        private void printSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintForm p = new PrintForm();
            p.ShowDialog();
            p.Focus();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datasupplierform rto = new datasupplierform();
            rto.ShowDialog(); rto.Focus();
        }

        private void pemasukanBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barangmasukform rto = new barangmasukform();
            rto.ShowDialog(); rto.Focus();
        }

        private void managerPengelolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pengelolaform rto = new pengelolaform();
            rto.ShowDialog(); rto.Focus();
        }

        private void pengeluaranBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pengeluaranbarangform rto = new pengeluaranbarangform();
            rto.ShowDialog(); rto.Focus();
        }

        private void laporanBarangMasukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            laporanbarangmasukform rto = new laporanbarangmasukform();
            rto.ShowDialog(); rto.Focus();
        }

        private void laporanStockOpnameBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stockopnameform rto = new stockopnameform();
            rto.ShowDialog(); rto.Focus();
        }

    }
}
