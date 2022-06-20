using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProvaCandidato.Data.Entidade;

namespace ProvaCandidato.Web.ViewModels
{
    public class ClientesListViewModel
    {
        public IEnumerable<Cliente> clientes { get; set; }
    }
}