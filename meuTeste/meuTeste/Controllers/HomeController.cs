using meuTeste.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace meuTeste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly MeuTesteDb Context = new MeuTesteDb();

        [HttpGet("Todos")]
        public IEnumerable<MeuTeste> Index()
        {
            try
            {
                return Context.MeuTestesCollection.FindAll();
            }
            catch(Exception erro)
            {
                throw new Exception(erro.Message);
            }
            
        }

        [HttpPost("Incluir")]
        public bool Incluir(MeuTeste meuTeste)
        {
            try
            {
                Context.MeuTestesCollection.Insert(meuTeste);

                return true;
            }
            catch(Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
    }
}
