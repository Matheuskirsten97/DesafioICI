using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ProvaCandidato.Data;
using ProvaCandidato.Data.Entidade;
using ProvaCandidato.Data.Repositories.Interfaces;
using ProvaCandidato.Web.Helper.Tools;
using ProvaCandidato.Web.ViewModels;

namespace ProvaCandidato.Web.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClientRepositorie _clientRepositorie;
        private readonly ICidadeRepositorie _cidadeRepositorie;

        public ClientesController(IClientRepositorie clientRepositorie, ICidadeRepositorie cidadeRepositorie)
        {
            _clientRepositorie = clientRepositorie;
            _cidadeRepositorie = cidadeRepositorie;
        }
        // GET: Clientes
        public async Task<ActionResult> Index()
        {
            List<Cliente> clientes = await _clientRepositorie.GetListClientes();
            if (clientes.Count > 0)
            {
                ViewBag.clientesList = clientes;
                ViewBag.Cidades = await _cidadeRepositorie.GetListCidades();
                ClientViewModel listClientes = new ClientViewModel();
                return View(listClientes);
            }
            else return View();
        }

        [HttpPost()]
        public async Task<ActionResult> Index([Bind(Include = "Nome,CidadeId,DataNascimento")] Cliente cliente)
        {            
            if (new Tools().ValidaCliente(cliente))
            {
                await _clientRepositorie.Create(cliente);

                ClientViewModel novoCliente = new ClientViewModel();
                novoCliente.cliente = cliente;

                return View("Index", novoCliente);                
            }
            else
                return View("Index", new ClientViewModel());
        }
    }
}