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
    public partial class RelSaida : Form
    {
        public RelSaida()
        {
            InitializeComponent();
        }
        Conexao con = new Conexao();
        MySqlDataReader dr;
        MySqlDataReader dri;
        MySqlCommand com;
        MySqlCommand comi;
        private void btBuscar_Click(object sender, EventArgs e)
        {
            int count = 0;
            double valor = 0;

            con.desconctar();
            con.conectar();

            if (cmbGrupo.Text == "Todos" && cmbTipoConta.Text == "Todos")
            {
                comi = new MySqlCommand("SELECT ID, Valor, Descricao  as Descrição FROM controlefinanceiro WHERE Data = ? And Evento = ?", con.con);
                comi.Parameters.Add("@Data", MySqlDbType.VarChar, 45).Value = dtPesquisa.Value.ToString("yyyy-MM-dd");
                comi.Parameters.Add("@Evento", MySqlDbType.VarChar, 45).Value = "Saida";

                comi.CommandType = CommandType.Text;
                comi.ExecuteNonQuery();
                dri = comi.ExecuteReader();
            }
            else
            {
                if (cmbTipoConta.Text == "Todos")
                {
                    comi = new MySqlCommand("SELECT ID, Valor, Descricao  as Descrição FROM controlefinanceiro WHERE Data = ? And Evento = ? And Grupo = ?", con.con);
                    comi.Parameters.Add("@Data", MySqlDbType.VarChar, 45).Value = dtPesquisa.Value.ToString("yyyy-MM-dd");
                    comi.Parameters.Add("@Evento", MySqlDbType.VarChar, 45).Value = "Saida";
                    comi.Parameters.Add("@Grupo", MySqlDbType.VarChar, 45).Value = cmbGrupo.Text;

                    comi.CommandType = CommandType.Text;
                    comi.ExecuteNonQuery();
                    dri = comi.ExecuteReader();
                }
                else
                {
                    if (cmbGrupo.Text == "Todos")
                    {
                        comi = new MySqlCommand("SELECT ID, Valor, Descricao  as Descrição FROM controlefinanceiro WHERE Data = ? And Evento = ? And Conta_Corrente = ?", con.con);
                        comi.Parameters.Add("@Data", MySqlDbType.VarChar, 45).Value = dtPesquisa.Value.ToString("yyyy-MM-dd");
                        comi.Parameters.Add("@Evento", MySqlDbType.VarChar, 45).Value = "Saida";
                        comi.Parameters.Add("@Conta_Corrente", MySqlDbType.VarChar, 45).Value = cmbTipoConta.Text;

                        comi.CommandType = CommandType.Text;
                        comi.ExecuteNonQuery();
                        dri = comi.ExecuteReader();
                    }
                    else
                    {
                        comi = new MySqlCommand("SELECT ID, Valor, Descricao  as Descrição FROM controlefinanceiro WHERE Data = ? And Evento = ? And Conta_Corrente = ? And Grupo = ?", con.con);
                        comi.Parameters.Add("@Data", MySqlDbType.VarChar, 45).Value = dtPesquisa.Value.ToString("yyyy-MM-dd");
                        comi.Parameters.Add("@Evento", MySqlDbType.VarChar, 45).Value = "Saida";
                        comi.Parameters.Add("@Conta_Corrente", MySqlDbType.VarChar, 45).Value = cmbTipoConta.Text;
                        comi.Parameters.Add("@Grupo", MySqlDbType.VarChar, 45).Value = cmbGrupo.Text;


                        comi.CommandType = CommandType.Text;
                        comi.ExecuteNonQuery();
                        dri = comi.ExecuteReader();
                    }
                }
            }

            MySqlDataAdapter DtaSaida = new MySqlDataAdapter(comi);
            DataTable DtSaida = new DataTable();

            while (dri.Read())
            {
                count++;

                valor = valor + Convert.ToDouble(dri.GetString("Valor"));
            }

            if (count >= 1)
            {
                con.desconctar();
                con.conectar();

                DtaSaida.Fill(DtSaida);
                dgvFinanceiro.DataSource = DtSaida;
                dgvFinanceiro.Columns[0].Visible = false;
                lbCountReg.Text = dgvFinanceiro.Rows.Count + " Registros Encontrados!";
                lbValor.Text = "Total de Saídas: R$ " + valor.ToString("n2");
            }
            else
            {
                DtSaida.Clear();
                dgvFinanceiro.DataSource = DtSaida;
                MessageBox.Show("Não foram encontrados registros para a data informada!");
                lbCountReg.Text = dgvFinanceiro.Rows.Count + " Registros Encontrados!";
                lbValor.Text = "Total de Saídas: R$ " + 0.00.ToString("n2");
            }

            con.desconctar();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (dgvFinanceiro.Rows.Count > 0)
            {
                if (DialogResult.Yes == MessageBox.Show("Deseja Realmente Excluir o Registro Selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    con.desconctar();
                    con.conectar();
                    MySqlCommand del = new MySqlCommand("Delete FROM controlefinanceiro Where ID = ?", con.con);
                    del.Parameters.Add("@ID", MySqlDbType.VarChar, 45).Value = Dados.ID_Controle;

                    del.CommandType = CommandType.Text;
                    del.ExecuteNonQuery();
                    MySqlDataReader dele = del.ExecuteReader();
                    btBuscar.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("Não Existem Registros Para Serem Excluidos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            con.desconctar();
        }

        private void dgFinanceiro_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Dados.ID_Controle = dgvFinanceiro.Rows[e.RowIndex].Cells["ID"].Value.ToString();
        }

        private void RelSaida_Load(object sender, EventArgs e)
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
    }
}
