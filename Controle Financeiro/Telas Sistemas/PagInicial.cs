using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_Financeiro
{
    public partial class PagInicial : Form
    {
        public PagInicial()
        {
            InitializeComponent();
        }
        TelaLogin login = new TelaLogin();
        private void Form1_Load(object sender, EventArgs e)
        {
            lbNome_Usuario.Text = Dados.Nome_Usuario;
            lbBancoConectado.Text = "| Banco Conectado: " + Banco.Conectado;
        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadEventos CadEntra = new CadEventos();
            CadEntra.ShowDialog();

        }

        private void entradasDiariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelEntrada RelEnt = new RelEntrada();
            RelEnt.Show();
        }

        private void saidasDiariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelSaida RelSaida = new RelSaida();
            RelSaida.Show();
        }

        private void mensalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelMes relmes = new RelMes();
            relmes.Show();
        }

        private void PagInicial_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PagInicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void porPeriodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelPeriodo relper = new RelPeriodo();
            relper.Show();
        }

        private void contaCorrenteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Cadastro_Conta_Corrente cadcc = new Cadastro_Conta_Corrente();
            cadcc.ShowDialog();
        }

        private void extratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Extrato_Conta_Corrente ext = new Extrato_Conta_Corrente();
            ext.Show();
        }

        private void transferenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transferencia trans = new Transferencia();
            trans.ShowDialog();
        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Cadastro_User_Click(object sender, EventArgs e)
        {
            Cadastro_Usuario cadUser = new Cadastro_Usuario();
            cadUser.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PagInicial pagIni = new PagInicial();
            this.Hide();

            TelaLogin login = new TelaLogin();
            login.Show();

        }
    }
}

