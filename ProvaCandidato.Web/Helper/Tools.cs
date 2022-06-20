using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProvaCandidato.Data.Entidade;

namespace ProvaCandidato.Web.Helper.Tools
{
    public class Tools
    {
        public bool ValidaCliente(Cliente cliente)
        {
            if (cliente != null)
            {
                if (cliente.DataNascimento < DateTime.Now)
                {
                    return true;
                }
            }

            return false;
        }
    }
}