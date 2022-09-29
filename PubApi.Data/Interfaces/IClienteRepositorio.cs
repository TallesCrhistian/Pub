using PubApi.Data.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PubApi.Data.Interfaces
{
    public interface IClienteRepositorio
    {
        Task<Cliente> Iserir(Cliente cliente);
        Task<Cliente> Alterar(Cliente cliente);
        Task<List<Cliente>> Listar(Cliente cliente);
        Task<Cliente> ObterPorCodigo(int idCliente);
    }
}
