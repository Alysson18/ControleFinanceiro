
namespace Controle_Financeiro
{
    partial class RelEntrada
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
            this.dgvFinanceiro = new System.Windows.Forms.DataGridView();
            this.lbCountReg = new System.Windows.Forms.Label();
            this.lbValor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.cmbTipoConta = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtPesquisa = new System.Windows.Forms.DateTimePicker();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinanceiro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFinanceiro
            // 
            this.dgvFinanceiro.AllowUserToAddRows = false;
            this.dgvFinanceiro.AllowUserToDeleteRows = false;
            this.dgvFinanceiro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFinanceiro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFinanceiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinanceiro.Location = new System.Drawing.Point(1, 63);
            this.dgvFinanceiro.Name = "dgvFinanceiro";
            this.dgvFinanceiro.ReadOnly = true;
            this.dgvFinanceiro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFinanceiro.Size = new System.Drawing.Size(798, 355);
            this.dgvFinanceiro.TabIndex = 0;
            this.dgvFinanceiro.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFinanceiro_CellEnter);
            // 
            // lbCountReg
            // 
            this.lbCountReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCountReg.AutoSize = true;
            this.lbCountReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountReg.Location = new System.Drawing.Point(12, 424);
            this.lbCountReg.Name = "lbCountReg";
            this.lbCountReg.Size = new System.Drawing.Size(213, 20);
            this.lbCountReg.TabIndex = 15;
            this.lbCountReg.Text = "0 Registros Encontrados!";
            // 
            // lbValor
            // 
            this.lbValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbValor.AutoSize = true;
            this.lbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValor.ForeColor = System.Drawing.Color.Blue;
            this.lbValor.Location = new System.Drawing.Point(528, 424);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(230, 20);
            this.lbValor.TabIndex = 16;
            this.lbValor.Text = "Total de Entradas : R$ 0,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(115, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Grupo.:";
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Items.AddRange(new object[] {
            "Alimentação",
            "Contas",
            "Doações",
            "Educação",
            "Lazer",
            "Salário",
            "Transporte",
            "Outros",
            "Todos"});
            this.cmbGrupo.Location = new System.Drawing.Point(119, 29);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(147, 28);
            this.cmbGrupo.TabIndex = 50;
            // 
            // cmbTipoConta
            // 
            this.cmbTipoConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoConta.FormattingEnabled = true;
            this.cmbTipoConta.Location = new System.Drawing.Point(272, 29);
            this.cmbTipoConta.Name = "cmbTipoConta";
            this.cmbTipoConta.Size = new System.Drawing.Size(147, 28);
            this.cmbTipoConta.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(268, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Conta.:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Data.:";
            // 
            // dtPesquisa
            // 
            this.dtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPesquisa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPesquisa.Location = new System.Drawing.Point(12, 31);
            this.dtPesquisa.Name = "dtPesquisa";
            this.dtPesquisa.Size = new System.Drawing.Size(102, 26);
            this.dtPesquisa.TabIndex = 47;
            // 
            // btExcluir
            // 
            this.btExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExcluir.BackgroundImage = global::Controle_Financeiro.Properties.Resources.excluir;
            this.btExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExcluir.Location = new System.Drawing.Point(742, 19);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(46, 38);
            this.btExcluir.TabIndex = 54;
            this.btExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.Location = new System.Drawing.Point(425, 28);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(107, 29);
            this.btBuscar.TabIndex = 53;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // RelEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbGrupo);
            this.Controls.Add(this.cmbTipoConta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtPesquisa);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.lbCountReg);
            this.Controls.Add(this.dgvFinanceiro);
            this.Name = "RelEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Entradas Por Dia";
            this.Load += new System.EventHandler(this.RelEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinanceiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFinanceiro;
        private System.Windows.Forms.Label lbCountReg;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.ComboBox cmbTipoConta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtPesquisa;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btBuscar;
    }
}