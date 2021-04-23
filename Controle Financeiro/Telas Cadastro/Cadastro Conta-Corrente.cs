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
    public partial class Cadastro_Conta_Corrente : Form
    {
        public Cadastro_Conta_Corrente()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            Conexao con = new Conexao();
            try
            {             

                con.conectar();

                MySqlCommand dbcomand = new MySqlCommand("insert into conta_corrente (nome_conta, tipo_conta)" +
                    " values(?, ?)", con.con);

                dbcomand.Parameters.Add("@Nome_conta", MySqlDbType.VarChar, 45).Value = tbNomeConta.Text;
                dbcomand.Parameters.Add("@tipo_conta", MySqlDbType.VarChar, 45).Value = cmbTipoConta.Text;              


                dbcomand.ExecuteNonQuery();

                MessageBox.Show("Conta Cadastrada com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.desconctar();
                tbNomeConta.Clear();
                cmbTipoConta.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.desconctar();
        }
    }
}
