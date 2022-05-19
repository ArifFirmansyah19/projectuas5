
namespace ProjectUAS_Apotek
{
    partial class FormTabelBarang
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
            this.dataGridViewTabelBarang = new System.Windows.Forms.DataGridView();
            this.labelTabelBarang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabelBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTabelBarang
            // 
            this.dataGridViewTabelBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTabelBarang.Location = new System.Drawing.Point(69, 86);
            this.dataGridViewTabelBarang.Name = "dataGridViewTabelBarang";
            this.dataGridViewTabelBarang.RowHeadersWidth = 51;
            this.dataGridViewTabelBarang.RowTemplate.Height = 24;
            this.dataGridViewTabelBarang.Size = new System.Drawing.Size(751, 351);
            this.dataGridViewTabelBarang.TabIndex = 0;
            // 
            // labelTabelBarang
            // 
            this.labelTabelBarang.AutoSize = true;
            this.labelTabelBarang.BackColor = System.Drawing.Color.Transparent;
            this.labelTabelBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTabelBarang.Location = new System.Drawing.Point(325, 9);
            this.labelTabelBarang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTabelBarang.Name = "labelTabelBarang";
            this.labelTabelBarang.Size = new System.Drawing.Size(234, 39);
            this.labelTabelBarang.TabIndex = 20;
            this.labelTabelBarang.Text = "Tabel Barang";
            // 
            // FormTabelBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(888, 500);
            this.Controls.Add(this.labelTabelBarang);
            this.Controls.Add(this.dataGridViewTabelBarang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTabelBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTabelBarang";
            this.Load += new System.EventHandler(this.FormTabelBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabelBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTabelBarang;
        private System.Windows.Forms.Label labelTabelBarang;
    }
}