using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Financeiro.Classes
{
   public class CadastroRepositorio
    {
        HttpClient client = new HttpClient();
        public CadastroRepositorio()
        {
            client.BaseAddress = new Uri("http://webapivendas.ddns.net:5000/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/json"));
            
        }

        public async Task<List<SituacaoCadastro>> GetSituacaoCadastrosAsync(string codigo)
        {
            HttpResponseMessage response = await client.GetAsync("situacao/" + codigo);

            if(response.IsSuccessStatusCode)
            {
                Dados.Situacao = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<SituacaoCadastro>>(Dados.Situacao);
            }

            return new List<SituacaoCadastro>();
        }
        
    }
}
