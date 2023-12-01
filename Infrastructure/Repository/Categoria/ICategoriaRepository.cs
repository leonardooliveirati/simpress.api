using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Categoria
{
    public interface ICategoriaRepository
    {
        Task<int> AdicionarCategoria(Domain.Data.CategoriaProduto categoriaProduto);
        Task AtualizarCategoria(Domain.Data.CategoriaProduto categoriaProduto);
        Task<IEnumerable<Domain.Data.CategoriaProduto>> ObterTodosCategorias();
        Task RemoverCategoria(int id);
    }
}
