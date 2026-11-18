using ProjetoRestaurante.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoRestaurante.Domain.Interfaces
{
    public interface IProdutoBaseRepository
    {
        Task<IEnumerable<ProdutoBase>> ObterTodosAsync();
        Task<ProdutoBase?> ObterPorIdAsync(int id);
        Task<ProdutoBase> AdicionarAsync(ProdutoBase produto);
        Task AtualizarAsync(ProdutoBase produto);
        Task RemoverAsync(int id);
    }
}
