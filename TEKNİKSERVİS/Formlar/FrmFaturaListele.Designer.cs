namespace TEKNİKSERVİS.Formlar
{
    partial class FrmFaturaListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaListele));
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lueCari = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lueMüsteri = new DevExpress.XtraEditors.LookUpEdit();
            this.txtVergiDairesi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSaat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTarih = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSıraNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDepID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnListele = new DevExpress.XtraEditors.SimpleButton();
            this.btnGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtSeri = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueCari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMüsteri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSaat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSıraNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.lueCari);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.lueMüsteri);
            this.groupControl1.Controls.Add(this.txtVergiDairesi);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.TxtSaat);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtTarih);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtSıraNo);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtDepID);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.btnListele);
            this.groupControl1.Controls.Add(this.btnGüncelle);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.txtSeri);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1455, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(435, 1097);
            this.groupControl1.TabIndex = 16;
            this.groupControl1.Text = "Fatura Detayları";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(62, 266);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(67, 19);
            this.labelControl8.TabIndex = 32;
            this.labelControl8.Text = "PERSONEL";
            // 
            // lueCari
            // 
            this.lueCari.Location = new System.Drawing.Point(139, 265);
            this.lueCari.Name = "lueCari";
            this.lueCari.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCari.Properties.DisplayMember = "AD";
            this.lueCari.Properties.ValueMember = "ID";
            this.lueCari.Size = new System.Drawing.Size(264, 22);
            this.lueCari.TabIndex = 7;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(97, 240);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(28, 19);
            this.labelControl6.TabIndex = 30;
            this.labelControl6.Text = "Cari ";
            // 
            // lueMüsteri
            // 
            this.lueMüsteri.Location = new System.Drawing.Point(139, 237);
            this.lueMüsteri.Name = "lueMüsteri";
            this.lueMüsteri.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMüsteri.Properties.DisplayMember = "AD";
            this.lueMüsteri.Properties.ValueMember = "ID";
            this.lueMüsteri.Size = new System.Drawing.Size(264, 22);
            this.lueMüsteri.TabIndex = 6;
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(139, 209);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(264, 22);
            this.txtVergiDairesi.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(45, 210);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(88, 19);
            this.labelControl5.TabIndex = 27;
            this.labelControl5.Text = "VERGİDAİRESİ";
            // 
            // TxtSaat
            // 
            this.TxtSaat.Location = new System.Drawing.Point(139, 184);
            this.TxtSaat.Name = "TxtSaat";
            this.TxtSaat.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.TxtSaat.Properties.MaskSettings.Set("mask", "90:00");
            this.TxtSaat.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.TxtSaat.Size = new System.Drawing.Size(264, 22);
            this.TxtSaat.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(97, 187);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 19);
            this.labelControl4.TabIndex = 25;
            this.labelControl4.Text = "SAAT.";
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(139, 156);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            this.txtTarih.Properties.MaskSettings.Set("mask", "d");
            this.txtTarih.Size = new System.Drawing.Size(264, 22);
            this.txtTarih.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(97, 159);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 19);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "TARİH";
            // 
            // txtSıraNo
            // 
            this.txtSıraNo.Location = new System.Drawing.Point(139, 128);
            this.txtSıraNo.Name = "txtSıraNo";
            this.txtSıraNo.Size = new System.Drawing.Size(264, 22);
            this.txtSıraNo.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(77, 131);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 19);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "SIRA NO:";
            // 
            // txtDepID
            // 
            this.txtDepID.Enabled = false;
            this.txtDepID.Location = new System.Drawing.Point(139, 74);
            this.txtDepID.Name = "txtDepID";
            this.txtDepID.Size = new System.Drawing.Size(264, 22);
            this.txtDepID.TabIndex = 0;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(22, 77);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(111, 19);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "DEPARTMAN ID : ";
            // 
            // btnListele
            // 
            this.btnListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnListele.ImageOptions.Image")));
            this.btnListele.Location = new System.Drawing.Point(229, 340);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(161, 41);
            this.btnListele.TabIndex = 11;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGüncelle.ImageOptions.Image")));
            this.btnGüncelle.Location = new System.Drawing.Point(62, 340);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(161, 41);
            this.btnGüncelle.TabIndex = 10;
            this.btnGüncelle.Text = "GÜNCELLE";
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(229, 293);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(161, 41);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "SİLME";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(62, 293);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(161, 41);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtSeri
            // 
            this.txtSeri.Location = new System.Drawing.Point(139, 103);
            this.txtSeri.Name = "txtSeri";
            this.txtSeri.Size = new System.Drawing.Size(264, 22);
            this.txtSeri.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(97, 106);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "SERİ :";
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
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridControl1.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(0, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1434, 514);
            this.gridControl1.TabIndex = 15;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // FrmFaturaListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmFaturaListele";
            this.Text = "FrmFaturaListele";
            this.Load += new System.EventHandler(this.FrmFaturaListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueCari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMüsteri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSaat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSıraNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtDepID;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnListele;
        private DevExpress.XtraEditors.SimpleButton btnGüncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.TextEdit txtSeri;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.TextEdit TxtSaat;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTarih;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtSıraNo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtVergiDairesi;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LookUpEdit lueCari;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit lueMüsteri;
    }
}