namespace DISKCACAMBA
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtGrvCLIENTES = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnINSERIR = new System.Windows.Forms.Button();
            this.btnEDITAR = new System.Windows.Forms.Button();
            this.btnREMOVER = new System.Windows.Forms.Button();
            this.btnSAIR = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtMULTA = new System.Windows.Forms.TextBox();
            this.txtDIAS = new System.Windows.Forms.TextBox();
            this.txtNOME = new System.Windows.Forms.TextBox();
            this.txtTELEFONE = new System.Windows.Forms.TextBox();
            this.txtENDERECO = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrvCLIENTES)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrvCLIENTES
            // 
            this.dtGrvCLIENTES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrvCLIENTES.Location = new System.Drawing.Point(24, 225);
            this.dtGrvCLIENTES.Name = "dtGrvCLIENTES";
            this.dtGrvCLIENTES.Size = new System.Drawing.Size(764, 150);
            this.dtGrvCLIENTES.TabIndex = 0;
            this.dtGrvCLIENTES.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(43, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(266, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "ENDEREÇO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(31, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "DIAS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(283, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "NOME";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(266, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "TELEFONE";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(20, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "MULTA";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnINSERIR
            // 
            this.btnINSERIR.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnINSERIR.Location = new System.Drawing.Point(67, 409);
            this.btnINSERIR.Name = "btnINSERIR";
            this.btnINSERIR.Size = new System.Drawing.Size(109, 29);
            this.btnINSERIR.TabIndex = 11;
            this.btnINSERIR.Text = "INSERIR";
            this.btnINSERIR.UseVisualStyleBackColor = true;
            this.btnINSERIR.Click += new System.EventHandler(this.btnINSERIR_Click);
            // 
            // btnEDITAR
            // 
            this.btnEDITAR.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEDITAR.Location = new System.Drawing.Point(256, 409);
            this.btnEDITAR.Name = "btnEDITAR";
            this.btnEDITAR.Size = new System.Drawing.Size(109, 29);
            this.btnEDITAR.TabIndex = 12;
            this.btnEDITAR.Text = "EDITAR";
            this.btnEDITAR.UseVisualStyleBackColor = true;
            this.btnEDITAR.Click += new System.EventHandler(this.btnEDITAR_Click);
            // 
            // btnREMOVER
            // 
            this.btnREMOVER.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnREMOVER.Location = new System.Drawing.Point(445, 409);
            this.btnREMOVER.Name = "btnREMOVER";
            this.btnREMOVER.Size = new System.Drawing.Size(109, 29);
            this.btnREMOVER.TabIndex = 13;
            this.btnREMOVER.Text = "REMOVER";
            this.btnREMOVER.UseVisualStyleBackColor = true;
            this.btnREMOVER.Click += new System.EventHandler(this.btnREMOVER_Click);
            // 
            // btnSAIR
            // 
            this.btnSAIR.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSAIR.Location = new System.Drawing.Point(634, 409);
            this.btnSAIR.Name = "btnSAIR";
            this.btnSAIR.Size = new System.Drawing.Size(109, 29);
            this.btnSAIR.TabIndex = 14;
            this.btnSAIR.Text = "SAIR";
            this.btnSAIR.UseVisualStyleBackColor = true;
            this.btnSAIR.Click += new System.EventHandler(this.btnSAIR_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtID.Location = new System.Drawing.Point(118, 21);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 32);
            this.txtID.TabIndex = 15;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtMULTA
            // 
            this.txtMULTA.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtMULTA.Location = new System.Drawing.Point(118, 80);
            this.txtMULTA.Name = "txtMULTA";
            this.txtMULTA.Size = new System.Drawing.Size(100, 32);
            this.txtMULTA.TabIndex = 16;
            this.txtMULTA.TextChanged += new System.EventHandler(this.txtMULTA_TextChanged);
            // 
            // txtDIAS
            // 
            this.txtDIAS.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtDIAS.Location = new System.Drawing.Point(118, 146);
            this.txtDIAS.Name = "txtDIAS";
            this.txtDIAS.Size = new System.Drawing.Size(100, 32);
            this.txtDIAS.TabIndex = 17;
            this.txtDIAS.TextChanged += new System.EventHandler(this.txtDIAS_TextChanged);
            // 
            // txtNOME
            // 
            this.txtNOME.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtNOME.Location = new System.Drawing.Point(396, 22);
            this.txtNOME.Name = "txtNOME";
            this.txtNOME.Size = new System.Drawing.Size(180, 32);
            this.txtNOME.TabIndex = 18;
            this.txtNOME.TextChanged += new System.EventHandler(this.txtNOME_TextChanged);
            // 
            // txtTELEFONE
            // 
            this.txtTELEFONE.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtTELEFONE.Location = new System.Drawing.Point(396, 82);
            this.txtTELEFONE.Name = "txtTELEFONE";
            this.txtTELEFONE.Size = new System.Drawing.Size(180, 32);
            this.txtTELEFONE.TabIndex = 19;
            // 
            // txtENDERECO
            // 
            this.txtENDERECO.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtENDERECO.Location = new System.Drawing.Point(396, 144);
            this.txtENDERECO.Name = "txtENDERECO";
            this.txtENDERECO.Size = new System.Drawing.Size(180, 32);
            this.txtENDERECO.TabIndex = 20;
            this.txtENDERECO.TextChanged += new System.EventHandler(this.txtENDERECO_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(795, 505);
            this.Controls.Add(this.txtENDERECO);
            this.Controls.Add(this.txtTELEFONE);
            this.Controls.Add(this.txtNOME);
            this.Controls.Add(this.txtDIAS);
            this.Controls.Add(this.txtMULTA);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnSAIR);
            this.Controls.Add(this.btnREMOVER);
            this.Controls.Add(this.btnEDITAR);
            this.Controls.Add(this.btnINSERIR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGrvCLIENTES);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrvCLIENTES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrvCLIENTES;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnINSERIR;
        private System.Windows.Forms.Button btnEDITAR;
        private System.Windows.Forms.Button btnREMOVER;
        private System.Windows.Forms.Button btnSAIR;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtMULTA;
        private System.Windows.Forms.TextBox txtDIAS;
        private System.Windows.Forms.TextBox txtNOME;
        private System.Windows.Forms.TextBox txtTELEFONE;
        private System.Windows.Forms.TextBox txtENDERECO;
    }
}

