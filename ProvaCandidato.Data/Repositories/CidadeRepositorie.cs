using ProvaCandidato.Data.Entidade;
using ProvaCandidato.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaCandidato.Data.Repositories
{
    public class CidadeRepositorie : ICidadeRepositorie
    {
        private readonly ContextoPrincipal _context;
        public CidadeRepositorie(ContextoPrincipal contexto)
        {
            _context = contexto;
        }


        public  async Task<Cidade> GetCidade(int Id)
        {
            var Cidade = _context.Cidades.FirstOrDefault(c => c.Codigo == Id);
            return Cidade;
        }
        public  async Task<List<Cidade>> GetListCidades()
        {
            var listCidades = _context.Cidades.ToList();
            return listCidades;

        }
        public async Task<Cidade> Create(Cidade cidade)
        {

            try
            {
                Cidade cidadeRecebida = cidade;
                _context.Cidades.Add(cidadeRecebida);
                await _context.SaveChangesAsync();

                return cidade;
            }
            catch (Exception)
            {

                throw new Exception("Não foi possivel cadastrar");
            }

        }

        public async Task<Cidade> Update(Cidade cidade)
        {
            try
            {
                Cidade cidadeRecebida = await _context.Cidades.FindAsync(cidade.Codigo);
                cidadeRecebida.Nome = cidade.Nome;

                await _context.SaveChangesAsync();

                return cidade;

            }
            catch (Exception)
            {

                throw new Exception("Não foi possivel cadastrar");
            }
        }

        public async Task<bool> Delete(int Id)
        {
            try
            {
                Cidade cidadeRecebida = _context.Cidades.First(c => c.Codigo == Id);
                _context.Cidades.Remove(cidadeRecebida);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
