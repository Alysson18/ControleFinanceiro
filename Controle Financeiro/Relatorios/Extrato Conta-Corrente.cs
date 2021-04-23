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
    public partial class Extrato_Conta_Corrente : Form
    {
        public Extrato_Conta_Corrente()
        {
            InitializeComponent();
        }

        Conexao con = new Conexao();
        private void Extrato_Conta_Corrente_Load(object sender, EventArgs e)
        {
            con.desconctar();
            con.conectar();

            MySqlCommand com = new MySqlCommand("SELECT id, nome_conta from conta_corrente", con.con);

            com.ExecuteNonQuery();
            MySqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                cmbTipoConta.Items.Add(dr.GetString("Nome_Conta"));
            }
            con.desconctar();
            cmbTipoConta.Items.Add("Todos");
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            int count = 0, counti = 0, countir = 0;
            double valor = 0, valori = 0;
            con.desconctar();
            con.conectar();

            MySqlDataReader dr;
            MySqlDataReader dri;
            MySqlCommand com;
            MySqlCommand comi;

            if (cmbTipoConta.Text == "Todos")
            {
                com = new MySqlCommand("SELECT Valor FROM controlefinanceiro WHERE Evento = ?", con.con);
                com.Parameters.Add("@Evento", MySqlDbType.VarChar, 45).Value = "Entrada";

                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                dr = com.ExecuteReader();
            }

            else
            {
                com = new MySqlCommand("SELECT Valor FROM controlefinanceiro WHERE Evento = ? And Conta_Corrente = ?", con.con);
                com.Parameters.Add("@Evento", MySqlDbType.VarChar, 45).Value = "Entrada";
                com.Parameters.Add("@Conta_Corrente", MySqlDbType.VarChar, 45).Value = cmbTipoConta.Text;

                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                dr = com.ExecuteReader();
            }


            while (dr.Read())
            {
                count++;
                valor = valor + Convert.ToDouble(dr.GetString("Valor"));
            }

            con.desconctar();
            con.conectar();

            if (cmbTipoConta.Text == "Todos")
            {
                comi = new MySqlCommand("SELECT Valor FROM controlefinanceiro WHERE Evento = ?", con.con);
                comi.Parameters.Add("@Evento", MySqlDbType.VarChar, 45).Value = "Saida";

                comi.CommandType = CommandType.Text;
                comi.ExecuteNonQuery();
                dri = comi.ExecuteReader();
            }
            else
            {
                comi = new MySqlCommand("SELECT Valor FROM controlefinanceiro WHERE Evento = ? And Conta_Corrente = ?", con.con);
                comi.Parameters.Add("@Evento", MySqlDbType.VarChar, 45).Value = "Saida";
                comi.Parameters.Add("@Conta_Corrente", MySqlDbType.VarChar, 45).Value = cmbTipoConta.Text;

                comi.CommandType = CommandType.Text;
                comi.ExecuteNonQuery();
                dri = comi.ExecuteReader();
            }


            while (dri.Read())
            {
                counti++;
                valori = valori + Convert.ToDouble(dri.GetString("Valor"));
            }

            con.desconctar();
            con.conectar();


            if (count >= 1 || counti >= 1)
            {
                lbValorEnt.Text = "Total de Entradas: R$ " + valor.ToString("n2");
                lbValorSai.Text = "Total de Saídas: R$ " + valori.ToString("n2");
                double saldo = valor - valori;

                lbSaldo.Text = "Saldo Restante: R$ " + saldo.ToString("n2");
            }
            else
            {

                MessageBox.Show("Não foram encontrados registros para o mês informado!");
                lbValorEnt.Text = "Total de Entradas: R$ " + 0.00.ToString("n2");
                lbValorSai.Text = "Total de Saídas: R$ " + 0.00.ToString("n2");
                lbSaldo.Text = "Saldo Restante: R$ " + 0.00.ToString("n2");
            }
            con.desconctar();
        }
    }
}

