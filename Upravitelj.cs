using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vodenjerestorana
{
    public partial class Upravitelj : Form
    {
        public Upravitelj()
        {
            InitializeComponent();
        }

        private void unosNovihProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gost newMdiChild = new Gost();
            newMdiChild.MdiParent = this;
            newMdiChild.Show();
        }

        private void prikazProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Upravitelj newMdiChild = new Upravitelj();
            newMdiChild.MdiParent = this;
            newMdiChild.Show();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnObriši_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();
        }

        private void btnPrikažiNarudžbu_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
