using System;
using Microsoft.Win32;
using System.Windows.Forms;

namespace Gerador_de_Licença
{
    public partial class AdicionarLicenca : Form
    {
        public AdicionarLicenca()
        {
            InitializeComponent();
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text != "")
            {

                SKGL.Validate validar = new SKGL.Validate();
                validar.secretPhase = "981965692";
                validar.Key = tbCodigo.Text;

                if (validar.IsValid == true)
                {

                    try
                    {
                        RegistryKey rk = Registry.CurrentUser;

                        RegistryKey sk1 = rk.CreateSubKey("SOFTWARE\\" + Application.ProductName);

                        sk1.SetValue("Licença", tbCodigo.Text);

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                  MessageBox.Show("Código Ivalido ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Codigo é de Preenchimento Obrigatório ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
