using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISKCACAMBA
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frmCli = new Form1();
            frmCli.MdiParent = this;
            frmCli.Show();
        }

        private void caçambasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCacambas frmCac = new frmCacambas();
            frmCac.MdiParent = this;
            frmCac.Show();
        }

        private void caçambasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RELATORIOS.Relgerais.relcacambas();
        }

        private void empréstimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAluguel frmAlu = new frmAluguel();
            frmAlu.MdiParent = this;
            frmAlu.Show();
        }
    }
}
