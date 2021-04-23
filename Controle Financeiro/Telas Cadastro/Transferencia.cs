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
    public partial class Transferencia : Form
    {
        public Transferencia()
        {
            InitializeComponent();
        }

        Conexao con = new Conexao();
        private void Transferencia_Load(object sender, EventArgs e)
        {
            con.conectar();

            MySqlCommand com = new MySqlCommand("SELECT id, nome_conta from conta_corrente", con.con);


            com.ExecuteNonQuery();
            MySqlDataReader dr = com.ExecuteReader();


            while (dr.Read())
            {
                cmbContaOrigem.Items.Add(dr.GetString("Nome_Conta"));
                cmbContaDestino.Items.Add(dr.GetString("Nome_Conta"));
            }
            con.desconctar();
        }

        private void btTransferir_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("A Data Não Pode Ser Maior que a Data Atual");
            }
            else
            {
                try
                {
                    con.desconctar();
                    con.conectar();

                    MySqlCommand conEntrada = new MySqlCommand("insert into controlefinanceiro (Id_Usuario, Data, Valor, Descricao, Evento, Mes, Grupo, Conta_Corrente)" +
                        " values(?, ?, ?, ?, ?, ?, ?, ?)", con.con);

                    conEntrada.Parameters.Add("@Id_Usuario", MySqlDbType.Int32).Value = Dados.ID_Usuario;
                    conEntrada.Parameters.Add("@Data", MySqlDbType.VarChar, 45).Value = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    conEntrada.Parameters.Add("@Valor", MySqlDbType.VarChar, 45).Value = tbValor.Text;
                    conEntrada.Parameters.Add("@Descricao", MySqlDbType.VarChar, 45).Value = "Transferencia efetuada para a conta: " + cmbContaDestino.Text;
                    conEntrada.Parameters.Add("@Evento", MySqlDbType.VarChar, 45).Value = "Saida";
                    conEntrada.Parameters.Add("@Mes", MySqlDbType.VarChar, 45).Value = dateTimePicker1.Value.ToString("MM/yyyy");
                    conEntrada.Parameters.Add("@Grupo", MySqlDbType.VarChar, 45).Value = "Transferencia";
                    conEntrada.Parameters.Add("@Conta_Corrente", MySqlDbType.VarChar, 45).Value = cmbContaOrigem.Text;


                    conEntrada.ExecuteNonQuery();


                    con.desconctar();
                    con.conectar();

                    MySqlCommand conSaida = new MySqlCommand("insert into controlefinanceiro (Id_Usuario, Data, Valor, Descricao, Evento, Mes, Grupo, Conta_Corrente)" +
                        " values(?, ?, ?, ?, ?, ?, ?, ?)", con.con);

                    conSaida.Parameters.Add("@Id_Usuario", MySqlDbType.Int32).Value = Dados.ID_Usuario;
                    conSaida.Parameters.Add("@Data", MySqlDbType.VarChar, 45).Value = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    conSaida.Parameters.Add("@Valor", MySqlDbType.VarChar, 45).Value = tbValor.Text;
                    conSaida.Parameters.Add("@Descricao", MySqlDbType.VarChar, 45).Value = "Transferencia recebida da conta: " + cmbContaOrigem.Text;
                    conSaida.Parameters.Add("@Evento", MySqlDbType.VarChar, 45).Value = "Entrada";
                    conSaida.Parameters.Add("@Mes", MySqlDbType.VarChar, 45).Value = dateTimePicker1.Value.ToString("MM/yyyy");
                    conSaida.Parameters.Add("@Grupo", MySqlDbType.VarChar, 45).Value = "Transferencia";
                    conSaida.Parameters.Add("@Conta_Corrente", MySqlDbType.VarChar, 45).Value = cmbContaDestino.Text;


                    conSaida.ExecuteNonQuery();


                    con.desconctar();
                    tbValor.Clear();
                    cmbContaOrigem.Text = "";
                    cmbContaDestino.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



                MessageBox.Show("Transferencia Realizada com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            con.desconctar();
        }
    }
}
