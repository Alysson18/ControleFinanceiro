namespace Controle_Financeiro
{
    partial class PagInicial
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_Cadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Relatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasDiariasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saidasDiariasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porPeriodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Conta_Corrente = new System.Windows.Forms.ToolStripMenuItem();
            this.contaCorrenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extratoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Cadastro_User = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stUsuarioConectado = new System.Windows.Forms.StatusStrip();
            this.lbNome_Usuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbBancoConectado = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.stUsuarioConectado.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Cadastro,
            this.Menu_Relatorio,
            this.Menu_Conta_Corrente,
            this.configuraçõesToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(737, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_Cadastro
            // 
            this.Menu_Cadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradasToolStripMenuItem});
            this.Menu_Cadastro.Name = "Menu_Cadastro";
            this.Menu_Cadastro.Size = new System.Drawing.Size(74, 20);
            this.Menu_Cadastro.Text = "Cadastros";
            // 
            // entradasToolStripMenuItem
            // 
            this.entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
            this.entradasToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.entradasToolStripMenuItem.Text = "Cadastro Financeiro";
            this.entradasToolStripMenuItem.Click += new System.EventHandler(this.entradasToolStripMenuItem_Click);
            // 
            // Menu_Relatorio
            // 
            this.Menu_Relatorio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradasDiariasToolStripMenuItem,
            this.saidasDiariasToolStripMenuItem,
            this.mensalToolStripMenuItem,
            this.porPeriodoToolStripMenuItem});
            this.Menu_Relatorio.Name = "Menu_Relatorio";
            this.Menu_Relatorio.Size = new System.Drawing.Size(74, 20);
            this.Menu_Relatorio.Text = "Relatórios";
            // 
            // entradasDiariasToolStripMenuItem
            // 
            this.entradasDiariasToolStripMenuItem.Name = "entradasDiariasToolStripMenuItem";
            this.entradasDiariasToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.entradasDiariasToolStripMenuItem.Text = "Entradas Diarias";
            this.entradasDiariasToolStripMenuItem.Click += new System.EventHandler(this.entradasDiariasToolStripMenuItem_Click);
            // 
            // saidasDiariasToolStripMenuItem
            // 
            this.saidasDiariasToolStripMenuItem.Name = "saidasDiariasToolStripMenuItem";
            this.saidasDiariasToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.saidasDiariasToolStripMenuItem.Text = "Saidas Diarias";
            this.saidasDiariasToolStripMenuItem.Click += new System.EventHandler(this.saidasDiariasToolStripMenuItem_Click);
            // 
            // mensalToolStripMenuItem
            // 
            this.mensalToolStripMenuItem.Name = "mensalToolStripMenuItem";
            this.mensalToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.mensalToolStripMenuItem.Text = "Mensal";
            this.mensalToolStripMenuItem.Click += new System.EventHandler(this.mensalToolStripMenuItem_Click);
            // 
            // porPeriodoToolStripMenuItem
            // 
            this.porPeriodoToolStripMenuItem.Name = "porPeriodoToolStripMenuItem";
            this.porPeriodoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.porPeriodoToolStripMenuItem.Text = "Por Periodo";
            this.porPeriodoToolStripMenuItem.Click += new System.EventHandler(this.porPeriodoToolStripMenuItem_Click);
            // 
            // Menu_Conta_Corrente
            // 
            this.Menu_Conta_Corrente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contaCorrenteToolStripMenuItem,
            this.transferenciaToolStripMenuItem,
            this.extratoToolStripMenuItem});
            this.Menu_Conta_Corrente.Name = "Menu_Conta_Corrente";
            this.Menu_Conta_Corrente.Size = new System.Drawing.Size(105, 20);
            this.Menu_Conta_Corrente.Text = "Conta- Corrente";
            // 
            // contaCorrenteToolStripMenuItem
            // 
            this.contaCorrenteToolStripMenuItem.Name = "contaCorrenteToolStripMenuItem";
            this.contaCorrenteToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.contaCorrenteToolStripMenuItem.Text = "Cadastro de Conta";
            this.contaCorrenteToolStripMenuItem.Click += new System.EventHandler(this.contaCorrenteToolStripMenuItem_Click_1);
            // 
            // transferenciaToolStripMenuItem
            // 
            this.transferenciaToolStripMenuItem.Name = "transferenciaToolStripMenuItem";
            this.transferenciaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.transferenciaToolStripMenuItem.Text = "Transferencia";
            this.transferenciaToolStripMenuItem.Click += new System.EventHandler(this.transferenciaToolStripMenuItem_Click);
            // 
            // extratoToolStripMenuItem
            // 
            this.extratoToolStripMenuItem.Name = "extratoToolStripMenuItem";
            this.extratoToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.extratoToolStripMenuItem.Text = "Extrato";
            this.extratoToolStripMenuItem.Click += new System.EventHandler(this.extratoToolStripMenuItem_Click);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Cadastro_User,
            this.alterarSenhaToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            this.configuraçõesToolStripMenuItem.Click += new System.EventHandler(this.configuraçõesToolStripMenuItem_Click);
            // 
            // Menu_Cadastro_User
            // 
            this.Menu_Cadastro_User.Name = "Menu_Cadastro_User";
            this.Menu_Cadastro_User.Size = new System.Drawing.Size(171, 22);
            this.Menu_Cadastro_User.Text = "Cadastrar Usuario";
            this.Menu_Cadastro_User.Click += new System.EventHandler(this.Menu_Cadastro_User_Click);
            // 
            // alterarSenhaToolStripMenuItem
            // 
            this.alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            this.alterarSenhaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.alterarSenhaToolStripMenuItem.Text = "Alterar Senha";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // stUsuarioConectado
            // 
            this.stUsuarioConectado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stUsuarioConectado.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stUsuarioConectado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbNome_Usuario,
            this.lbBancoConectado});
            this.stUsuarioConectado.Location = new System.Drawing.Point(0, 428);
            this.stUsuarioConectado.Name = "stUsuarioConectado";
            this.stUsuarioConectado.Size = new System.Drawing.Size(737, 22);
            this.stUsuarioConectado.TabIndex = 1;
            this.stUsuarioConectado.Text = "tetetegdgfgdh";
            // 
            // lbNome_Usuario
            // 
            this.lbNome_Usuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome_Usuario.Name = "lbNome_Usuario";
            this.lbNome_Usuario.Size = new System.Drawing.Size(56, 17);
            this.lbNome_Usuario.Text = "Usuario";
            // 
            // lbBancoConectado
            // 
            this.lbBancoConectado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBancoConectado.Name = "lbBancoConectado";
            this.lbBancoConectado.Size = new System.Drawing.Size(48, 17);
            this.lbBancoConectado.Text = "Banco";
            // 
            // PagInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.Controls.Add(this.stUsuarioConectado);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PagInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PagInicial_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PagInicial_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.stUsuarioConectado.ResumeLayout(false);
            this.stUsuarioConectado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem entradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasDiariasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saidasDiariasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mensalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porPeriodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contaCorrenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extratoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarSenhaToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem Menu_Cadastro;
        public System.Windows.Forms.ToolStripMenuItem Menu_Relatorio;
        public System.Windows.Forms.ToolStripMenuItem Menu_Conta_Corrente;
        public System.Windows.Forms.ToolStripMenuItem Menu_Cadastro_User;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.StatusStrip stUsuarioConectado;
        private System.Windows.Forms.ToolStripStatusLabel lbNome_Usuario;
        private System.Windows.Forms.ToolStripStatusLabel lbBancoConectado;
    }
}

