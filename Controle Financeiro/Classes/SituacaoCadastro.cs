using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Financeiro.Classes
{
   public class SituacaoCadastro
    {
        public string Situacao { get; set; }

        public override string ToString()
        {
            return string.Format($"{Situacao}");
        }
    }
}
