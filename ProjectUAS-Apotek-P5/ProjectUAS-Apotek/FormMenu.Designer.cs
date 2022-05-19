namespace ProjectUAS_Apotek
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.groupBoxLaporan = new System.Windows.Forms.GroupBox();
            this.pictureBoxLaporan = new System.Windows.Forms.PictureBox();
            this.groupBoxTransaksi = new System.Windows.Forms.GroupBox();
            this.labelTransaksi = new System.Windows.Forms.Label();
            this.groupBoxDataBarang = new System.Windows.Forms.GroupBox();
            this.labelDataBarang = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.labelket = new System.Windows.Forms.Label();
            this.labelnama = new System.Windows.Forms.Label();
            this.labelalamat = new System.Windows.Forms.Label();
            this.labelkontak = new System.Windows.Forms.Label();
            this.panelKonten = new System.Windows.Forms.Panel();
            this.lblActiveMenu = new System.Windows.Forms.Label();
            this.labelLaporan = new System.Windows.Forms.Label();
            this.pictureBoxTransaksi = new System.Windows.Forms.PictureBox();
            this.pictureBoxDataBarang = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            this.groupBoxLaporan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLaporan)).BeginInit();
            this.groupBoxTransaksi.SuspendLayout();
            this.groupBoxDataBarang.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelKonten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTransaksi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDataBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Silver;
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.groupBoxLaporan);
            this.panelHeader.Controls.Add(this.groupBoxTransaksi);
            this.panelHeader.Controls.Add(this.groupBoxDataBarang);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1179, 123);
            this.panelHeader.TabIndex = 0;
            // 
            // groupBoxLaporan
            // 
            this.groupBoxLaporan.Controls.Add(this.labelLaporan);
            this.groupBoxLaporan.Controls.Add(this.pictureBoxLaporan);
            this.groupBoxLaporan.Location = new System.Drawing.Point(629, 15);
            this.groupBoxLaporan.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxLaporan.Name = "groupBoxLaporan";
            this.groupBoxLaporan.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxLaporan.Size = new System.Drawing.Size(249, 101);
            this.groupBoxLaporan.TabIndex = 2;
            this.groupBoxLaporan.TabStop = false;
            // 
            // pictureBoxLaporan
            // 
            this.pictureBoxLaporan.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLaporan.Image")));
            this.pictureBoxLaporan.Location = new System.Drawing.Point(88, 0);
            this.pictureBoxLaporan.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLaporan.Name = "pictureBoxLaporan";
            this.pictureBoxLaporan.Size = new System.Drawing.Size(73, 74);
            this.pictureBoxLaporan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLaporan.TabIndex = 0;
            this.pictureBoxLaporan.TabStop = false;
            this.pictureBoxLaporan.Click += new System.EventHandler(this.pictureBoxLaporan_Click);
            // 
            // groupBoxTransaksi
            // 
            this.groupBoxTransaksi.Controls.Add(this.pictureBoxTransaksi);
            this.groupBoxTransaksi.Controls.Add(this.labelTransaksi);
            this.groupBoxTransaksi.Location = new System.Drawing.Point(321, 15);
            this.groupBoxTransaksi.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxTransaksi.Name = "groupBoxTransaksi";
            this.groupBoxTransaksi.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxTransaksi.Size = new System.Drawing.Size(249, 101);
            this.groupBoxTransaksi.TabIndex = 2;
            this.groupBoxTransaksi.TabStop = false;
            // 
            // labelTransaksi
            // 
            this.labelTransaksi.AutoSize = true;
            this.labelTransaksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTransaksi.Location = new System.Drawing.Point(81, 78);
            this.labelTransaksi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTransaksi.Name = "labelTransaksi";
            this.labelTransaksi.Size = new System.Drawing.Size(91, 20);
            this.labelTransaksi.TabIndex = 1;
            this.labelTransaksi.Text = "Transaksi";
            this.labelTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxDataBarang
            // 
            this.groupBoxDataBarang.Controls.Add(this.pictureBoxDataBarang);
            this.groupBoxDataBarang.Controls.Add(this.labelDataBarang);
            this.groupBoxDataBarang.Location = new System.Drawing.Point(16, 15);
            this.groupBoxDataBarang.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDataBarang.Name = "groupBoxDataBarang";
            this.groupBoxDataBarang.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDataBarang.Size = new System.Drawing.Size(249, 101);
            this.groupBoxDataBarang.TabIndex = 0;
            this.groupBoxDataBarang.TabStop = false;
            // 
            // labelDataBarang
            // 
            this.labelDataBarang.AutoSize = true;
            this.labelDataBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataBarang.Location = new System.Drawing.Point(71, 77);
            this.labelDataBarang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDataBarang.Name = "labelDataBarang";
            this.labelDataBarang.Size = new System.Drawing.Size(109, 20);
            this.labelDataBarang.TabIndex = 1;
            this.labelDataBarang.Text = "DataBarang";
            this.labelDataBarang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.Silver;
            this.panelFooter.Controls.Add(this.labelket);
            this.panelFooter.Controls.Add(this.labelnama);
            this.panelFooter.Controls.Add(this.labelalamat);
            this.panelFooter.Controls.Add(this.labelkontak);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 713);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(4);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1179, 39);
            this.panelFooter.TabIndex = 1;
            // 
            // labelket
            // 
            this.labelket.AutoSize = true;
            this.labelket.BackColor = System.Drawing.Color.Silver;
            this.labelket.Location = new System.Drawing.Point(913, 20);
            this.labelket.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelket.Name = "labelket";
            this.labelket.Size = new System.Drawing.Size(204, 17);
            this.labelket.TabIndex = 2;
            this.labelket.Text = "Solusi Cerdas Kesehatan Anda";
            // 
            // labelnama
            // 
            this.labelnama.AutoSize = true;
            this.labelnama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelnama.Location = new System.Drawing.Point(944, 4);
            this.labelnama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelnama.Name = "labelnama";
            this.labelnama.Size = new System.Drawing.Size(163, 17);
            this.labelnama.TabIndex = 3;
            this.labelnama.Text = "APOTEK FRB-FARMA";
            // 
            // labelalamat
            // 
            this.labelalamat.AutoSize = true;
            this.labelalamat.Location = new System.Drawing.Point(49, 20);
            this.labelalamat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelalamat.Name = "labelalamat";
            this.labelalamat.Size = new System.Drawing.Size(235, 17);
            this.labelalamat.TabIndex = 1;
            this.labelalamat.Text = "Jalan Simpang Sungai Duren RT 10";
            // 
            // labelkontak
            // 
            this.labelkontak.AutoSize = true;
            this.labelkontak.Location = new System.Drawing.Point(49, 4);
            this.labelkontak.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelkontak.Name = "labelkontak";
            this.labelkontak.Size = new System.Drawing.Size(134, 17);
            this.labelkontak.TabIndex = 0;
            this.labelkontak.Text = "+62 813-7796-0716";
            // 
            // panelKonten
            // 
            this.panelKonten.Controls.Add(this.lblActiveMenu);
            this.panelKonten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKonten.Location = new System.Drawing.Point(0, 123);
            this.panelKonten.Margin = new System.Windows.Forms.Padding(4);
            this.panelKonten.Name = "panelKonten";
            this.panelKonten.Size = new System.Drawing.Size(1179, 590);
            this.panelKonten.TabIndex = 2;
            // 
            // lblActiveMenu
            // 
            this.lblActiveMenu.AutoSize = true;
            this.lblActiveMenu.Location = new System.Drawing.Point(289, 118);
            this.lblActiveMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActiveMenu.Name = "lblActiveMenu";
            this.lblActiveMenu.Size = new System.Drawing.Size(0, 17);
            this.lblActiveMenu.TabIndex = 0;
            // 
            // labelLaporan
            // 
            this.labelLaporan.AutoSize = true;
            this.labelLaporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLaporan.Location = new System.Drawing.Point(84, 78);
            this.labelLaporan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLaporan.Name = "labelLaporan";
            this.labelLaporan.Size = new System.Drawing.Size(77, 20);
            this.labelLaporan.TabIndex = 2;
            this.labelLaporan.Text = "Laporan";
            this.labelLaporan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxTransaksi
            // 
            this.pictureBoxTransaksi.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTransaksi.Image")));
            this.pictureBoxTransaksi.Location = new System.Drawing.Point(85, 0);
            this.pictureBoxTransaksi.Name = "pictureBoxTransaksi";
            this.pictureBoxTransaksi.Size = new System.Drawing.Size(87, 75);
            this.pictureBoxTransaksi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxTransaksi.TabIndex = 2;
            this.pictureBoxTransaksi.TabStop = false;
            this.pictureBoxTransaksi.Click += new System.EventHandler(this.pictureBoxTransaksi_Click);
            // 
            // pictureBoxDataBarang
            // 
            this.pictureBoxDataBarang.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDataBarang.Image")));
            this.pictureBoxDataBarang.Location = new System.Drawing.Point(75, 0);
            this.pictureBoxDataBarang.Name = "pictureBoxDataBarang";
            this.pictureBoxDataBarang.Size = new System.Drawing.Size(105, 75);
            this.pictureBoxDataBarang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxDataBarang.TabIndex = 2;
            this.pictureBoxDataBarang.TabStop = false;
            this.pictureBoxDataBarang.Click += new System.EventHandler(this.pictureBoxDataBarang_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 752);
            this.Controls.Add(this.panelKonten);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apotek FRB-Farma";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panelHeader.ResumeLayout(false);
            this.groupBoxLaporan.ResumeLayout(false);
            this.groupBoxLaporan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLaporan)).EndInit();
            this.groupBoxTransaksi.ResumeLayout(false);
            this.groupBoxTransaksi.PerformLayout();
            this.groupBoxDataBarang.ResumeLayout(false);
            this.groupBoxDataBarang.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panelKonten.ResumeLayout(false);
            this.panelKonten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTransaksi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDataBarang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.GroupBox groupBoxDataBarang;
        private System.Windows.Forms.Label labelDataBarang;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelKonten;
        private System.Windows.Forms.GroupBox groupBoxLaporan;
        private System.Windows.Forms.PictureBox pictureBoxLaporan;
        private System.Windows.Forms.GroupBox groupBoxTransaksi;
        private System.Windows.Forms.Label labelTransaksi;
        private System.Windows.Forms.Label labelket;
        private System.Windows.Forms.Label labelnama;
        private System.Windows.Forms.Label labelalamat;
        private System.Windows.Forms.Label labelkontak;
        private System.Windows.Forms.Label lblActiveMenu;
        private System.Windows.Forms.Label labelLaporan;
        private System.Windows.Forms.PictureBox pictureBoxTransaksi;
        private System.Windows.Forms.PictureBox pictureBoxDataBarang;
    }
}

