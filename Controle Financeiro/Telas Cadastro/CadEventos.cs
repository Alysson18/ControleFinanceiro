using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Controle_Financeiro
{
    public partial class CadEventos : Form
    {
        public CadEventos()
        {
            InitializeComponent();
        }
        Conexao con = new Conexao();

        private void CadEntrada_Load(object sender, EventArgs e)
        {
          
            con.conectar();

            MySqlCommand com = new MySqlCommand("SELECT id, nome_conta from conta_corrente", con.con);
           
                  
            com.ExecuteNonQuery();
            MySqlDataReader dr = com.ExecuteReader();


            while (dr.Read())
            {
                cmbTipoConta.Items.Add(dr.GetString("Nome_Conta"));
            }
            con.desconctar();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("A Data Não Pode Ser Maior que a Data Atual");
            }
            else
                try
                {
                    con.desconctar();
                    con.conectar();

                    MySqlCommand dbcomand = new MySqlCommand("insert into controlefinanceiro (Id_Usuario, Data, Valor, Descricao, Evento, Mes, Grupo, Conta_Corrente)" +
                        " values(?, ?, ?, ?, ?, ?, ?, ?)", con.con);

                    dbcomand.Parameters.Add("@Id_Usuario", MySqlDbType.Int32).Value = Dados.ID_Usuario;
                    dbcomand.Parameters.Add("@Data", MySqlDbType.VarChar, 45).Value = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    dbcomand.Parameters.Add("@Valor", MySqlDbType.VarChar, 45).Value = tbValor.Text;
                    dbcomand.Parameters.Add("@Descricao", MySqlDbType.VarChar, 45).Value = textBox2.Text;
                    dbcomand.Parameters.Add("@Evento", MySqlDbType.VarChar, 45).Value = cmbEvento.Text;
                    dbcomand.Parameters.Add("@Mes", MySqlDbType.VarChar, 45).Value = dateTimePicker1.Value.ToString("MM/yyyy");
                    dbcomand.Parameters.Add("@Grupo", MySqlDbType.VarChar, 45).Value = cmbGrupo.Text;
                    dbcomand.Parameters.Add("@Conta_Corrente", MySqlDbType.VarChar, 45).Value = cmbTipoConta.Text;


                    dbcomand.ExecuteNonQuery();

                    MessageBox.Show(cmbEvento.Text + " Cadastrada com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.desconctar();
                    tbValor.Clear();
                    textBox2.Clear();
                    cmbGrupo.Text = "";
                    cmbEvento.Text = "";
                    cmbTipoConta.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            con.desconctar();
        }

    }
}
