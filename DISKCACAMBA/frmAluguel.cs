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
    public partial class frmAluguel : Form
    {
        public frmAluguel()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void limparAluguel()
        {
            lblAluID.Text = "-1";
            dtpData.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());

        }
        private void frmAluguel_Load(object sender, EventArgs e)
        {
            CAMADAS.BLL.Aluguel bllAlu = new CAMADAS.BLL.Aluguel();
            dgvAluguel.DataSource = bllAlu.Select();

            CAMADAS.DAL.Clientes dalCli = new CAMADAS.DAL.Clientes();
            cmbCliente.DisplayMember = "nome";
            cmbCliente.ValueMember = "id";
            cmbCliente.DataSource = dalCli.Select();
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtClienteID.Text = cmbCliente.SelectedValue.ToString();
        }

        private void txtClienteID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClienteID_Leave(object sender, EventArgs e)
        {
            try
            {
                cmbCliente.SelectedValue = Convert.ToInt32(txtClienteID.Text);
            }
            catch
            {
                MessageBox.Show("Cliente Invalido");
                cmbCliente.Focus();
            }

            
            
        }

        private void cmbCliente_Leave(object sender, EventArgs e)
        {
            try
            {
                txtClienteID.Text = cmbCliente.SelectedValue.ToString();

            }
            catch
            {
                MessageBox.Show("Cliente Inválido");
                cmbCliente.Focus();

            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limparAluguel();
            cmbCliente.Focus();

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Aluguel aluguel = new CAMADAS.MODEL.Aluguel();
            aluguel.id = Convert.ToInt32(lblAluID.Text);
            aluguel.cliente_id = Convert.ToInt32(cmbCliente.SelectedValue.ToString());
            aluguel.date = dtpData.Value;

            CAMADAS.BLL.Aluguel bllAlu = new CAMADAS.BLL.Aluguel();
            if (lblAluID.Text == "-1")
                 bllAlu.Insert(aluguel);
            else bllAlu.Update(aluguel);

            dgvAluguel.DataSource = bllAlu.Select();
        }
    }
}
