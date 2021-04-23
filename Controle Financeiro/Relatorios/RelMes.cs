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
    public partial class RelMes : Form
    {
        public RelMes()
        {
            InitializeComponent();
        }
        string busca;
        Conexao con = new Conexao();

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

            if (cmbGrupo.Text == "Todos" && cmbTipoConta.Text == "Todos")
            {
                com = new MySqlCommand("SELECT Valor FROM controlefinanceiro WHERE Mes = ? And Evento = ?", con.con);
                com.Parameters.Add("@Mes", MySqlDbType.VarChar, 45).Value = dateTimePicker1.Text;
                com.Parameters.Add("@Evento", MySqlDbType.VarChar, 45).Value = "Entrada";

                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                dr = com.ExecuteReader();
            }
            else
            {
                if (cmbTipoConta.Text == "Todos")
                {
                    com = new MySqlCommand("SELECT Valor FROM controlefinanceiro WHERE Mes = ? And Evento = ? And Grupo = ?", con.con);
                    com.Parameters.Add("@Mes", MySqlDbType.VarChar, 45).Value = dateTimePicker1.Text;
                    com.Parameters.Add("@Evento", MySqlDbType.VarChar, 45).Value = "Entrada";
                    com.Parameters.Add("@Grupo", MySqlDbType.VarChar, 45).Value = cmbGrupo.Text;

                    com.CommandType = CommandType.Text;
                    com.ExecuteNonQuery();
                    dr = com.ExecuteReader();
                }
                else
                {
                    if (cmbGrupo.Text == "Todos")
                    {
                        com = new MySqlCommand("SELECT Valor FROM controlefinanceiro WHERE Mes = ? And Evento = ? And Conta_Corrente = ?", con.con);
                        com.Parameters.Add("@Mes", MySqlDbType.VarChar, 45).Value = dateTimePicker1.Text;
                        com.Parameters.Add("@Evento", MySqlDbType.VarChar, 45).Value = "Entrada";
                        com.Parameters.Add("@Conta_Corrente", MySqlDbType.VarChar, 45).Value = cmbTipoConta.Text;

                        com.CommandType = CommandType.Text;
                        com.ExecuteNonQuery();
                        dr = com.ExecuteReader();
                    }
                    else
                    {
                        com = new MySqlCommand("SELECT Valor FROM controlefinanceiro WHERE Mes = ? And Evento = ? And Conta_Corrente = ? And Grupo = ?", con.con);
                        com.Parameters.Add("@Mes", MySqlDbType.VarChar, 45).Value = dateTimePicker1.Text;
                        com.Parameters.Add("@Evento", MySqlDbType.VarChar, 45).Value = "Entrada";
                        com.Parameters.Add("@Conta_Corrente", MySqlDbType.VarChar, 45).Value = cmbTipoConta.Text;
                        com.Parameters.Add("@Grupo", MySqlDbType.VarChar, 45).Value = cmbGrupo.Text;

                        com.CommandType = CommandType.Text;
                        com.ExecuteNonQuery();
                        dr = com.ExecuteReader();
                    }
                }
            }

            while (dr.Read())
            {
                count++;
                valor = valor + Convert.ToDouble(dr.GetString("Valor"));
            }
            con.desconctar();

            con.conectar();

            if (cmbGrupo.Text == "Todos" && cmbTipoConta.Text == "Todos")
            {
                comi = new MySqlCommand("SELECT Valor FROM controlefinanceiro WHERE Mes = ? And Evento = ?", con.con);
                comi.Parameters.Add("@Mes", MySqlDbType.VarChar, 45).Value = dateTimePicker1.Text;
                comi.Parameters.Add("@Evento", MySqlDbType.VarChar, 45).Value = "Saida";

                comi.CommandType = CommandType.Text;
                comi.ExecuteNonQuery();
                dri = comi.ExecuteReader();
            }
            else
            {
                if (cmbTipoConta.Text == "Todos")
                {
                    comi = new MySqlCommand("SELECT Valor FROM controlefinanceiro WHERE Mes = ? And Evento = ? And Grupo = ?", con.con);
                    comi.Parameters.Add("@Mes", MySqlDbType.VarChar, 45).Value = dateTimePicker1.Text;
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
                        comi = new MySqlCommand("SELECT Valor FROM controlefinanceiro WHERE Mes = ? And Evento = ? And Conta_Corrente = ?", con.con);
                        comi.Parameters.Add("@Mes", MySqlDbType.VarChar, 45).Value = dateTimePicker1.Text;
                        comi.Parameters.Add("@Evento", MySqlDbType.VarChar, 45).Value = "Saida";
                        comi.Parameters.Add("@Conta_Corrente", MySqlDbType.VarChar, 45).Value = cmbTipoConta.Text;

                        comi.CommandType = CommandType.Text;
                        comi.ExecuteNonQuery();
                        dri = comi.ExecuteReader();
                    }
                    else
                    {
                        comi = new MySqlCommand("SELECT Valor FROM controlefinanceiro WHERE Mes = ? And Evento = ? And Conta_Corrente = ? And Grupo = ?", con.con);
                        comi.Parameters.Add("@Mes", MySqlDbType.VarChar, 45).Value = dateTimePicker1.Text;
                        comi.Parameters.Add("@Evento", MySqlDbType.VarChar, 45).Value = "Saida";
                        comi.Parameters.Add("@Conta_Corrente", MySqlDbType.VarChar, 45).Value = cmbTipoConta.Text;
                        comi.Parameters.Add("@Grupo", MySqlDbType.VarChar, 45).Value = cmbGrupo.Text;


                        comi.CommandType = CommandType.Text;
                        comi.ExecuteNonQuery();
                        dri = comi.ExecuteReader();
                    }
                }
            }

            while (dri.Read())
            {
                counti++;
                valori = valori + Convert.ToDouble(dri.GetString("Valor"));
            }

            con.desconctar();
            con.conectar();

            if (cmbGrupo.Text == "Todos" && cmbTipoConta.Text == "Todos")
            {
                busca = "SELECT ID, Data, Valor, Descricao As Descrição, Evento FROM controlefinanceiro WHERE Mes = ? order by Id";
            }
            else
            {
                if (cmbGrupo.Text == "Todos")
                {
                    busca = "SELECT ID, Data, Valor, Descricao As Descrição, Evento FROM controlefinanceiro WHERE Mes = ? And Conta_Corrente = ? order by Id";
                }
                else
                {
                    if (cmbTipoConta.Text == "Todos")
                    {
                        busca = "SELECT ID, Data, Valor, Descricao As Descrição, Evento FROM controlefinanceiro WHERE Mes = ? And Grupo = ? order by Id";
                    }
                    else
                    {
                        busca = "SELECT ID, Data, Valor, Descricao As Descrição, Evento FROM controlefinanceiro WHERE Mes = ? And Conta_Corrente = ? And Grupo = ? order by Id";
                    }
                }
            }

            MySqlDataReader drit;
            DataTable dtrelt;
            MySqlDataAdapter dtrel;


            if (cmbGrupo.Text == "Todos" && cmbTipoConta.Text == "Todos")
            {
                MySqlCommand comit = new MySqlCommand(busca, con.con);
                comit.Parameters.Add("@Mes", MySqlDbType.VarChar, 45).Value = dateTimePicker1.Text;

                comit.CommandType = CommandType.Text;
                comit.ExecuteNonQuery();
                drit = comit.ExecuteReader();

                dtrel = new MySqlDataAdapter(comit);
                dtrelt = new DataTable();
            }
            else
            {
                if (cmbGrupo.Text == "Todos")
                {
                    MySqlCommand comit = new MySqlCommand(busca, con.con);
                    comit.Parameters.Add("@Mes", MySqlDbType.VarChar, 45).Value = dateTimePicker1.Text;
                    comit.Parameters.Add("@Conta_Corrente", MySqlDbType.VarChar, 45).Value = cmbTipoConta.Text;

                    comit.CommandType = CommandType.Text;
                    comit.ExecuteNonQuery();
                    drit = comit.ExecuteReader();

                    dtrel = new MySqlDataAdapter(comit);
                    dtrelt = new DataTable();

                }
                else
                {
                    if (cmbTipoConta.Text == "Todos")
                    {

                        MySqlCommand comit = new MySqlCommand(busca, con.con);
                        comit.Parameters.Add("@Mes", MySqlDbType.VarChar, 45).Value = dateTimePicker1.Text;
                        comit.Parameters.Add("@Grupo", MySqlDbType.VarChar, 45).Value = cmbGrupo.Text;

                        comit.CommandType = CommandType.Text;
                        comit.ExecuteNonQuery();
                        drit = comit.ExecuteReader();

                        dtrel = new MySqlDataAdapter(comit);
                        dtrelt = new DataTable();
                    }
                    else
                    {
                        MySqlCommand comit = new MySqlCommand(busca, con.con);
                        comit.Parameters.Add("@Mes", MySqlDbType.VarChar, 45).Value = dateTimePicker1.Text;
                        comit.Parameters.Add("@Conta_Corrente", MySqlDbType.VarChar, 45).Value = cmbTipoConta.Text;
                        comit.Parameters.Add("@Grupo", MySqlDbType.VarChar, 45).Value = cmbGrupo.Text;

                        comit.CommandType = CommandType.Text;
                        comit.ExecuteNonQuery();
                        drit = comit.ExecuteReader();

                        dtrel = new MySqlDataAdapter(comit);
                        dtrelt = new DataTable();
                    }
                }

            }


            while (drit.Read())
            {
                countir++;
            }

            if (count >= 1 || counti >= 1)
            {
                lbValorEnt.Text = "Total de Entradas: R$ " + valor.ToString("n2");
                lbValorSai.Text = "Total de Saídas: R$ " + valori.ToString("n2");
                double saldo = valor - valori;

                lbSaldo.Text = "Saldo Restante: R$ " + saldo.ToString("n2");
            }


            if (countir >= 1)
            {
                con.desconctar();
                con.conectar();

                dtrel.Fill(dtrelt);
                dgvFinanceiro.DataSource = dtrelt;
                dgvFinanceiro.Columns[0].Visible = false;
                lbCountReg.Text = dgvFinanceiro.Rows.Count + " Registros Encontrados!";
            }

            else
            {
                dtrelt.Clear();
                dgvFinanceiro.DataSource = dtrel;
                MessageBox.Show("Não foram encontrados registros para o mês informado!");
                lbCountReg.Text = dgvFinanceiro.Rows.Count + " Registros Encontrados!";
                lbValorEnt.Text = "Total de Entradas: R$ " + 0.00.ToString("n2");
                lbValorSai.Text = "Total de Saídas: R$ " + 0.00.ToString("n2");
                lbSaldo.Text = "Saldo Restante: R$ " + 0.00.ToString("n2");
            }
            con.desconctar();
        }
        
       
        private void RelMes_Load(object sender, EventArgs e)
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

        private void dgvFinanceiro_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Dados.ID_Controle = dgvFinanceiro.Rows[e.RowIndex].Cells["ID"].Value.ToString();
        }
    }
}
