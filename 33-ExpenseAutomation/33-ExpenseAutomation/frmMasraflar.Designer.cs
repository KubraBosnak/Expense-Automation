
namespace _33_ExpenseAutomation
{
    partial class frmMasraflar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasraflar));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFisNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.nudTutar = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMasrafTipi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEkle = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnKaydet = new System.Windows.Forms.ToolStripButton();
            this.btnSil = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clmSahibi = new System.Windows.Forms.ColumnHeader();
            this.clmMasrafTipi = new System.Windows.Forms.ColumnHeader();
            this.clmTarih = new System.Windows.Forms.ColumnHeader();
            this.clmFisNo = new System.Windows.Forms.ColumnHeader();
            this.clmTutar = new System.Windows.Forms.ColumnHeader();
            this.clmDurumu = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuOnayBekliyor = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuOnaylandi = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuReddedildi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmnuOdendi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTutar)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(10, 10);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(705, 403);
            this.splitContainer1.SplitterDistance = 282;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 403);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Masraf Ekle / Düzenle / Sil";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.txtFisNo);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.dtpTarih);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.nudTutar);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.cmbMasrafTipi);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.txtAciklama);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 44);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(276, 305);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fiş No";
            // 
            // txtFisNo
            // 
            this.txtFisNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFisNo.Location = new System.Drawing.Point(3, 22);
            this.txtFisNo.Name = "txtFisNo";
            this.txtFisNo.Size = new System.Drawing.Size(270, 23);
            this.txtFisNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label2.Size = new System.Drawing.Size(100, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tarih";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(3, 78);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(270, 23);
            this.dtpTarih.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(3, 104);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label3.Size = new System.Drawing.Size(100, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tutar";
            // 
            // nudTutar
            // 
            this.nudTutar.DecimalPlaces = 2;
            this.nudTutar.Location = new System.Drawing.Point(3, 134);
            this.nudTutar.Name = "nudTutar";
            this.nudTutar.Size = new System.Drawing.Size(270, 23);
            this.nudTutar.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(3, 160);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label4.Size = new System.Drawing.Size(100, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Masraf Tipi";
            // 
            // cmbMasrafTipi
            // 
            this.cmbMasrafTipi.FormattingEnabled = true;
            this.cmbMasrafTipi.Location = new System.Drawing.Point(3, 190);
            this.cmbMasrafTipi.Name = "cmbMasrafTipi";
            this.cmbMasrafTipi.Size = new System.Drawing.Size(270, 23);
            this.cmbMasrafTipi.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(3, 216);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label5.Size = new System.Drawing.Size(100, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Açıklama";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAciklama.Location = new System.Drawing.Point(3, 246);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAciklama.Size = new System.Drawing.Size(270, 53);
            this.txtAciklama.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnEkle);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 349);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(276, 51);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.Location = new System.Drawing.Point(162, 3);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(111, 45);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnKaydet,
            this.btnSil});
            this.toolStrip1.Location = new System.Drawing.Point(3, 19);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(276, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnKaydet
            // 
            this.btnKaydet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(23, 22);
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(23, 22);
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.toolStrip2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 403);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Masraflar";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmSahibi,
            this.clmMasrafTipi,
            this.clmTarih,
            this.clmFisNo,
            this.clmTutar,
            this.clmDurumu});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 44);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(413, 356);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // clmSahibi
            // 
            this.clmSahibi.Text = "Sahibi";
            // 
            // clmMasrafTipi
            // 
            this.clmMasrafTipi.Text = "Masraf Tipi";
            this.clmMasrafTipi.Width = 80;
            // 
            // clmTarih
            // 
            this.clmTarih.Text = "Tarih";
            // 
            // clmFisNo
            // 
            this.clmFisNo.Text = "Fiş No";
            // 
            // clmTutar
            // 
            this.clmTutar.Text = "Tutar";
            // 
            // clmDurumu
            // 
            this.clmDurumu.Text = "Durumu";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuOnayBekliyor,
            this.cmnuOnaylandi,
            this.cmnuReddedildi,
            this.toolStripMenuItem1,
            this.cmnuOdendi});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 120);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // cmnuOnayBekliyor
            // 
            this.cmnuOnayBekliyor.Name = "cmnuOnayBekliyor";
            this.cmnuOnayBekliyor.Size = new System.Drawing.Size(180, 22);
            this.cmnuOnayBekliyor.Text = "Onay Bekliyor";
            this.cmnuOnayBekliyor.Click += new System.EventHandler(this.cmnuOnayBekliyor_Click);
            // 
            // cmnuOnaylandi
            // 
            this.cmnuOnaylandi.Name = "cmnuOnaylandi";
            this.cmnuOnaylandi.Size = new System.Drawing.Size(180, 22);
            this.cmnuOnaylandi.Text = "Onaylandı";
            this.cmnuOnaylandi.Click += new System.EventHandler(this.cmnuOnaylandi_Click);
            // 
            // cmnuReddedildi
            // 
            this.cmnuReddedildi.Name = "cmnuReddedildi";
            this.cmnuReddedildi.Size = new System.Drawing.Size(180, 22);
            this.cmnuReddedildi.Text = "Reddedildi";
            this.cmnuReddedildi.Click += new System.EventHandler(this.cmnuReddedildi_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // cmnuOdendi
            // 
            this.cmnuOdendi.Name = "cmnuOdendi";
            this.cmnuOdendi.Size = new System.Drawing.Size(180, 22);
            this.cmnuOdendi.Text = "Ödendi";
            this.cmnuOdendi.Click += new System.EventHandler(this.cmnuOdendi_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Location = new System.Drawing.Point(3, 19);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(413, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // frmMasraflar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 423);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMasraflar";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Masraflar";
            this.Load += new System.EventHandler(this.frmMasraflar_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTutar)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFisNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnKaydet;
        private System.Windows.Forms.ToolStripButton btnSil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudTutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMasrafTipi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clmSahibi;
        private System.Windows.Forms.ColumnHeader clmTarih;
        private System.Windows.Forms.ColumnHeader clmFisNo;
        private System.Windows.Forms.ColumnHeader clmTutar;
        private System.Windows.Forms.ColumnHeader clmMasrafTipi;
        private System.Windows.Forms.ColumnHeader clmDurumu;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmnuOnayBekliyor;
        private System.Windows.Forms.ToolStripMenuItem cmnuOnaylandi;
        private System.Windows.Forms.ToolStripMenuItem cmnuReddedildi;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cmnuOdendi;
    }
}