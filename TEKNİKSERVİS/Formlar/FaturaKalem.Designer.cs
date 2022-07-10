namespace TEKNİKSERVİS.Formlar
{
    partial class FaturaKalem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaturaKalem));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDetayID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnListele = new DevExpress.XtraEditors.SimpleButton();
            this.btnGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtURUN = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtAdet = new DevExpress.XtraEditors.TextEdit();
            this.txtFiyat = new DevExpress.XtraEditors.TextEdit();
            this.txtTutar = new DevExpress.XtraEditors.TextEdit();
            this.txtFaturaID = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetayID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtURUN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridControl1.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.gridControl1.Location = new System.Drawing.Point(-2, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1181, 802);
            this.gridControl1.TabIndex = 17;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(247)))), ((int)(((byte)(172)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(188)))), ((int)(((byte)(77)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.DetailHeight = 546;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(50, 222);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 19);
            this.labelControl4.TabIndex = 25;
            this.labelControl4.Text = "TUTAR";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(56, 179);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 19);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "FİYAT";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(55, 133);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 19);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "ADET:";
            // 
            // txtDetayID
            // 
            this.txtDetayID.Enabled = false;
            this.txtDetayID.Location = new System.Drawing.Point(101, 45);
            this.txtDetayID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtDetayID.Name = "txtDetayID";
            this.txtDetayID.Size = new System.Drawing.Size(221, 22);
            this.txtDetayID.TabIndex = 0;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(25, 48);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(66, 19);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "DETAY ID :";
            // 
            // btnListele
            // 
            this.btnListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnListele.ImageOptions.Image")));
            this.btnListele.Location = new System.Drawing.Point(213, 348);
            this.btnListele.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(161, 43);
            this.btnListele.TabIndex = 9;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGüncelle.ImageOptions.Image")));
            this.btnGüncelle.Location = new System.Drawing.Point(42, 348);
            this.btnGüncelle.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(161, 43);
            this.btnGüncelle.TabIndex = 8;
            this.btnGüncelle.Text = "GÜNCELLE";
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(213, 295);
            this.btnSil.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(161, 43);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "SİLME";
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(42, 295);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(161, 43);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtURUN
            // 
            this.txtURUN.Location = new System.Drawing.Point(101, 91);
            this.txtURUN.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtURUN.Name = "txtURUN";
            this.txtURUN.Size = new System.Drawing.Size(221, 22);
            this.txtURUN.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(45, 95);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "URUN :";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtFaturaID);
            this.groupControl1.Controls.Add(this.txtTutar);
            this.groupControl1.Controls.Add(this.txtFiyat);
            this.groupControl1.Controls.Add(this.txtAdet);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtDetayID);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.btnListele);
            this.groupControl1.Controls.Add(this.btnGüncelle);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.txtURUN);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1245, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(680, 1714);
            this.groupControl1.TabIndex = 18;
            this.groupControl1.Text = "Fatura Kalem İşlemleri";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(23, 255);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(68, 19);
            this.labelControl5.TabIndex = 26;
            this.labelControl5.Text = "FATURA ID";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(101, 132);
            this.txtAdet.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(221, 22);
            this.txtAdet.TabIndex = 2;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(98, 178);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(224, 22);
            this.txtFiyat.TabIndex = 3;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(98, 218);
            this.txtTutar.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(224, 22);
            this.txtTutar.TabIndex = 4;
            // 
            // txtFaturaID
            // 
            this.txtFaturaID.Location = new System.Drawing.Point(98, 260);
            this.txtFaturaID.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.txtFaturaID.Name = "txtFaturaID";
            this.txtFaturaID.Size = new System.Drawing.Size(224, 22);
            this.txtFaturaID.TabIndex = 5;
            // 
            // FaturaKalem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FaturaKalem";
            this.Text = "FaturaKalem";
            this.Load += new System.EventHandler(this.FaturaKalem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetayID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtURUN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtDetayID;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnListele;
        private DevExpress.XtraEditors.SimpleButton btnGüncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.TextEdit txtURUN;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtFaturaID;
        private DevExpress.XtraEditors.TextEdit txtTutar;
        private DevExpress.XtraEditors.TextEdit txtFiyat;
        private DevExpress.XtraEditors.TextEdit txtAdet;
    }
}