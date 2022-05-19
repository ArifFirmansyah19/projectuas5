
namespace ProjectUAS_Apotek
{
    partial class FormTransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransaksi));
            this.labelTransaksi = new System.Windows.Forms.Label();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonCetak = new System.Windows.Forms.Button();
            this.textBoxUangBayar = new System.Windows.Forms.TextBox();
            this.textBoxTotalBelanja = new System.Windows.Forms.TextBox();
            this.textBoxKembalian = new System.Windows.Forms.TextBox();
            this.labelKembalian = new System.Windows.Forms.Label();
            this.labelTotalBelanja = new System.Windows.Forms.Label();
            this.labelUangBayar = new System.Windows.Forms.Label();
            this.dataGridViewTransaksi = new System.Windows.Forms.DataGridView();
            this.labelKode = new System.Windows.Forms.Label();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.labelJmlitem = new System.Windows.Forms.Label();
            this.dateTimePickerTanggal = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownJmlitem = new System.Windows.Forms.NumericUpDown();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.textBoxKode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaksi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJmlitem)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTransaksi
            // 
            this.labelTransaksi.AutoSize = true;
            this.labelTransaksi.BackColor = System.Drawing.Color.Transparent;
            this.labelTransaksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTransaksi.Location = new System.Drawing.Point(500, 9);
            this.labelTransaksi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTransaksi.Name = "labelTransaksi";
            this.labelTransaksi.Size = new System.Drawing.Size(174, 39);
            this.labelTransaksi.TabIndex = 20;
            this.labelTransaksi.Text = "Transaksi";
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonSimpan.Location = new System.Drawing.Point(848, 549);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(100, 28);
            this.buttonSimpan.TabIndex = 21;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            // 
            // buttonCetak
            // 
            this.buttonCetak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonCetak.Location = new System.Drawing.Point(956, 549);
            this.buttonCetak.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCetak.Name = "buttonCetak";
            this.buttonCetak.Size = new System.Drawing.Size(100, 28);
            this.buttonCetak.TabIndex = 22;
            this.buttonCetak.Text = "Cetak";
            this.buttonCetak.UseVisualStyleBackColor = false;
            // 
            // textBoxUangBayar
            // 
            this.textBoxUangBayar.BackColor = System.Drawing.Color.DarkGray;
            this.textBoxUangBayar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUangBayar.Location = new System.Drawing.Point(284, 486);
            this.textBoxUangBayar.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUangBayar.Name = "textBoxUangBayar";
            this.textBoxUangBayar.Size = new System.Drawing.Size(165, 22);
            this.textBoxUangBayar.TabIndex = 28;
            // 
            // textBoxTotalBelanja
            // 
            this.textBoxTotalBelanja.BackColor = System.Drawing.Color.DarkGray;
            this.textBoxTotalBelanja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTotalBelanja.Location = new System.Drawing.Point(284, 454);
            this.textBoxTotalBelanja.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTotalBelanja.Name = "textBoxTotalBelanja";
            this.textBoxTotalBelanja.Size = new System.Drawing.Size(165, 22);
            this.textBoxTotalBelanja.TabIndex = 27;
            // 
            // textBoxKembalian
            // 
            this.textBoxKembalian.BackColor = System.Drawing.Color.DarkGray;
            this.textBoxKembalian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxKembalian.Location = new System.Drawing.Point(284, 518);
            this.textBoxKembalian.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKembalian.Name = "textBoxKembalian";
            this.textBoxKembalian.Size = new System.Drawing.Size(165, 22);
            this.textBoxKembalian.TabIndex = 26;
            // 
            // labelKembalian
            // 
            this.labelKembalian.AutoSize = true;
            this.labelKembalian.BackColor = System.Drawing.Color.Transparent;
            this.labelKembalian.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKembalian.Location = new System.Drawing.Point(148, 520);
            this.labelKembalian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKembalian.Name = "labelKembalian";
            this.labelKembalian.Size = new System.Drawing.Size(83, 17);
            this.labelKembalian.TabIndex = 25;
            this.labelKembalian.Text = "Kembalian";
            // 
            // labelTotalBelanja
            // 
            this.labelTotalBelanja.AutoSize = true;
            this.labelTotalBelanja.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalBelanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalBelanja.Location = new System.Drawing.Point(148, 456);
            this.labelTotalBelanja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalBelanja.Name = "labelTotalBelanja";
            this.labelTotalBelanja.Size = new System.Drawing.Size(104, 17);
            this.labelTotalBelanja.TabIndex = 24;
            this.labelTotalBelanja.Text = "Total Belanja";
            // 
            // labelUangBayar
            // 
            this.labelUangBayar.AutoSize = true;
            this.labelUangBayar.BackColor = System.Drawing.Color.Transparent;
            this.labelUangBayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUangBayar.Location = new System.Drawing.Point(148, 488);
            this.labelUangBayar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUangBayar.Name = "labelUangBayar";
            this.labelUangBayar.Size = new System.Drawing.Size(93, 17);
            this.labelUangBayar.TabIndex = 23;
            this.labelUangBayar.Text = "Uang Bayar";
            // 
            // dataGridViewTransaksi
            // 
            this.dataGridViewTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransaksi.Location = new System.Drawing.Point(128, 136);
            this.dataGridViewTransaksi.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewTransaksi.Name = "dataGridViewTransaksi";
            this.dataGridViewTransaksi.RowHeadersWidth = 51;
            this.dataGridViewTransaksi.Size = new System.Drawing.Size(943, 297);
            this.dataGridViewTransaksi.TabIndex = 29;
            // 
            // labelKode
            // 
            this.labelKode.AutoSize = true;
            this.labelKode.BackColor = System.Drawing.Color.Transparent;
            this.labelKode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKode.Location = new System.Drawing.Point(125, 102);
            this.labelKode.Name = "labelKode";
            this.labelKode.Size = new System.Drawing.Size(45, 17);
            this.labelKode.TabIndex = 30;
            this.labelKode.Text = "Kode";
            // 
            // labelTanggal
            // 
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.BackColor = System.Drawing.Color.Transparent;
            this.labelTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTanggal.Location = new System.Drawing.Point(798, 99);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(67, 17);
            this.labelTanggal.TabIndex = 32;
            this.labelTanggal.Text = "Tanggal";
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.BackColor = System.Drawing.Color.Transparent;
            this.labelHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarga.Location = new System.Drawing.Point(576, 99);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(52, 17);
            this.labelHarga.TabIndex = 33;
            this.labelHarga.Text = "Harga";
            // 
            // labelJmlitem
            // 
            this.labelJmlitem.AutoSize = true;
            this.labelJmlitem.BackColor = System.Drawing.Color.Transparent;
            this.labelJmlitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJmlitem.Location = new System.Drawing.Point(366, 102);
            this.labelJmlitem.Name = "labelJmlitem";
            this.labelJmlitem.Size = new System.Drawing.Size(94, 17);
            this.labelJmlitem.TabIndex = 34;
            this.labelJmlitem.Text = "Jumlah Item";
            // 
            // dateTimePickerTanggal
            // 
            this.dateTimePickerTanggal.Location = new System.Drawing.Point(871, 97);
            this.dateTimePickerTanggal.Name = "dateTimePickerTanggal";
            this.dateTimePickerTanggal.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerTanggal.TabIndex = 35;
            // 
            // numericUpDownJmlitem
            // 
            this.numericUpDownJmlitem.Location = new System.Drawing.Point(466, 99);
            this.numericUpDownJmlitem.Name = "numericUpDownJmlitem";
            this.numericUpDownJmlitem.Size = new System.Drawing.Size(53, 22);
            this.numericUpDownJmlitem.TabIndex = 37;
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.Location = new System.Drawing.Point(634, 96);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(119, 22);
            this.textBoxHarga.TabIndex = 38;
            // 
            // textBoxKode
            // 
            this.textBoxKode.Location = new System.Drawing.Point(176, 96);
            this.textBoxKode.Name = "textBoxKode";
            this.textBoxKode.Size = new System.Drawing.Size(148, 22);
            this.textBoxKode.TabIndex = 39;
            this.textBoxKode.TextChanged += new System.EventHandler(this.textBoxKode_TextChanged);
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1179, 590);
            this.Controls.Add(this.textBoxKode);
            this.Controls.Add(this.textBoxHarga);
            this.Controls.Add(this.numericUpDownJmlitem);
            this.Controls.Add(this.dateTimePickerTanggal);
            this.Controls.Add(this.labelJmlitem);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.labelTanggal);
            this.Controls.Add(this.labelKode);
            this.Controls.Add(this.dataGridViewTransaksi);
            this.Controls.Add(this.textBoxUangBayar);
            this.Controls.Add(this.textBoxTotalBelanja);
            this.Controls.Add(this.textBoxKembalian);
            this.Controls.Add(this.labelKembalian);
            this.Controls.Add(this.labelTotalBelanja);
            this.Controls.Add(this.labelUangBayar);
            this.Controls.Add(this.buttonCetak);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.labelTransaksi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTransaksi";
            this.Text = "FormTransaksi";
            this.Load += new System.EventHandler(this.FormTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaksi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJmlitem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTransaksi;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonCetak;
        private System.Windows.Forms.TextBox textBoxUangBayar;
        private System.Windows.Forms.TextBox textBoxTotalBelanja;
        private System.Windows.Forms.TextBox textBoxKembalian;
        private System.Windows.Forms.Label labelKembalian;
        private System.Windows.Forms.Label labelTotalBelanja;
        private System.Windows.Forms.Label labelUangBayar;
        private System.Windows.Forms.DataGridView dataGridViewTransaksi;
        private System.Windows.Forms.Label labelKode;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.Label labelJmlitem;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggal;
        private System.Windows.Forms.NumericUpDown numericUpDownJmlitem;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.TextBox textBoxKode;
    }
}