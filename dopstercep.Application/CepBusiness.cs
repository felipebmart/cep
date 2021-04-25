using System;
using dopstercep.Domain.Model;
using dopstercep.Services.Wrapper;

namespace dopstercep.Application
{    public class CepBusiness
    {
        ServiceCep Consulta = new ServiceCep();

        public EnderecoModel RetornarCep(string cep)
        {
            return Consulta.ReturnData(cep);
        }
    }
}
