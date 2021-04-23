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
    public partial class RelPeriodo : Form
    {
        public RelPeriodo()
        {
            InitializeComponent();
        }

        Conexao con = new Conexao();

        MySqlDataAdapter dtrel;
        DataTable dtrelt;
        MySqlDataReader dr, dri, drit, dele;
        MySqlCommand com, comi, comit, del;

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

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string dtIni = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string dtFin = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            int count = 0, counti = 0, countir = 0;
            double valor = 0, valori = 0;



            con.desconctar();
            con.conectar();

            if (cmbGrupo.Text == "Todos" && cmbTipoConta.Text == "Todos")
            {
                com = new MySqlCommand("SELECT Valor FROM controlefinanceiro Where Evento = @Evento And Data between @Data1 And @Data2", con.con);
                com.Parameters.Add("@Evento", MySqlDbType.VarChar, 45).Value = "Entrada";
                com.Parameters.AddWithValue("@Data1", dtIni);
                com.Parameters.AddWithValue("@Data2", dtFin);

                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                dr = com.ExecuteReader();
            }
            else
            {
                if (cmbTipoConta.Text == "Todos")
                {
                    com = new MySqlCommand("SELECT Valor FROM controlefinanceiro Where Evento = @Evento And Grupo = @Grupo And Data between @Data1 And @Data2", con.con);
                    com.Parameters.Add("@Evento", MySqlDbType.VarChar, 45).Value = "Entrada";
                    com.Parameters.Add("@Grupo", MySqlDbType.VarChar, 45).Value = cmbGrupo.Text;
                    com.Parameters.AddWithValue("@Data1", dtIni);
                    com.Parameters.AddWithValue("@Data2", dtFin);

                    com.CommandType = CommandType.Text;
                    com.ExecuteNonQuery();
                    dr = com.ExecuteReader();
                }
                else
                {
                    if (cmbGrupo.Text == "Todos")
                    {
                        com = new MySqlCommand("SELECT Valor FROM controlefinanceiro Where Evento = @Evento And Conta_Corrente = @Conta_Corrente And Data between @Data1 And @Data2", con.con);
                        com.Parameters.Add("@Evento", MySqlDbType.VarChar, 45).Value = "Entrada";
                        com.Parameters.Add("@Conta_Corrente", MySqlDbType.VarChar, 45).Value = cmbTipoConta.Text;
                        com.Parameters.AddWithValue("@Data1", dtIni);
                        com.Parameters.AddWithValue("@Data2", dtFin);

                        com.CommandType = CommandType.Text;
                        com.ExecuteNonQuery();
                        dr = com.ExecuteReader();
                    }
                    else
                    {
                        com = new MySqlCommand("SELECT Valor FROM controlefinanceiro Where Evento = @Evento And Conta_Corrente = @Conta_Corrente And Grupo = @Grupo And Data between @Data1 And @Data2", con.con);
                        com.Parameters.Add("@Evento", MySqlDbType.VarChar, 45).Value = "Entrada";
                        com.Parameters.Add("@Conta_Corrente", MySqlDbType.VarChar, 45).Value = cmbTipoConta.Text;
                        com.Parameters.Add("@Grupo", MySqlDbType.VarChar, 45).Value = cmbGrupo.Text;
                        com.Parameters.AddWithValue("@Data1", dtIni);
                        com.Parameters.AddWithValue("@Data2", dtFin);

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
                comi = new MySqlCommand("SELECT Valor FROM controlefinanceiro Where Evento = @Evento And Data between @Data1 And @Data2", con.con);
                comi.Parameters.Add("@Evento", MySqlDbType.VarChar, 45).Value = "Saida";
                comi.Parameters.AddWithValue("@Data1", dtIni);
                comi.Parameters.AddWithValue("@Data2", dtFin);

                comi.CommandType = CommandType.Text;
                comi.ExecuteNonQuery();
                dri = comi.ExecuteReader();
            }
            else
            {
                if (cmbTipoConta.Text == "Todos")
                {
                    comi = new MySqlCommand("SELECT Valor FROM controlefinanceiro Where Evento = @Evento And Grupo = @Grupo And Data between @Data1 And @Data2", con.con);
                    comi.Parameters.Add("@Evento", MySqlDbType.VarChar, 45).Value = "Saida";
                    comi.Parameters.Add("@Grupo", MySqlDbType.VarChar, 45).Value = cmbGrupo.Text;
                    comi.Parameters.AddWithValue("@Data1", dtIni);
                    comi.Parameters.AddWithValue("@Data2", dtFin);

                    comi.CommandType = CommandType.Text;
                    comi.ExecuteNonQuery();
                    dri = comi.ExecuteReader();
                }
                else
                {
                    if (cmbGrupo.Text == "Todos")
                    {
                        comi = new MySqlCommand("SELECT Valor FROM controlefinanceiro Where Evento = @Evento And Conta_Corrente = @Conta_Corrente And Data between @Data1 And @Data2", con.con);
                        comi.Parameters.Add("@Evento", MySqlDbType.VarChar, 45).Value = "Saida";
                        comi.Parameters.Add("@Conta_Corrente", MySqlDbType.VarChar, 45).Value = cmbTipoConta.Text;
                        comi.Parameters.AddWithValue("@Data1", dtIni);
                        comi.Parameters.AddWithValue("@Data2", dtFin);

                        comi.CommandType = CommandType.Text;
                        comi.ExecuteNonQuery();
                        dri = comi.ExecuteReader();
                    }
                    else
                    {
                        comi = new MySqlCommand("SELECT Valor FROM controlefinanceiro Where Evento = @Evento And Conta_Corrente = @Conta_Corrente And Grupo = @Grupo And Data between @Data1 And @Data2", con.con);
                        comi.Parameters.Add("@Evento", MySqlDbType.VarChar, 45).Value = "Saida";
                        comi.Parameters.Add("@Conta_Corrente", MySqlDbType.VarChar, 45).Value = cmbTipoConta.Text;
                        comi.Parameters.Add("@Grupo", MySqlDbType.VarChar, 45).Value = cmbGrupo.Text;
                        comi.Parameters.AddWithValue("@Data1", dtIni);
                        comi.Parameters.AddWithValue("@Data2", dtFin);

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
                comit = new MySqlCommand("SELECT ID, Data, Valor, Descricao As Descrição, Evento  FROM controlefinanceiro Where Data between @Data1 And @Data2", con.con);
                comit.Parameters.AddWithValue("@Data1", dtIni);
                comit.Parameters.AddWithValue("@Data2", dtFin);

                comit.CommandType = CommandType.Text;
                comit.ExecuteNonQuery();
                drit = comit.ExecuteReader();
            }
            else
            {
                if (cmbTipoConta.Text == "Todos")
                {
                    comit = new MySqlCommand("SELECT ID, Data, Valor, Descricao As Descrição, Evento  FROM controlefinanceiro Where Grupo = @Grupo And Data between @Data1 And @Data2", con.con);
                    comit.Parameters.Add("@Grupo", MySqlDbType.VarChar, 45).Value = cmbGrupo.Text;
                    comit.Parameters.AddWithValue("@Data1", dtIni);
                    comit.Parameters.AddWithValue("@Data2", dtFin);

                    comit.CommandType = CommandType.Text;
                    comit.ExecuteNonQuery();
                    drit = comit.ExecuteReader();
                }
                else
                {
                    if (cmbGrupo.Text == "Todos")
                    {
                        comit = new MySqlCommand("SELECT ID, Data, Valor, Descricao As Descrição, Evento  FROM controlefinanceiro Where Conta_Corrente = @Conta_Corrente And Data between @Data1 And @Data2", con.con);
                        comit.Parameters.Add("@Conta_Corrente", MySqlDbType.VarChar, 45).Value = cmbTipoConta.Text;
                        comit.Parameters.AddWithValue("@Data1", dtIni);
                        comit.Parameters.AddWithValue("@Data2", dtFin);

                        comit.CommandType = CommandType.Text;
                        comit.ExecuteNonQuery();
                        drit = comit.ExecuteReader();
                    }
                    else
                    {
                        comit = new MySqlCommand("SELECT ID, Data, Valor, Descricao As Descrição, Evento  FROM controlefinanceiro Where  Conta_Corrente = @Conta_Corrente And Grupo = @Grupo And Data between @Data1 And @Data2", con.con);
                        comit.Parameters.Add("@Conta_Corrente", MySqlDbType.VarChar, 45).Value = cmbTipoConta.Text;
                        comit.Parameters.Add("@Grupo", MySqlDbType.VarChar, 45).Value = cmbGrupo.Text;
                        comit.Parameters.AddWithValue("@Data1", dtIni);
                        comit.Parameters.AddWithValue("@Data2", dtFin);

                        comit.CommandType = CommandType.Text;
                        comit.ExecuteNonQuery();
                        drit = comit.ExecuteReader();

                    }
                }
            }

            dtrel = new MySqlDataAdapter(comit);
            dtrelt = new DataTable();


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
                MessageBox.Show("Não foram encontrados registros para os parâmetros informados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lbCountReg.Text = dgvFinanceiro.Rows.Count + " Registros Encontrados!";
                lbValorEnt.Text = "Total de Entradas: R$ " + (0.00).ToString("n2");
                lbValorSai.Text = "Total de Saídas: R$ " + (0.00).ToString("n2");
                lbSaldo.Text = "Saldo Restante:R$ " + (0.00).ToString("n2");
            }

            con.desconctar();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RelPeriodo_Load(object sender, EventArgs e)
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
