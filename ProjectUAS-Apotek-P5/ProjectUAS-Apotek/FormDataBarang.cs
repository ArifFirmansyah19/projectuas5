using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectUAS_Apotek
{
    public partial class FormDataBarang : Form
    {
        public FormDataBarang()
        {
            InitializeComponent();
        }

        private void FormDataBarang_Load(object sender, EventArgs e)
        {
            loadDataBarang();
        }

        private void loadDataBarang()
        {
            DataTable dt = new DataTable(); //dt(nama objek)
            dt = DataBarang.SelectAll(); //memilih semua data pada table DataBarang dan ditampung di objek dt
            //dataGridViewPengguna.AutoGenerateColumns = false;
            dataGridViewDataBarang.DataSource = dt; //dt dijadikan sebagai DataSource, dt sebagai sumber datagridview
            //dataGridViewDataBarang.Columns["id_barang"].Visible = false; //masih eror, ketika menu data barang diklik form data barangnya malah tidak muncul
            dataGridViewDataBarang.RowHeadersVisible = false;
            dataGridViewDataBarang.Show(); //datagridview ditampilkan
        }

        private void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            loadDataBarang();
        }

        private void dataGridViewDataBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBarang databarang = new DataBarang();
            int selectedrowindex = dataGridViewDataBarang.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewDataBarang.Rows[selectedrowindex];
            databarang.nama_barang = Convert.ToString(selectedRow.Cells["nama_barang"].Value);
            databarang.perusahaan = Convert.ToString(selectedRow.Cells["perusahaan"].Value);
            databarang.harga_beli = Convert.ToInt32(selectedRow.Cells["harga_beli"].Value);
            databarang.harga_jual = Convert.ToInt32(selectedRow.Cells["harga_jual"].Value);
            databarang.stock = Convert.ToInt32(selectedRow.Cells["stock"].Value);
            databarang.exp = Convert.ToDateTime(selectedRow.Cells["exp"].Value);
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            DataBarang databarang = new DataBarang();
            databarang.nama_barang = textBoxNamaBarang.Text;
            databarang.perusahaan = textBoxPerusahaan.Text;
            databarang.harga_beli = Convert.ToInt32(textBoxHargaBeli.Text);
            databarang.harga_jual = Convert.ToInt32(textBoxHargaJual.Text);
            databarang.stock = Convert.ToInt32(textBoxStock.Text);
            databarang.exp = Convert.ToDateTime(dateTimePickerExp.Text);

            String response = databarang.insert();
            if (response == null)
            {
                MessageBox.Show("Tambah barang berhasil");
                this.Close();
            }
            else
            {
                MessageBox.Show("Tambah barang gagal. Error: " + response);
            }
            loadDataBarang();
        }
    }
}
