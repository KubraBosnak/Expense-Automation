
namespace _33_ExpenseAutomation
{
    partial class frmKullaniciYonetimi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciYonetimi));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstKullanicilar = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSil = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExceleAktar = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTamAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbYonetici = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flplabels = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTamadi = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblTipi = new System.Windows.Forms.Label();
            this.lblYoneticisi = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flplabels.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(8);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(8);
            this.splitContainer1.Size = new System.Drawing.Size(710, 460);
            this.splitContainer1.SplitterDistance = 403;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstKullanicilar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 444);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcılar";
            // 
            // lstKullanicilar
            // 
            this.lstKullanicilar.ContextMenuStrip = this.contextMenuStrip1;
            this.lstKullanicilar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstKullanicilar.FormattingEnabled = true;
            this.lstKullanicilar.ItemHeight = 15;
            this.lstKullanicilar.Location = new System.Drawing.Point(3, 19);
            this.lstKullanicilar.Name = "lstKullanicilar";
            this.lstKullanicilar.Size = new System.Drawing.Size(381, 422);
            this.lstKullanicilar.TabIndex = 0;
            this.lstKullanicilar.SelectedIndexChanged += new System.EventHandler(this.lstKullanicilar_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKaydet,
            this.mnuSil,
            this.toolStripMenuItem1,
            this.mnuExceleAktar});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 76);
            // 
            // mnuKaydet
            // 
            this.mnuKaydet.Name = "mnuKaydet";
            this.mnuKaydet.Size = new System.Drawing.Size(141, 22);
            this.mnuKaydet.Text = "Kaydet";
            this.mnuKaydet.Click += new System.EventHandler(this.mnuKaydet_Click);
            // 
            // mnuSil
            // 
            this.mnuSil.Name = "mnuSil";
            this.mnuSil.Size = new System.Drawing.Size(141, 22);
            this.mnuSil.Text = "Sil";
            this.mnuSil.Click += new System.EventHandler(this.mnuSil_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(138, 6);
            // 
            // mnuExceleAktar
            // 
            this.mnuExceleAktar.Name = "mnuExceleAktar";
            this.mnuExceleAktar.Size = new System.Drawing.Size(141, 22);
            this.mnuExceleAktar.Text = "Excel\'e Aktar";
            this.mnuExceleAktar.Click += new System.EventHandler(this.mnuExceleAktar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flowLayoutPanel2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(8, 8);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(287, 302);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kullanıcı Ekle / Güncelle / Sil";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.txtTamAdi);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.txtKullaniciAdi);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.txtSifre);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.cmbTipi);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.cmbYonetici);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(281, 280);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tam Adı";
            // 
            // txtTamAdi
            // 
            this.txtTamAdi.Location = new System.Drawing.Point(3, 18);
            this.txtTamAdi.Name = "txtTamAdi";
            this.txtTamAdi.Size = new System.Drawing.Size(277, 23);
            this.txtTamAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(3, 62);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(277, 23);
            this.txtKullaniciAdi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şifre";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(3, 106);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(277, 23);
            this.txtSifre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipi";
            // 
            // cmbTipi
            // 
            this.cmbTipi.DisplayMember = "Name";
            this.cmbTipi.FormattingEnabled = true;
            this.cmbTipi.Location = new System.Drawing.Point(3, 150);
            this.cmbTipi.Name = "cmbTipi";
            this.cmbTipi.Size = new System.Drawing.Size(277, 23);
            this.cmbTipi.TabIndex = 7;
            this.cmbTipi.ValueMember = "Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Yönetici";
            // 
            // cmbYonetici
            // 
            this.cmbYonetici.FormattingEnabled = true;
            this.cmbYonetici.Location = new System.Drawing.Point(3, 194);
            this.cmbYonetici.Name = "cmbYonetici";
            this.cmbYonetici.Size = new System.Drawing.Size(277, 23);
            this.cmbYonetici.TabIndex = 9;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnSil);
            this.flowLayoutPanel3.Controls.Add(this.btnKaydet);
            this.flowLayoutPanel3.Controls.Add(this.btnEkle);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 223);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(277, 51);
            this.flowLayoutPanel3.TabIndex = 10;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(189, 3);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(85, 40);
            this.btnSil.TabIndex = 0;
            this.btnSil.TabStop = false;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(98, 3);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(85, 40);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.TabStop = false;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(7, 3);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(85, 40);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.TabStop = false;
            this.btnEkle.Text = "Yeni";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flplabels);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(8, 310);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 142);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullanıcı Detay";
            // 
            // flplabels
            // 
            this.flplabels.Controls.Add(this.lblTamadi);
            this.flplabels.Controls.Add(this.lblKullaniciAdi);
            this.flplabels.Controls.Add(this.lblSifre);
            this.flplabels.Controls.Add(this.lblTipi);
            this.flplabels.Controls.Add(this.lblYoneticisi);
            this.flplabels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flplabels.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flplabels.Location = new System.Drawing.Point(3, 19);
            this.flplabels.Name = "flplabels";
            this.flplabels.Size = new System.Drawing.Size(281, 120);
            this.flplabels.TabIndex = 0;
            // 
            // lblTamadi
            // 
            this.lblTamadi.AutoSize = true;
            this.lblTamadi.Location = new System.Drawing.Point(3, 0);
            this.lblTamadi.Name = "lblTamadi";
            this.lblTamadi.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.lblTamadi.Size = new System.Drawing.Size(38, 27);
            this.lblTamadi.TabIndex = 0;
            this.lblTamadi.Text = "label1";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(3, 27);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.lblKullaniciAdi.Size = new System.Drawing.Size(38, 21);
            this.lblKullaniciAdi.TabIndex = 1;
            this.lblKullaniciAdi.Text = "label2";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(3, 48);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.lblSifre.Size = new System.Drawing.Size(38, 21);
            this.lblSifre.TabIndex = 2;
            this.lblSifre.Text = "label3";
            // 
            // lblTipi
            // 
            this.lblTipi.AutoSize = true;
            this.lblTipi.Location = new System.Drawing.Point(3, 69);
            this.lblTipi.Name = "lblTipi";
            this.lblTipi.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.lblTipi.Size = new System.Drawing.Size(38, 21);
            this.lblTipi.TabIndex = 3;
            this.lblTipi.Text = "label4";
            // 
            // lblYoneticisi
            // 
            this.lblYoneticisi.AutoSize = true;
            this.lblYoneticisi.Location = new System.Drawing.Point(3, 90);
            this.lblYoneticisi.Name = "lblYoneticisi";
            this.lblYoneticisi.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.lblYoneticisi.Size = new System.Drawing.Size(38, 21);
            this.lblYoneticisi.TabIndex = 4;
            this.lblYoneticisi.Text = "label5";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Excel\'e aktarım işlemi tamamlandı.";
            this.notifyIcon1.BalloonTipTitle = "Aktarım Tamamlandı";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // frmKullaniciYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 460);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmKullaniciYonetimi";
            this.Text = "Kullanıcı Yönetimi";
            this.Load += new System.EventHandler(this.frmKullaniciYonetimi_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.flplabels.ResumeLayout(false);
            this.flplabels.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstKullanicilar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTamAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbYonetici;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flplabels;
        private System.Windows.Forms.Label lblTamadi;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblTipi;
        private System.Windows.Forms.Label lblYoneticisi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuKaydet;
        private System.Windows.Forms.ToolStripMenuItem mnuSil;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuExceleAktar;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}