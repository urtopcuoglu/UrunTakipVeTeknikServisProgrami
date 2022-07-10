namespace TEKNİKSERVİS.Formlar
{
    partial class FrmUrunListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunListesi));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnTEMIZLE = new DevExpress.XtraEditors.SimpleButton();
            this.btnListele = new DevExpress.XtraEditors.SimpleButton();
            this.btnGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.txtStok = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtSatisFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtAlisFiyati = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtMarka = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtUrunAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStok.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisFiyati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(-4, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1537, 985);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(247)))), ((int)(((byte)(172)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(188)))), ((int)(((byte)(77)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.btnTEMIZLE);
            this.groupControl1.Controls.Add(this.btnListele);
            this.groupControl1.Controls.Add(this.btnGüncelle);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.lookUpEdit1);
            this.groupControl1.Controls.Add(this.txtStok);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtSatisFiyat);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtAlisFiyati);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtMarka);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtUrunAd);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1539, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(405, 1068);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "ÜRÜN İŞLEMLERİ";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(109, 76);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(264, 22);
            this.txtID.TabIndex = 20;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(36, 77);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(64, 19);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "ÜRÜN ID :";
            // 
            // btnTEMIZLE
            // 
            this.btnTEMIZLE.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTEMIZLE.ImageOptions.Image")));
            this.btnTEMIZLE.Location = new System.Drawing.Point(109, 482);
            this.btnTEMIZLE.Name = "btnTEMIZLE";
            this.btnTEMIZLE.Size = new System.Drawing.Size(161, 41);
            this.btnTEMIZLE.TabIndex = 18;
            this.btnTEMIZLE.Text = "TEMİZLE";
            this.btnTEMIZLE.Click += new System.EventHandler(this.btnTEMIZLE_Click);
            // 
            // btnListele
            // 
            this.btnListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnListele.ImageOptions.Image")));
            this.btnListele.Location = new System.Drawing.Point(109, 435);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(161, 41);
            this.btnListele.TabIndex = 17;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGüncelle.ImageOptions.Image")));
            this.btnGüncelle.Location = new System.Drawing.Point(109, 388);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(161, 41);
            this.btnGüncelle.TabIndex = 16;
            this.btnGüncelle.Text = "GÜNCELLE";
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(109, 341);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(161, 41);
            this.simpleButton2.TabIndex = 15;
            this.simpleButton2.Text = "SİLME";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(109, 294);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(161, 41);
            this.BtnKaydet.TabIndex = 12;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(32, 249);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(71, 19);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "KATEGORI :";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(109, 248);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.DisplayMember = "AD";
            this.lookUpEdit1.Properties.ValueMember = "ID";
            this.lookUpEdit1.Size = new System.Drawing.Size(264, 22);
            this.lookUpEdit1.TabIndex = 10;
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(109, 219);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(264, 22);
            this.txtStok.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(54, 216);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 19);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "STOK : ";
            // 
            // txtSatisFiyat
            // 
            this.txtSatisFiyat.Location = new System.Drawing.Point(109, 191);
            this.txtSatisFiyat.Name = "txtSatisFiyat";
            this.txtSatisFiyat.Size = new System.Drawing.Size(264, 22);
            this.txtSatisFiyat.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 191);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(86, 19);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "SATIŞ FİYATI :";
            // 
            // txtAlisFiyati
            // 
            this.txtAlisFiyati.Location = new System.Drawing.Point(109, 163);
            this.txtAlisFiyati.Name = "txtAlisFiyati";
            this.txtAlisFiyati.Size = new System.Drawing.Size(264, 22);
            this.txtAlisFiyati.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(22, 163);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(78, 19);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "ALIŞ FİYATI :";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(109, 132);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(264, 22);
            this.txtMarka.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(45, 135);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 19);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "MARKA : ";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(109, 104);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(264, 22);
            this.txtUrunAd.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(27, 105);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ÜRÜN ADI :";
            // 
            // FrmUrunListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmUrunListesi";
            this.Text = "FrmUrunListesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmUrunListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStok.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisFiyati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAd.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtUrunAd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtAlisFiyati;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtMarka;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtStok;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtSatisFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.SimpleButton btnGüncelle;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnListele;
        private DevExpress.XtraEditors.SimpleButton btnTEMIZLE;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}