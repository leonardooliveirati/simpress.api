using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Application.Services.Produto;

public interface IProdutoService
{
    Task<int> AdicionarProduto(Domain.Data.Produto produto);
    Task AtualizarProduto(Domain.Data.Produto produto);
    Task<Domain.Data.Produto> ObterProdutoPorId(int id);
    Task<IEnumerable<Domain.Data.Produto>> ObterTodosProdutos();
    Task RemoverProduto(int produtoId);
}
