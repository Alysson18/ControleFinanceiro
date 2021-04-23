
namespace Controle_Financeiro
{
    partial class Cadastro_Usuario
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
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbCadUser = new System.Windows.Forms.CheckBox();
            this.ckbContaCorrente = new System.Windows.Forms.CheckBox();
            this.ckbRelatorios = new System.Windows.Forms.CheckBox();
            this.ckbCadastros = new System.Windows.Forms.CheckBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbNome.Location = new System.Drawing.Point(83, 35);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(202, 26);
            this.tbNome.TabIndex = 0;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbUsuario.Location = new System.Drawing.Point(83, 67);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(202, 26);
            this.tbUsuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario.:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbCadUser);
            this.groupBox1.Controls.Add(this.ckbContaCorrente);
            this.groupBox1.Controls.Add(this.ckbRelatorios);
            this.groupBox1.Controls.Add(this.ckbCadastros);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(83, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 112);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Autorizações ";
            // 
            // ckbCadUser
            // 
            this.ckbCadUser.AutoSize = true;
            this.ckbCadUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCadUser.Location = new System.Drawing.Point(6, 84);
            this.ckbCadUser.Name = "ckbCadUser";
            this.ckbCadUser.Size = new System.Drawing.Size(125, 19);
            this.ckbCadUser.TabIndex = 3;
            this.ckbCadUser.Text = "Cadastrar Usuário";
            this.ckbCadUser.UseVisualStyleBackColor = true;
            // 
            // ckbContaCorrente
            // 
            this.ckbContaCorrente.AutoSize = true;
            this.ckbContaCorrente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbContaCorrente.Location = new System.Drawing.Point(6, 66);
            this.ckbContaCorrente.Name = "ckbContaCorrente";
            this.ckbContaCorrente.Size = new System.Drawing.Size(109, 19);
            this.ckbContaCorrente.TabIndex = 2;
            this.ckbContaCorrente.Text = "Conta-Corrente";
            this.ckbContaCorrente.UseVisualStyleBackColor = true;
            // 
            // ckbRelatorios
            // 
            this.ckbRelatorios.AutoSize = true;
            this.ckbRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbRelatorios.Location = new System.Drawing.Point(6, 47);
            this.ckbRelatorios.Name = "ckbRelatorios";
            this.ckbRelatorios.Size = new System.Drawing.Size(82, 19);
            this.ckbRelatorios.TabIndex = 1;
            this.ckbRelatorios.Text = "Relatórios";
            this.ckbRelatorios.UseVisualStyleBackColor = true;
            // 
            // ckbCadastros
            // 
            this.ckbCadastros.AutoSize = true;
            this.ckbCadastros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCadastros.Location = new System.Drawing.Point(6, 29);
            this.ckbCadastros.Name = "ckbCadastros";
            this.ckbCadastros.Size = new System.Drawing.Size(81, 19);
            this.ckbCadastros.TabIndex = 0;
            this.ckbCadastros.Text = "Cadastros";
            this.ckbCadastros.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCadastrar.Location = new System.Drawing.Point(229, 218);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(121, 29);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // Cadastro_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 259);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.tbNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Cadastro_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Usuario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbCadastros;
        private System.Windows.Forms.CheckBox ckbCadUser;
        private System.Windows.Forms.CheckBox ckbContaCorrente;
        private System.Windows.Forms.CheckBox ckbRelatorios;
        private System.Windows.Forms.Button btnCadastrar;
    }
}