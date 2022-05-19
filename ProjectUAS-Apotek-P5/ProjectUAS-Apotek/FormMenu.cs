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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            FormHome frmHome = new FormHome();
            frmHome.TopLevel = false;
            frmHome.AutoScroll = true;
            this.panelKonten.Controls.Clear();
            this.panelKonten.Controls.Add(frmHome);
            frmHome.Show();
            lblActiveMenu.Text = "Home";
        }

        private void pictureBoxLaporan_Click(object sender, EventArgs e)
        {
            FormLaporan frmLaporan = new FormLaporan();
            frmLaporan.TopLevel = false;
            frmLaporan.AutoScroll = true;
            this.panelKonten.Controls.Clear();
            this.panelKonten.Controls.Add(frmLaporan);
            frmLaporan.Show();
            lblActiveMenu.Text = "Laporan";
        }

        private void pictureBoxTransaksi_Click(object sender, EventArgs e)
        {
            FormTransaksi frmTransaksi = new FormTransaksi();
            frmTransaksi.TopLevel = false;
            frmTransaksi.AutoScroll = true;
            this.panelKonten.Controls.Clear();
            this.panelKonten.Controls.Add(frmTransaksi);
            frmTransaksi.Show();
            lblActiveMenu.Text = "Transaksi";
        }

        private void pictureBoxDataBarang_Click(object sender, EventArgs e)
        {
            FormDataBarang frmDataBarang = new FormDataBarang();
            frmDataBarang.TopLevel = false;
            frmDataBarang.AutoScroll = true;
            this.panelKonten.Controls.Clear();
            this.panelKonten.Controls.Add(frmDataBarang);
            frmDataBarang.Show();
            lblActiveMenu.Text = "DataBarang";
        }
    }
}
