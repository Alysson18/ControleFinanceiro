using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
     

namespace Controle_Financeiro
{
    public class Conexao
    {
        public MySqlConnection con = new MySqlConnection();

        public Conexao()
        {
            con.ConnectionString = @"server=127.0.0.1;port=3306;User Id= root; database= " + Banco.Conectado + "; password= masterkey";

        }
        public MySqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
                            }
            return con;
        }
        public void desconctar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
