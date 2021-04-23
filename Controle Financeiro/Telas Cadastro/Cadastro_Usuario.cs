using MySql.Data.MySqlClient;
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
    public partial class Cadastro_Usuario : Form
    {
        public Cadastro_Usuario()
        {
            InitializeComponent();
        }
        Conexao con = new Conexao();

        int TamanhoDaSenha = 8;
        private void ValidaTamanhoSenha()
        {
            if (!string.IsNullOrWhiteSpace("6"))
            {
                TamanhoDaSenha = 6;
                if (TamanhoDaSenha > 99)
                {
                    TamanhoDaSenha = 99;

                }
                if (TamanhoDaSenha > 6)
                {
                    TamanhoDaSenha = 6;

                }
            }
        }
        string senha;

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ValidaTamanhoSenha();
            string validar = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            try
            {
                StringBuilder strbld = new StringBuilder(100);
                Random random = new Random();
                while (0 < TamanhoDaSenha--)
                {
                    strbld.Append(validar[random.Next(validar.Length)]);
                }
                senha = strbld.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {

                con.conectar();

                MySqlCommand dbcomand = new MySqlCommand("insert into tb_users (Nome, User, Password, Menu_Cadastro, Menu_Relatorios, Menu_ContaCorrente, Cadastra_Usuario)" +
                    " values(?, ?, ?, ?, ?, ?, ?)", con.con);

                dbcomand.Parameters.Add("@Nome", MySqlDbType.VarChar, 100).Value = tbNome.Text;
                dbcomand.Parameters.Add("@User", MySqlDbType.VarChar, 45).Value = tbUsuario.Text;
                dbcomand.Parameters.Add("@Password", MySqlDbType.VarChar, 45).Value = senha;

                if (ckbCadastros.Checked == true)
                    dbcomand.Parameters.Add("@Menu_Cadastro", MySqlDbType.VarChar, 45).Value = "Sim";
                else
                    dbcomand.Parameters.Add("@Menu_Cadastro", MySqlDbType.VarChar, 45).Value = "Nao";

                if (ckbRelatorios.Checked == true)
                    dbcomand.Parameters.Add("@Menu_Relatorios", MySqlDbType.VarChar, 45).Value = "Sim";
                else
                    dbcomand.Parameters.Add("@Menu_Relatorios", MySqlDbType.VarChar, 45).Value = "Nao";

                if (ckbContaCorrente.Checked == true)
                    dbcomand.Parameters.Add("@Menu_ContaCorrente", MySqlDbType.VarChar, 45).Value = "Sim";
                else
                    dbcomand.Parameters.Add("@Menu_ContaCorrente", MySqlDbType.VarChar, 45).Value = "Nao";

                if (ckbCadUser.Checked == true)
                    dbcomand.Parameters.Add("@Cadastra_Usuario", MySqlDbType.VarChar, 45).Value = "Sim";
                else
                    dbcomand.Parameters.Add("@Cadastra_Usuario", MySqlDbType.VarChar, 45).Value = "Nao";

                dbcomand.ExecuteNonQuery();

                MessageBox.Show("Cadastrado com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("A Senha do Usuário: " + tbUsuario.Text + " é: " + senha , "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.desconctar();
                tbNome.Clear();
                tbUsuario.Clear();

                ckbCadastros.Checked = false;
                ckbRelatorios.Checked = false;
                ckbContaCorrente.Checked = false;
                ckbCadUser.Checked = false;
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.desconctar();



        }
    }
}
