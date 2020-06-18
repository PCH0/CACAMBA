using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISKCACAMBA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CAMADAS.DAL.Clientes dalCli = new CAMADAS.DAL.Clientes();
            dtGrvCLIENTES.DataSource = dalCli.Select();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        } 

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnINSERIR_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Clientes clientes = new CAMADAS.MODEL.Clientes();
            clientes.nome = txtNOME.Text;
            clientes.endereco = txtENDERECO.Text;
            clientes.telefone = txtTELEFONE.Text;
            clientes.dias = Convert.ToInt32(txtDIAS.Text);
            clientes.multa = Convert.ToSingle(txtMULTA.Text);

            CAMADAS.DAL.Clientes dalCli = new CAMADAS.DAL.Clientes();
            dalCli.Insert(clientes);

            dtGrvCLIENTES.DataSource = "";
            dtGrvCLIENTES.DataSource = dalCli.Select();



        }

        private void btnSAIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEDITAR_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Clientes clientes = new CAMADAS.MODEL.Clientes();
            clientes.id = Convert.ToInt32(txtID.Text);
            clientes.nome = txtNOME.Text;
            clientes.endereco = txtENDERECO.Text;
            clientes.telefone = txtTELEFONE.Text;
            clientes.dias = Convert.ToInt32(txtDIAS.Text);
            clientes.multa = Convert.ToSingle(txtMULTA.Text);

            CAMADAS.DAL.Clientes dalCli = new CAMADAS.DAL.Clientes();
            dalCli.Update(clientes);

            dtGrvCLIENTES.DataSource = "";
            dtGrvCLIENTES.DataSource = dalCli.Select();
        }

        private void btnREMOVER_Click(object sender, EventArgs e)
        {
            int idCli = Convert.ToInt32(txtID.Text);

            CAMADAS.DAL.Clientes dalCli = new CAMADAS.DAL.Clientes();
            dalCli.Delete(idCli);

            dtGrvCLIENTES.DataSource = "";
            dtGrvCLIENTES.DataSource = dalCli.Select();
        }

        private void lbID_Click(object sender, EventArgs e)
        {

        }

        private void txtENDERECO_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDIAS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMULTA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNOME_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
