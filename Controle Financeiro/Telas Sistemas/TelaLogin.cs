using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controle_Financeiro.Classes;
using Controle_Financeiro.Telas_Sistemas;
using Gerador_de_Licença;
using Microsoft.Win32;
using MySql.Data.MySqlClient;

namespace Controle_Financeiro
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();

        }


        string Serial_Key;

        MySqlDataReader dri;
        string Menu_Cadastro, Menu_Relatorios, Codigo_Cliente, Situacao_Cliente,
               Menu_Conta_Corrente, Menu_Cadastro_Usuario;

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void TelaLogin_Load(object sender, EventArgs e)
        {
            String[] line0fContents = File.ReadAllLines(@"C:\Windows\banco.ini");

            foreach (var line in line0fContents)
            {
                String[] banco = line.Split(',');
                cmbBanco.Items.Add(banco[0]);
                Dados.Codigo_Cliente = banco[1];
            }    


            var repositorio = new CadastroRepositorio();
            var SituacaoTask = repositorio.GetSituacaoCadastrosAsync(Dados.Codigo_Cliente);
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            Conexao con = new Conexao();
            int count = 0;
            con.conectar();

            try
            {
                MySqlCommand comi = new MySqlCommand("SELECT * FROM tb_users WHERE User = ? And Password = ?", con.con);
                comi.Parameters.Add("@User", MySqlDbType.VarChar, 45).Value = tbUser.Text;
                comi.Parameters.Add("@Password", MySqlDbType.VarChar, 45).Value = tbPassword.Text;

                comi.CommandType = CommandType.Text;
                comi.ExecuteNonQuery();
                dri = comi.ExecuteReader();


                MySqlDataAdapter DtaSaida = new MySqlDataAdapter(comi);
                DataTable DtSaida = new DataTable();

                while (dri.Read())
                {
                    count++;
                    Dados.ID_Usuario = dri.GetInt32("Id");
                    Dados.Nome_Usuario = dri.GetString("Nome");
                    Menu_Cadastro = dri.GetString("Menu_Cadastro").ToString();
                    Menu_Relatorios = dri.GetString("Menu_Relatorios").ToString();
                    Menu_Conta_Corrente = dri.GetString("Menu_ContaCorrente").ToString();
                    Menu_Cadastro_Usuario = dri.GetString("Cadastra_Usuario").ToString();
                }


                con.desconctar();

                RegistryKey rk = Registry.CurrentUser;

                RegistryKey sk1 = rk.OpenSubKey("SOFTWARE\\" + Application.ProductName);

                if (sk1 != null)
                {
                    Serial_Key = (string)sk1.GetValue("Licença");

                    if (Serial_Key == "")
                    {
                        Serial_Key = "KSIDN-MNDOJ-TYVXK-NTACZ";
                    }
                }
                else
                {
                    Serial_Key = "KSIDN-MNDOJ-TYVXK-NTACZ";
                }

                if (Serial_Key == null)
                {
                    Serial_Key = "KSIDN-MNDOJ-TYVXK-NTACZ";
                }


                SKGL.Validate validar = new SKGL.Validate();
                validar.secretPhase = "981965692";
                validar.Key = Serial_Key;

                if (count == 1)
                {
                    if (validar.ExpireDate >= DateTime.Now)
                    {

                        TelaLogin login = new TelaLogin();
                        this.Hide();
                        PagInicial Menu = new PagInicial();

                        if (Menu_Cadastro == "Sim")
                            Menu.Menu_Cadastro.Visible = true;
                        else
                            Menu.Menu_Cadastro.Visible = false;

                        if (Menu_Relatorios == "Sim")
                            Menu.Menu_Relatorio.Visible = true;
                        else
                            Menu.Menu_Relatorio.Visible = false;

                        if (Menu_Conta_Corrente == "Sim")
                            Menu.Menu_Conta_Corrente.Visible = true;
                        else
                            Menu.Menu_Conta_Corrente.Visible = false;

                        if (Menu_Cadastro_Usuario == "Sim")
                            Menu.Menu_Cadastro_User.Visible = true;
                        else
                            Menu.Menu_Cadastro_User.Visible = false;

                        Menu.Show();

                    }
                    else
                    {
                        if (Dados.Situacao == "Ativo")
                        {
                            SKGL.Generate key = new SKGL.Generate();
                            key.secretPhase = "981965692";
                            string Serial = key.doKey(30);

                            SKGL.Validate valida = new SKGL.Validate();
                            validar.secretPhase = "981965692";
                            validar.Key = Serial;

                            RegistryKey rke = Registry.CurrentUser;
                            RegistryKey ske = rke.CreateSubKey("SOFTWARE\\" + Application.ProductName);
                            ske.SetValue("Licença", Serial);


                            TelaLogin login = new TelaLogin();
                            this.Hide();
                            PagInicial Menu = new PagInicial();

                            if (Menu_Cadastro == "Sim")
                                Menu.Menu_Cadastro.Visible = true;
                            else
                                Menu.Menu_Cadastro.Visible = false;

                            if (Menu_Relatorios == "Sim")
                                Menu.Menu_Relatorio.Visible = true;
                            else
                                Menu.Menu_Relatorio.Visible = false;

                            if (Menu_Conta_Corrente == "Sim")
                                Menu.Menu_Conta_Corrente.Visible = true;
                            else
                                Menu.Menu_Conta_Corrente.Visible = false;

                            if (Menu_Cadastro_Usuario == "Sim")
                                Menu.Menu_Cadastro_User.Visible = true;
                            else
                                Menu.Menu_Cadastro_User.Visible = false;

                            Menu.Show();
                        }
                        else
                        {
                            AdicionarLicenca add = new AdicionarLicenca();
                            add.ShowDialog();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Usuario ou Senha Invalidos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Banco de Dados não encontrado " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cbBanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            Banco.Conectado = cmbBanco.Text;
        }
    }
}
