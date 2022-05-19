
namespace ProjectUAS_Apotek
{
    partial class FormLaporanDetail
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
            this.labelLaporanDetail = new System.Windows.Forms.Label();
            this.dataGridViewLaporanDetail = new System.Windows.Forms.DataGridView();
            this.textBoxTotalPendapatan = new System.Windows.Forms.TextBox();
            this.labelTotalPendapatan = new System.Windows.Forms.Label();
            this.dateTimePickerTanggal = new System.Windows.Forms.DateTimePicker();
            this.labelTanggal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLaporanDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLaporanDetail
            // 
            this.labelLaporanDetail.AutoSize = true;
            this.labelLaporanDetail.BackColor = System.Drawing.Color.Transparent;
            this.labelLaporanDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLaporanDetail.Location = new System.Drawing.Point(313, 9);
            this.labelLaporanDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLaporanDetail.Name = "labelLaporanDetail";
            this.labelLaporanDetail.Size = new System.Drawing.Size(253, 39);
            this.labelLaporanDetail.TabIndex = 22;
            this.labelLaporanDetail.Text = "Laporan Detail";
            // 
            // dataGridViewLaporanDetail
            // 
            this.dataGridViewLaporanDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLaporanDetail.Location = new System.Drawing.Point(120, 158);
            this.dataGridViewLaporanDetail.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewLaporanDetail.Name = "dataGridViewLaporanDetail";
            this.dataGridViewLaporanDetail.RowHeadersWidth = 51;
            this.dataGridViewLaporanDetail.Size = new System.Drawing.Size(654, 284);
            this.dataGridViewLaporanDetail.TabIndex = 49;
            // 
            // textBoxTotalPendapatan
            // 
            this.textBoxTotalPendapatan.Location = new System.Drawing.Point(610, 108);
            this.textBoxTotalPendapatan.Name = "textBoxTotalPendapatan";
            this.textBoxTotalPendapatan.Size = new System.Drawing.Size(163, 22);
            this.textBoxTotalPendapatan.TabIndex = 48;
            // 
            // labelTotalPendapatan
            // 
            this.labelTotalPendapatan.AutoSize = true;
            this.labelTotalPendapatan.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalPendapatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPendapatan.Location = new System.Drawing.Point(439, 111);
            this.labelTotalPendapatan.Name = "labelTotalPendapatan";
            this.labelTotalPendapatan.Size = new System.Drawing.Size(147, 17);
            this.labelTotalPendapatan.TabIndex = 47;
            this.labelTotalPendapatan.Text = "Total Pendapatan :";
            // 
            // dateTimePickerTanggal
            // 
            this.dateTimePickerTanggal.Location = new System.Drawing.Point(200, 106);
            this.dateTimePickerTanggal.Name = "dateTimePickerTanggal";
            this.dateTimePickerTanggal.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerTanggal.TabIndex = 44;
            // 
            // labelTanggal
            // 
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.BackColor = System.Drawing.Color.Transparent;
            this.labelTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTanggal.Location = new System.Drawing.Point(117, 111);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(77, 17);
            this.labelTanggal.TabIndex = 43;
            this.labelTanggal.Text = "Tanggal :";
            // 
            // FormLaporanDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(888, 500);
            this.Controls.Add(this.dataGridViewLaporanDetail);
            this.Controls.Add(this.textBoxTotalPendapatan);
            this.Controls.Add(this.labelTotalPendapatan);
            this.Controls.Add(this.dateTimePickerTanggal);
            this.Controls.Add(this.labelTanggal);
            this.Controls.Add(this.labelLaporanDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLaporanDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLaporanDetail";
            this.Load += new System.EventHandler(this.FormLaporanDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLaporanDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLaporanDetail;
        private System.Windows.Forms.DataGridView dataGridViewLaporanDetail;
        private System.Windows.Forms.TextBox textBoxTotalPendapatan;
        private System.Windows.Forms.Label labelTotalPendapatan;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggal;
        private System.Windows.Forms.Label labelTanggal;
    }
}