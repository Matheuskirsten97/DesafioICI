using ProvaCandidato.Data.Entidade;
using ProvaCandidato.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaCandidato.Data.Repositories
{
    public class ClienteRepositorie : IClientRepositorie
    {
        private readonly ContextoPrincipal _context;
        public ClienteRepositorie(ContextoPrincipal contexto)
        {
            _context = contexto;
        }



        public async Task<List<Cliente>> GetListClientes()
        {
            var clientList = _context.Clientes.Where(c => c.Ativo == true).ToList();
            return clientList;
        }
        public async Task<Cliente> GetCliente(int Id)
        {
            var cliente = _context.Clientes.FirstOrDefault(c => c.Codigo == Id);
            return cliente;
        }
        public async Task<Cliente> Create(Cliente cliente)
        {
            try
            {
                cliente.Ativo = true;
                _context.Clientes.Add(cliente);
                await _context.SaveChangesAsync();
                return cliente;

            }
            catch (Exception)
            {

                throw new Exception("Não foi possivel cadastrar");
            }
 
        }
        public async Task<Cliente> Update(Cliente cliente)
        {
            try
            {
                Cliente clienteFind = await _context.Clientes.FindAsync(cliente.Codigo);
                clienteFind.Nome = cliente.Nome;

                await _context.SaveChangesAsync();

                return cliente;

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
                Cliente clienteFind = _context.Clientes.First(c => c.Codigo == Id);
                _context.Clientes.Remove(clienteFind);
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
