using ProvaCandidato.Data.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaCandidato.Data.Repositories.Interfaces
{
    public interface ICidadeRepositorie
    {
        Task<List<Cidade>> GetListCidades();
        Task<Cidade> GetCidade(int Id);
        Task<Cidade> Create(Cidade cidade);
        Task<Cidade> Update(Cidade cidade);
        Task<bool> Delete(int Id);
    }
}
