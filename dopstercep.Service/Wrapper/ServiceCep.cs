using dopstercep.Domain.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace dopstercep.Services.Wrapper
{
    public class ServiceCep
    {

        /// Retorno do ViaCep
        /// 
        /// 
        public EnderecoModel ReturnData(string _cep)
        {

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                string baseURL = "https://viacep.com.br/ws/" + _cep + "/json/";
                HttpResponseMessage response = client.GetAsync(baseURL).Result;

                response.EnsureSuccessStatusCode();
                string conteudo = response.Content.ReadAsStringAsync().Result;

                dynamic resultado = JsonConvert.DeserializeObject(conteudo);

                EnderecoModel endConsulta = new EnderecoModel();

                endConsulta.Logradouro = resultado.logradouro;
                endConsulta.Cep = resultado.cep;
                endConsulta.Complemento = resultado.complemento;
                endConsulta.Bairro = resultado.bairro;
                endConsulta.Cidade = resultado.localidade;
                endConsulta.Uf = resultado.uf;
                endConsulta.CodMunicipioIBGE = resultado.ibge;

                return endConsulta;

            }



        }

    }
}
