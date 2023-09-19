namespace PrjIraAyuRiyanto
{
    partial class pengelolaform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtjabatan = new System.Windows.Forms.TextBox();
            this.txtroles = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id_Pengelola";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama_User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jabatan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Roles";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(111, 24);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(304, 20);
            this.txtid.TabIndex = 5;
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(111, 71);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(304, 20);
            this.txtnama.TabIndex = 6;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(111, 121);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(304, 20);
            this.txtpass.TabIndex = 7;
            // 
            // txtjabatan
            // 
            this.txtjabatan.Location = new System.Drawing.Point(111, 174);
            this.txtjabatan.Name = "txtjabatan";
            this.txtjabatan.Size = new System.Drawing.Size(304, 20);
            this.txtjabatan.TabIndex = 8;
            // 
            // txtroles
            // 
            this.txtroles.Location = new System.Drawing.Point(111, 231);
            this.txtroles.Name = "txtroles";
            this.txtroles.Size = new System.Drawing.Size(304, 20);
            this.txtroles.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsimpan);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnback);
            this.groupBox1.Location = new System.Drawing.Point(12, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 117);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "pengelola";
            // 
            // btnsimpan
            // 
            this.btnsimpan.Location = new System.Drawing.Point(99, 43);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(86, 38);
            this.btnsimpan.TabIndex = 13;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = true;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 38);
            this.button1.TabIndex = 17;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(692, 43);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(86, 38);
            this.btnback.TabIndex = 18;
            this.btnback.Text = "Tutup";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // pengelolaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 403);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtroles);
            this.Controls.Add(this.txtjabatan);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "pengelolaform";
            this.Text = "pengelolaform";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtjabatan;
        private System.Windows.Forms.TextBox txtroles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnback;
    }
}