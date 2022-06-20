using ProvaCandidato.Data.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaCandidato.Data.Repositories.Interfaces
{
    public interface IClientRepositorie
    {
        Task<List<Cliente>> GetListClientes();
        Task<Cliente> GetCliente(int Id);
        Task<Cliente> Create(Cliente cliente);
        Task<Cliente> Update(Cliente cliente);
        Task<bool> Delete(int Id);

    }
}
