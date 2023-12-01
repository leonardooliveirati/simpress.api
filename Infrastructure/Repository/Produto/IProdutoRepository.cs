using Domain.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Produto;

public interface IProdutoRepository
{
    Task<int> AdicionarProduto(Domain.Data.Produto produto);
    Task AtualizarProduto(Domain.Data.Produto produto);
    Task<IEnumerable<Domain.Data.Produto>> ObterTodosProdutos();
    Task <List<Domain.Data.Produto>> RemoverProduto(int produtoId);
}
