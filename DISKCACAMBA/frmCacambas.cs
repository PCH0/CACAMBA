using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISKCACAMBA
{
    public partial class frmCacambas : Form
    {
        public frmCacambas()
        {
            InitializeComponent();
        }

        private void Cacambas_Load_1(object sender, EventArgs e)
        {
            habilitaControles(false);
            habilitaBotoes(true);

            CAMADAS.BLL.Cacambas bllCacambas = new CAMADAS.BLL.Cacambas();
            dgvCacambas.DataSource = "";
            dgvCacambas.DataSource = bllCacambas.Select();
            limparControles();
        }


        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVALOR_TextChanged(object sender, EventArgs e)
        {

        }
        private void habilitaControles(bool status)
        {
            txtTIPO.Enabled = status;
            txtTAMANHO.Enabled = status;
            txtSITUACAO.Enabled = status;
            txtVALOR.Enabled = status;
            
        }

        private void habilitaBotoes(bool status)
        {
            btnCancelar.Enabled = !status;
            btnEditar.Enabled = status;
            btnGravar.Enabled = !status;
            btnInserir.Enabled = status;
            btnRemover.Enabled = status;

        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            // this.Dispose(); //libera memória da máquina
            this.Close(); //fecha o formulário, permanecendo o objeto e estruturas em memória

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            limparControles();
            habilitaControles(true);
            habilitaBotoes(false);
            txtTIPO.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lblID.Text != "-1")
            {
                habilitaControles(true);
                habilitaBotoes(false);
                txtTIPO.Focus();
            }
            else MessageBox.Show("Sem dados para Atualizar", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparControles();
            habilitaControles(false);
            habilitaBotoes(true);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Cacambas bllCacambas = new CAMADAS.BLL.Cacambas();
            
            string msg = string.Empty;
            string caixa = "Gravar";
            
            if (lblID.Text == "-1")
                 msg = "Deseja Inserir Caçamba?";
            else msg = "Deseja Alterar Caçamba?";

            DialogResult resposta = MessageBox.Show(msg, caixa, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resposta == DialogResult.Yes)
            {
                CAMADAS.MODEL.Cacambas cacambas = new CAMADAS.MODEL.Cacambas();
                cacambas.id = Convert.ToInt32(lblID.Text);
                cacambas.tipo = txtTIPO.Text;
                cacambas.tamanho = txtTAMANHO.Text;
                cacambas.valor = Convert.ToSingle(txtVALOR.Text);
                cacambas.situacao = Convert.ToInt32(txtSITUACAO.Text);

                if (lblID.Text == "-1")
                    bllCacambas.Insert(cacambas);
                else bllCacambas.Update(cacambas);
            }
           // else MessageBox.Show("Gravação Cancelada", "Gravar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvCacambas.DataSource = "";
            dgvCacambas.DataSource = bllCacambas.Select();


            limparControles();
            habilitaControles(false);
            habilitaBotoes(true);
        }

        private void limparControles()
        {
            lblID.Text = "-1";
            txtTIPO.Text = string.Empty;
            txtTAMANHO.Text = string.Empty;
            txtVALOR.Text = string.Empty;
            txtSITUACAO.Text = string.Empty;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Cacambas bllCacambas = new CAMADAS.BLL.Cacambas();
            if (lblID.Text != "-1")
            {
                string msg = "Deseja Remover?";
                DialogResult resp = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    int idCacambas = Convert.ToInt32(lblID.Text);
                    bllCacambas.Delete(idCacambas);
                }
            }
            else MessageBox.Show("Sem dados para Remover", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgvCacambas.DataSource = "";
            dgvCacambas.DataSource = bllCacambas.Select();
            limparControles();

        }

        private void dgvCacambas_DoubleClick(object sender, EventArgs e)
        {
            lblID.Text = dgvCacambas.SelectedRows[0].Cells["id"].Value.ToString();
            txtTIPO.Text = dgvCacambas.SelectedRows[0].Cells["tipo"].Value.ToString();
            txtTAMANHO.Text = dgvCacambas.SelectedRows[0].Cells["tamanho"].Value.ToString();
            txtVALOR.Text = dgvCacambas.SelectedRows[0].Cells["valor"].Value.ToString();
            txtSITUACAO.Text = dgvCacambas.SelectedRows[0].Cells["situacao"].Value.ToString();

        }

        private void btnPESQUISAR_Click(object sender, EventArgs e)
        {

        }

        private void btnPESQUISAR_Click_1(object sender, EventArgs e)
        {
            gpbPesquisa.Visible = !gpbPesquisa.Visible;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void lblFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void rbdID_CheckedChanged(object sender, EventArgs e)
        {
            lblFiltrar.Text = "Informe o ID: ";
            txtFiltro.Text = string.Empty;
            lblFiltrar.Visible = true;
            txtFiltro.Visible = true;
            txtFiltro.Focus();
        }

        private void rdbTipo_CheckedChanged(object sender, EventArgs e)
        {
            lblFiltrar.Text = "Informe o Tipo: ";
            txtFiltro.Text = string.Empty;
            lblFiltrar.Visible = true;
            txtFiltro.Visible = true;
            txtFiltro.Focus();
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            lblFiltrar.Visible = false;
            txtFiltro.Visible = false;
            CAMADAS.BLL.Cacambas bllCacambas = new CAMADAS.BLL.Cacambas();
            List<CAMADAS.MODEL.Cacambas> lstCacambas = new List<CAMADAS.MODEL.Cacambas>();
            lstCacambas = bllCacambas.Select();
            dgvCacambas.DataSource = "";
            dgvCacambas.DataSource = lstCacambas;


        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Cacambas bllCacambas = new CAMADAS.BLL.Cacambas();
            List<CAMADAS.MODEL.Cacambas> lstCacambas = new List<CAMADAS.MODEL.Cacambas>();

            if (rdbTodos.Checked)
                lstCacambas = bllCacambas.Select();
                
                else if (rdbTipo.Checked)
                        lstCacambas = bllCacambas.SelectByTipo(txtFiltro.Text);
                     else
                     {
                         int id = Convert.ToInt32(txtFiltro.Text);
                         lstCacambas = bllCacambas.SelectByID(id);
                     }
            dgvCacambas.DataSource = "";
            dgvCacambas.DataSource = lstCacambas;
        }
    }
}
