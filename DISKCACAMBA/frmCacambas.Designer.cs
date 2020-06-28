namespace DISKCACAMBA
{
    partial class frmCacambas
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbTIPO = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSITUACAO = new System.Windows.Forms.TextBox();
            this.txtVALOR = new System.Windows.Forms.TextBox();
            this.txtTIPO = new System.Windows.Forms.TextBox();
            this.txtTAMANHO = new System.Windows.Forms.TextBox();
            this.dgvCacambas = new System.Windows.Forms.DataGridView();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.btnPESQUISAR = new System.Windows.Forms.Button();
            this.gpbPesquisa = new System.Windows.Forms.GroupBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.rdbTipo = new System.Windows.Forms.RadioButton();
            this.rbdID = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCacambas)).BeginInit();
            this.gpbPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(28, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "VALOR";
            // 
            // lbTIPO
            // 
            this.lbTIPO.AutoSize = true;
            this.lbTIPO.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbTIPO.Location = new System.Drawing.Point(264, 18);
            this.lbTIPO.Name = "lbTIPO";
            this.lbTIPO.Size = new System.Drawing.Size(53, 23);
            this.lbTIPO.TabIndex = 2;
            this.lbTIPO.Text = "TIPO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(264, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "SITUAÇÃO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "TAMANHO";
            // 
            // txtSITUACAO
            // 
            this.txtSITUACAO.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtSITUACAO.Location = new System.Drawing.Point(374, 114);
            this.txtSITUACAO.Name = "txtSITUACAO";
            this.txtSITUACAO.Size = new System.Drawing.Size(109, 32);
            this.txtSITUACAO.TabIndex = 11;
            // 
            // txtVALOR
            // 
            this.txtVALOR.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtVALOR.Location = new System.Drawing.Point(127, 114);
            this.txtVALOR.Name = "txtVALOR";
            this.txtVALOR.Size = new System.Drawing.Size(109, 32);
            this.txtVALOR.TabIndex = 10;
            this.txtVALOR.TextChanged += new System.EventHandler(this.txtVALOR_TextChanged);
            // 
            // txtTIPO
            // 
            this.txtTIPO.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtTIPO.Location = new System.Drawing.Point(328, 12);
            this.txtTIPO.Name = "txtTIPO";
            this.txtTIPO.Size = new System.Drawing.Size(155, 32);
            this.txtTIPO.TabIndex = 8;
            // 
            // txtTAMANHO
            // 
            this.txtTAMANHO.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtTAMANHO.Location = new System.Drawing.Point(127, 213);
            this.txtTAMANHO.Name = "txtTAMANHO";
            this.txtTAMANHO.Size = new System.Drawing.Size(109, 32);
            this.txtTAMANHO.TabIndex = 9;
            // 
            // dgvCacambas
            // 
            this.dgvCacambas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCacambas.Location = new System.Drawing.Point(16, 350);
            this.dgvCacambas.Name = "dgvCacambas";
            this.dgvCacambas.Size = new System.Drawing.Size(935, 150);
            this.dgvCacambas.TabIndex = 20;
            this.dgvCacambas.DoubleClick += new System.EventHandler(this.dgvCacambas_DoubleClick);
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnInserir.Location = new System.Drawing.Point(88, 309);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(103, 35);
            this.btnInserir.TabIndex = 12;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEditar.Location = new System.Drawing.Point(208, 309);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(103, 35);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRemover.Location = new System.Drawing.Point(328, 309);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(103, 35);
            this.btnRemover.TabIndex = 14;
            this.btnRemover.Text = "&Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(448, 309);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 35);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnGravar.Location = new System.Drawing.Point(568, 309);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(103, 35);
            this.btnGravar.TabIndex = 16;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(47, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnVoltar.Location = new System.Drawing.Point(808, 309);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(103, 35);
            this.btnVoltar.TabIndex = 18;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.White;
            this.lblID.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblID.Location = new System.Drawing.Point(127, 15);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(109, 32);
            this.lblID.TabIndex = 19;
            // 
            // btnPESQUISAR
            // 
            this.btnPESQUISAR.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnPESQUISAR.Location = new System.Drawing.Point(688, 309);
            this.btnPESQUISAR.Name = "btnPESQUISAR";
            this.btnPESQUISAR.Size = new System.Drawing.Size(103, 35);
            this.btnPESQUISAR.TabIndex = 22;
            this.btnPESQUISAR.Text = "&Pesquisar";
            this.btnPESQUISAR.UseVisualStyleBackColor = true;
            this.btnPESQUISAR.Click += new System.EventHandler(this.btnPESQUISAR_Click_1);
            // 
            // gpbPesquisa
            // 
            this.gpbPesquisa.BackColor = System.Drawing.Color.Gray;
            this.gpbPesquisa.Controls.Add(this.lblFiltrar);
            this.gpbPesquisa.Controls.Add(this.btnFiltrar);
            this.gpbPesquisa.Controls.Add(this.txtFiltro);
            this.gpbPesquisa.Controls.Add(this.rdbTipo);
            this.gpbPesquisa.Controls.Add(this.rbdID);
            this.gpbPesquisa.Controls.Add(this.rdbTodos);
            this.gpbPesquisa.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.gpbPesquisa.Location = new System.Drawing.Point(489, 10);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Size = new System.Drawing.Size(462, 288);
            this.gpbPesquisa.TabIndex = 23;
            this.gpbPesquisa.TabStop = false;
            this.gpbPesquisa.Text = "Filtrar Dados";
            this.gpbPesquisa.Visible = false;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.Location = new System.Drawing.Point(6, 157);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(451, 29);
            this.lblFiltrar.TabIndex = 7;
            this.lblFiltrar.Visible = false;
            this.lblFiltrar.Click += new System.EventHandler(this.lblFiltrar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Image = global::DISKCACAMBA.Properties.Resources.Filtrar1;
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.Location = new System.Drawing.Point(356, 227);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(100, 36);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(5, 189);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(451, 32);
            this.txtFiltro.TabIndex = 4;
            this.txtFiltro.Visible = false;
            // 
            // rdbTipo
            // 
            this.rdbTipo.AutoSize = true;
            this.rdbTipo.Location = new System.Drawing.Point(5, 97);
            this.rdbTipo.Name = "rdbTipo";
            this.rdbTipo.Size = new System.Drawing.Size(68, 27);
            this.rdbTipo.TabIndex = 2;
            this.rdbTipo.Text = "&Tipo";
            this.rdbTipo.UseVisualStyleBackColor = true;
            this.rdbTipo.CheckedChanged += new System.EventHandler(this.rdbTipo_CheckedChanged);
            // 
            // rbdID
            // 
            this.rbdID.AutoSize = true;
            this.rbdID.Location = new System.Drawing.Point(5, 59);
            this.rbdID.Name = "rbdID";
            this.rbdID.Size = new System.Drawing.Size(48, 27);
            this.rbdID.TabIndex = 1;
            this.rbdID.Text = "&ID";
            this.rbdID.UseVisualStyleBackColor = true;
            this.rbdID.CheckedChanged += new System.EventHandler(this.rbdID_CheckedChanged);
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Checked = true;
            this.rdbTodos.Location = new System.Drawing.Point(5, 23);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(83, 27);
            this.rdbTodos.TabIndex = 0;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "&Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            this.rdbTodos.CheckedChanged += new System.EventHandler(this.rdbTodos_CheckedChanged);
            // 
            // frmCacambas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.ControlBox = false;
            this.Controls.Add(this.gpbPesquisa);
            this.Controls.Add(this.btnPESQUISAR);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.dgvCacambas);
            this.Controls.Add(this.txtTAMANHO);
            this.Controls.Add(this.txtTIPO);
            this.Controls.Add(this.txtVALOR);
            this.Controls.Add(this.txtSITUACAO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTIPO);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1300, 700);
            this.Name = "frmCacambas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUSCA CAÇAMBA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Cacambas_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCacambas)).EndInit();
            this.gpbPesquisa.ResumeLayout(false);
            this.gpbPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTIPO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSITUACAO;
        private System.Windows.Forms.TextBox txtVALOR;
        private System.Windows.Forms.TextBox txtTIPO;
        private System.Windows.Forms.TextBox txtTAMANHO;
        private System.Windows.Forms.DataGridView dgvCacambas;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnPESQUISAR;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.RadioButton rdbTipo;
        private System.Windows.Forms.RadioButton rbdID;
        private System.Windows.Forms.Label lblFiltrar;
    }
}