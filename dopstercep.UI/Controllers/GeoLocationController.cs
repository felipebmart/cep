using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dopstercep.Domain.Model;
using dopstercep.Application;


namespace dopstercep.UI.Controllers
{
    
        [Produces("application/json")]
        [Route("api/Cep")]
        public class CepController : Controller
        {
    
            CepBusiness objBiz = new CepBusiness();

            // GET: api/Cep/5
            [HttpGet("{cep}", Name = "Get")]
            public EnderecoModel Get(string cep)
            {
            return objBiz.RetornarCep(cep);
            }
          
            
        }
       
    
}
