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
    public partial class FormTransaksi : Form
    {
        public FormTransaksi()
        {
            InitializeComponent();
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {

        }

        private void textBoxKode_TextChanged(object sender, EventArgs e)
        {
            FormTabelBarang frmTabelBarang = new FormTabelBarang();
            frmTabelBarang.Show();
        }
    }
}
