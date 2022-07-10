namespace TEKNİKSERVİS.Formlar
{
    partial class FrmDepartman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepartman));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtDepID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDepAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnListele = new DevExpress.XtraEditors.SimpleButton();
            this.btnGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtDepAcıklama = new System.Windows.Forms.RichTextBox();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridControl1.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(-7, 273);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1393, 514);
            this.gridControl1.TabIndex = 9;
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(63)))), ((int)(((byte)(52)))));
            this.panel4.Controls.Add(this.pictureEdit1);
            this.panel4.Controls.Add(this.labelControl12);
            this.panel4.Controls.Add(this.labelControl13);
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(339, 155);
            this.panel4.TabIndex = 11;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(145, 44);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(100, 96);
            this.pictureEdit1.TabIndex = 2;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl12.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Appearance.Options.UseForeColor = true;
            this.labelControl12.Location = new System.Drawing.Point(19, 43);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(81, 62);
            this.labelControl12.TabIndex = 1;
            this.labelControl12.Text = "584";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl13.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Appearance.Options.UseForeColor = true;
            this.labelControl13.Location = new System.Drawing.Point(19, 17);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(179, 20);
            this.labelControl13.TabIndex = 0;
            this.labelControl13.Text = "Toplam Departman Sayısı";
            // 
            // txtDepID
            // 
            this.txtDepID.Enabled = false;
            this.txtDepID.Location = new System.Drawing.Point(139, 74);
            this.txtDepID.Name = "txtDepID";
            this.txtDepID.Size = new System.Drawing.Size(264, 22);
            this.txtDepID.TabIndex = 20;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(58, 136);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 19);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "AÇIKLAMA :";
            // 
            // txtDepAd
            // 
            this.txtDepAd.Location = new System.Drawing.Point(139, 102);
            this.txtDepAd.Name = "txtDepAd";
            this.txtDepAd.Size = new System.Drawing.Size(264, 22);
            this.txtDepAd.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(21, 106);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(112, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "DEPARTMAN ADI:";
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
            this.btnListele.Location = new System.Drawing.Point(200, 308);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(161, 41);
            this.btnListele.TabIndex = 17;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGüncelle.ImageOptions.Image")));
            this.btnGüncelle.Location = new System.Drawing.Point(33, 308);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(161, 41);
            this.btnGüncelle.TabIndex = 16;
            this.btnGüncelle.Text = "GÜNCELLE";
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(200, 261);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(161, 41);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "SİLME";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(33, 261);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(161, 41);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtDepAcıklama);
            this.groupControl1.Controls.Add(this.txtDepID);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.btnListele);
            this.groupControl1.Controls.Add(this.btnGüncelle);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtDepAd);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1443, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(435, 1068);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Departman İşlemleri";
            // 
            // txtDepAcıklama
            // 
            this.txtDepAcıklama.Location = new System.Drawing.Point(139, 130);
            this.txtDepAcıklama.Name = "txtDepAcıklama";
            this.txtDepAcıklama.Size = new System.Drawing.Size(264, 96);
            this.txtDepAcıklama.TabIndex = 21;
            this.txtDepAcıklama.Text = "";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl15.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Appearance.Options.UseForeColor = true;
            this.labelControl15.Location = new System.Drawing.Point(19, 17);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(160, 20);
            this.labelControl15.TabIndex = 0;
            this.labelControl15.Text = "Toplam Personel Sayısı";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl14.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Appearance.Options.UseForeColor = true;
            this.labelControl14.Location = new System.Drawing.Point(19, 43);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(81, 62);
            this.labelControl14.TabIndex = 1;
            this.labelControl14.Text = "584";
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.Location = new System.Drawing.Point(145, 44);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(100, 96);
            this.pictureEdit2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(198)))));
            this.panel1.Controls.Add(this.pictureEdit2);
            this.panel1.Controls.Add(this.labelControl14);
            this.panel1.Controls.Add(this.labelControl15);
            this.panel1.Location = new System.Drawing.Point(357, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 155);
            this.panel1.TabIndex = 14;
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl19.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl19.Appearance.Options.UseFont = true;
            this.labelControl19.Appearance.Options.UseForeColor = true;
            this.labelControl19.Location = new System.Drawing.Point(19, 17);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(168, 20);
            this.labelControl19.TabIndex = 0;
            this.labelControl19.Text = "En Az Çalışanı Olan Dep.";
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl18.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl18.Appearance.Options.UseFont = true;
            this.labelControl18.Appearance.Options.UseForeColor = true;
            this.labelControl18.Location = new System.Drawing.Point(19, 43);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(81, 62);
            this.labelControl18.TabIndex = 1;
            this.labelControl18.Text = "584";
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.Location = new System.Drawing.Point(145, 44);
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit4.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit4.Size = new System.Drawing.Size(100, 96);
            this.pictureEdit4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.panel3.Controls.Add(this.pictureEdit4);
            this.panel3.Controls.Add(this.labelControl18);
            this.panel3.Controls.Add(this.labelControl19);
            this.panel3.Location = new System.Drawing.Point(1047, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 155);
            this.panel3.TabIndex = 13;
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl17.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Appearance.Options.UseForeColor = true;
            this.labelControl17.Location = new System.Drawing.Point(19, 17);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(185, 20);
            this.labelControl17.TabIndex = 0;
            this.labelControl17.Text = "En Fazla Çalışanı Olan Dep.";
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl16.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Appearance.Options.UseForeColor = true;
            this.labelControl16.Location = new System.Drawing.Point(19, 43);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(81, 62);
            this.labelControl16.TabIndex = 1;
            this.labelControl16.Text = "584";
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.Location = new System.Drawing.Point(145, 44);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit3.Size = new System.Drawing.Size(100, 96);
            this.pictureEdit3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.panel2.Controls.Add(this.pictureEdit3);
            this.panel2.Controls.Add(this.labelControl16);
            this.panel2.Controls.Add(this.labelControl17);
            this.panel2.Location = new System.Drawing.Point(702, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 155);
            this.panel2.TabIndex = 12;
            // 
            // FrmDepartman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmDepartman";
            this.Text = "FrmDepartman";
            this.Load += new System.EventHandler(this.FrmDepartman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit txtDepID;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtDepAd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnListele;
        private DevExpress.XtraEditors.SimpleButton btnGüncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RichTextBox txtDepAcıklama;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private System.Windows.Forms.Panel panel2;
    }
}