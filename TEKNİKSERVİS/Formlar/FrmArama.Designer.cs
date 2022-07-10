namespace TEKNİKSERVİS.Formlar
{
    partial class FrmArama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArama));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LabelAra = new DevExpress.XtraEditors.LabelControl();
            this.txtSeriNo = new DevExpress.XtraEditors.TextEdit();
            this.btnFaturaArama = new DevExpress.XtraEditors.SimpleButton();
            this.textSıraNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSıraNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridControl1.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.gridControl1.Location = new System.Drawing.Point(1, 124);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1926, 783);
            this.gridControl1.TabIndex = 16;
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
            // LabelAra
            // 
            this.LabelAra.Appearance.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelAra.Appearance.Options.UseFont = true;
            this.LabelAra.Location = new System.Drawing.Point(534, 32);
            this.LabelAra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LabelAra.Name = "LabelAra";
            this.LabelAra.Size = new System.Drawing.Size(76, 20);
            this.LabelAra.TabIndex = 17;
            this.LabelAra.Text = "Seri No:";
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.Location = new System.Drawing.Point(534, 62);
            this.txtSeriNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Size = new System.Drawing.Size(182, 22);
            this.txtSeriNo.TabIndex = 2;
            // 
            // btnFaturaArama
            // 
            this.btnFaturaArama.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFaturaArama.ImageOptions.Image")));
            this.btnFaturaArama.Location = new System.Drawing.Point(752, 32);
            this.btnFaturaArama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFaturaArama.Name = "btnFaturaArama";
            this.btnFaturaArama.Size = new System.Drawing.Size(102, 52);
            this.btnFaturaArama.TabIndex = 3;
            this.btnFaturaArama.Text = "ARA";
            this.btnFaturaArama.Click += new System.EventHandler(this.btnFaturaArama_Click);
            // 
            // textSıraNo
            // 
            this.textSıraNo.Location = new System.Drawing.Point(280, 62);
            this.textSıraNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textSıraNo.Name = "textSıraNo";
            this.textSıraNo.Size = new System.Drawing.Size(228, 22);
            this.textSıraNo.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(280, 32);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 20);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Sıra No:";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(41, 62);
            this.textID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(210, 22);
            this.textID.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(41, 32);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(105, 20);
            this.labelControl2.TabIndex = 23;
            this.labelControl2.Text = "FATURA ID";
            // 
            // FrmArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textSıraNo);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnFaturaArama);
            this.Controls.Add(this.txtSeriNo);
            this.Controls.Add(this.LabelAra);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmArama";
            this.Text = "FrmArama";
            this.Load += new System.EventHandler(this.FrmArama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSıraNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl LabelAra;
        private DevExpress.XtraEditors.TextEdit txtSeriNo;
        private DevExpress.XtraEditors.SimpleButton btnFaturaArama;
        private DevExpress.XtraEditors.TextEdit textSıraNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textID;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}