
namespace Controle_Financeiro
{
    partial class RelMes
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbValorEnt = new System.Windows.Forms.Label();
            this.lbCountReg = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgvFinanceiro = new System.Windows.Forms.DataGridView();
            this.lbValorSai = new System.Windows.Forms.Label();
            this.lbSaldo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.cmbTipoConta = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinanceiro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mês:";
            // 
            // lbValorEnt
            // 
            this.lbValorEnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbValorEnt.AutoSize = true;
            this.lbValorEnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorEnt.ForeColor = System.Drawing.Color.Blue;
            this.lbValorEnt.Location = new System.Drawing.Point(426, 580);
            this.lbValorEnt.Name = "lbValorEnt";
            this.lbValorEnt.Size = new System.Drawing.Size(230, 20);
            this.lbValorEnt.TabIndex = 22;
            this.lbValorEnt.Text = "Total de Entradas : R$ 0,00";
            // 
            // lbCountReg
            // 
            this.lbCountReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCountReg.AutoSize = true;
            this.lbCountReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountReg.Location = new System.Drawing.Point(12, 580);
            this.lbCountReg.Name = "lbCountReg";
            this.lbCountReg.Size = new System.Drawing.Size(208, 20);
            this.lbCountReg.TabIndex = 21;
            this.lbCountReg.Text = "0 Registros Encontrados";
            // 
            // btBuscar
            // 
            this.btBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.Location = new System.Drawing.Point(426, 29);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(110, 28);
            this.btBuscar.TabIndex = 20;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(102, 26);
            this.dateTimePicker1.TabIndex = 19;
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
            this.dgvFinanceiro.Size = new System.Drawing.Size(1209, 511);
            this.dgvFinanceiro.TabIndex = 18;
            this.dgvFinanceiro.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFinanceiro_CellEnter);
            // 
            // lbValorSai
            // 
            this.lbValorSai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbValorSai.AutoSize = true;
            this.lbValorSai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorSai.ForeColor = System.Drawing.Color.Red;
            this.lbValorSai.Location = new System.Drawing.Point(701, 580);
            this.lbValorSai.Name = "lbValorSai";
            this.lbValorSai.Size = new System.Drawing.Size(212, 20);
            this.lbValorSai.TabIndex = 24;
            this.lbValorSai.Text = "Total de Saídas : R$ 0,00";
            // 
            // lbSaldo
            // 
            this.lbSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSaldo.AutoSize = true;
            this.lbSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaldo.ForeColor = System.Drawing.Color.Green;
            this.lbSaldo.Location = new System.Drawing.Point(954, 580);
            this.lbSaldo.Name = "lbSaldo";
            this.lbSaldo.Size = new System.Drawing.Size(212, 20);
            this.lbSaldo.TabIndex = 25;
            this.lbSaldo.Text = "Saldo Restante : R$ 0,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 29;
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
            this.cmbGrupo.Location = new System.Drawing.Point(120, 29);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(147, 28);
            this.cmbGrupo.TabIndex = 27;
            // 
            // cmbTipoConta
            // 
            this.cmbTipoConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoConta.FormattingEnabled = true;
            this.cmbTipoConta.Location = new System.Drawing.Point(273, 29);
            this.cmbTipoConta.Name = "cmbTipoConta";
            this.cmbTipoConta.Size = new System.Drawing.Size(147, 28);
            this.cmbTipoConta.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(269, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Conta.:";
            // 
            // btExcluir
            // 
            this.btExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExcluir.BackgroundImage = global::Controle_Financeiro.Properties.Resources.excluir;
            this.btExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExcluir.Location = new System.Drawing.Point(1153, 19);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(46, 38);
            this.btExcluir.TabIndex = 42;
            this.btExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // RelMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 606);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbGrupo);
            this.Controls.Add(this.cmbTipoConta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbSaldo);
            this.Controls.Add(this.lbValorSai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbValorEnt);
            this.Controls.Add(this.lbCountReg);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgvFinanceiro);
            this.Name = "RelMes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Mensal";
            this.Load += new System.EventHandler(this.RelMes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinanceiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbValorEnt;
        private System.Windows.Forms.Label lbCountReg;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgvFinanceiro;
        private System.Windows.Forms.Label lbValorSai;
        private System.Windows.Forms.Label lbSaldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.ComboBox cmbTipoConta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btExcluir;
    }
}