using API_Com_Swagger.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace API_Com_Swagger.Controllers
{
    public class ClienteController : Controller
    {
        public Contexto Contexto { get; set; }
        public ClienteController(Contexto novoContexto)
        {
            this.Contexto = novoContexto;
        }

        public IActionResult Index()
        {
            List<Cliente> listaDeClientes = this.Contexto.Clientes.Where(e => e.Idade >= 18).ToList();
            return View(listaDeClientes);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Cliente cliente = new Cliente();    
            Conta conta = new Conta();
            return View(cliente);   
        }


   


    }
}
