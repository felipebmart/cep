using System;
using System.Collections.Generic;
using System.Text;

namespace dopstercep.Domain.Model
{
    public class EnderecoModel
    {
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Complemento { get; set; }
        public string CodMunicipioIBGE { get; set; }
        public string Cep { get; set; }
    }
}
