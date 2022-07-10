namespace TEKNİKSERVİS.Formlar
{
    partial class FrmArizaDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArizaDetay));
            this.txtSeriNO = new DevExpress.XtraEditors.TextEdit();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnAciklama = new DevExpress.XtraEditors.SimpleButton();
            this.txtTarih = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSeriNO
            // 
            this.txtSeriNO.Location = new System.Drawing.Point(99, 108);
            this.txtSeriNO.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeriNO.Name = "txtSeriNO";
            this.txtSeriNO.Size = new System.Drawing.Size(192, 22);
            this.txtSeriNO.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 233);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(278, 96);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 41);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(231, 31);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "ARIZA DETAY PANELİ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(13, 112);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 16);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Seri No : ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(13, 158);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 16);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Tarih :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(15, 208);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(82, 16);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Ürün Açıklama";
            // 
            // btnAciklama
            // 
            this.btnAciklama.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAciklama.ImageOptions.Image")));
            this.btnAciklama.Location = new System.Drawing.Point(13, 381);
            this.btnAciklama.Margin = new System.Windows.Forms.Padding(6);
            this.btnAciklama.Name = "btnAciklama";
            this.btnAciklama.Size = new System.Drawing.Size(168, 43);
            this.btnAciklama.TabIndex = 4;
            this.btnAciklama.Text = "GÜNCELLE";
            this.btnAciklama.Click += new System.EventHandler(this.btnAciklama_Click);
            // 
            // txtTarih
            // 
            this.txtTarih.EditValue = "";
            this.txtTarih.Location = new System.Drawing.Point(99, 155);
            this.txtTarih.Margin = new System.Windows.Forms.Padding(5);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.DisplayFormat.FormatString = "";
            this.txtTarih.Properties.EditFormat.FormatString = "";
            this.txtTarih.Properties.MaskSettings.Set("mask", "d");
            this.txtTarih.Size = new System.Drawing.Size(192, 22);
            this.txtTarih.TabIndex = 2;
            
            // 
            // FrmArizaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(324, 506);
            this.Controls.Add(this.btnAciklama);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtSeriNO);
            this.Controls.Add(this.txtTarih);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmArizaDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmArizaDetay";
            this.Load += new System.EventHandler(this.FrmArizaDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtSeriNO;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnAciklama;
        private DevExpress.XtraEditors.DateEdit txtTarih;
    }
}