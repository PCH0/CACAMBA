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

        private void limparItem()
        {
            lblItemID.Text = "-1";
            dtpEntrega.Value = Convert.ToDateTime("1/1//1900");
        }
        private void frmAluguel_Load(object sender, EventArgs e)
        {
            CAMADAS.BLL.Aluguel bllAlu = new CAMADAS.BLL.Aluguel();
            dgvAluguel.DataSource = "";
            dgvAluguel.DataSource = bllAlu.Select();

            CAMADAS.DAL.Clientes dalCli = new CAMADAS.DAL.Clientes();
            cmbCliente.DisplayMember = "nome";
            cmbCliente.ValueMember = "id";
            cmbCliente.DataSource = dalCli.Select();

            CAMADAS.BLL.Cacambas bllCacambas = new CAMADAS.BLL.Cacambas();
            cmbCacamba.DisplayMember = "tipo";
            cmbCacamba.ValueMember = "id";
            cmbCacamba.DataSource = bllCacambas.Select();
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

            List<CAMADAS.MODEL.Aluguel> lstAlu = bllAlu.Select();
            dgvAluguel.DataSource = "";
            dgvAluguel.DataSource = lstAlu;

        }

        private void lblAluID_Click(object sender, EventArgs e)
        {

        }

        private void dgvAluguel_DoubleClick(object sender, EventArgs e)
        {
            lblAluID.Text = dgvAluguel.SelectedRows[0].Cells["id"].Value.ToString();
            txtClienteID.Text = dgvAluguel.SelectedRows[0].Cells["cliente_id"].Value.ToString();
            cmbCliente.SelectedValue = dgvAluguel.SelectedRows[0].Cells["cliente_id"].Value;
            dtpData.Value = Convert.ToDateTime(dgvAluguel.SelectedRows[0].Cells["date"].Value.ToString());

            CAMADAS.BLL.Itens bllItens = new CAMADAS.BLL.Itens();
            dgvItens.DataSource = bllItens.SelectByAlu(Convert.ToInt32(lblAluID.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblAluID.Text != "-1")
            {
                limparItem();
                cmbCacamba.Focus();

            }
            else MessageBox.Show("Não há aluguel selecionado");
        }

        private void cmbCacamba_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCacambaID.Text = cmbCacamba.SelectedValue.ToString();

        }

        private void verificaCacamba()
        {
            int id = Convert.ToInt32(txtCacambaID.Text);
            CAMADAS.BLL.Cacambas bllCacambas = new CAMADAS.BLL.Cacambas();
            List<CAMADAS.MODEL.Cacambas> lstCacambas = bllCacambas.SelectByID(id);
            if (lstCacambas.Count()!=0)
            {
                if (lstCacambas[0].situacao != 1)
                {
                    MessageBox.Show("Caçamba " + lstCacambas[0].tipo.Trim() + " Alugada");
                    cmbCacamba.Focus();
                }
            }
            else
            {
                MessageBox.Show("Cacamba Invalida");
                cmbCacamba.Focus();
            }
            cmbCacamba.SelectedValue = Convert.ToInt32(txtCacambaID.Text);
        }
        private void txtCacambaID_Leave(object sender, EventArgs e)
        {
            verificaCacamba();
            
        }

        private void txtCacambaID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCacamba_Leave(object sender, EventArgs e)
        {
            verificaCacamba();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Itens item = new CAMADAS.MODEL.Itens();
            CAMADAS.BLL.Itens bllItens = new CAMADAS.BLL.Itens();
            item.id = Convert.ToInt32(lblItemID.Text);
            item.aluguel_id = Convert.ToInt32(lblAluID.Text);
            item.cacambas_id = Convert.ToInt32(txtCacambaID.Text);
            item.entrega = Convert.ToDateTime("1/1/1900");

            bllItens.Insert(item);
            dgvItens.DataSource = bllItens.SelectByAlu(Convert.ToInt32(lblAluID.Text));

        }

        private void dgvItens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpEntrega_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvItens_DoubleClick(object sender, EventArgs e)
        {
            lblItemID.Text = dgvItens.SelectedRows[0].Cells["id"].Value.ToString();
            cmbCacamba.SelectedValue = dgvItens.SelectedRows[0].Cells["cacambas_id"].Value;
            txtCacambaID.Text = dgvItens.SelectedRows[0].Cells["cacambas_id"].Value.ToString();
            dtpEntrega.Value = Convert.ToDateTime(dgvItens.SelectedRows[0].Cells["entrega"].Value.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(lblItemID.Text != "-1" && dtpEntrega.Value == Convert.ToDateTime("1/1/1900"))
            {
                CAMADAS.BLL.Itens bllItens = new CAMADAS.BLL.Itens();
                CAMADAS.MODEL.Itens item = new CAMADAS.MODEL.Itens();
                item.id = Convert.ToInt32(lblItemID.Text);
                item.aluguel_id = Convert.ToInt32(lblAluID.Text);
                item.cacambas_id = Convert.ToInt32(txtCacambaID.Text);

                bllItens.Devolver(item);

                dgvItens.DataSource = bllItens.SelectByAlu(item.aluguel_id);


            }
        }
    }
}
