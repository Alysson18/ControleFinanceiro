using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_Financeiro.Telas_Sistemas
{
    public partial class CodigoCliente : Form
    {
        public CodigoCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dados.Codigo_Cliente = tbCodigo.Text;

            this.Close();
        }
    }
}
