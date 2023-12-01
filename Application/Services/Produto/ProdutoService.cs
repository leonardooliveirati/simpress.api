using Infrastructure.Repository.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Produto;

public class ProdutoService : IProdutoService
{
    private readonly IProdutoRepository _produtoRepository;

    public ProdutoService(IProdutoRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }
    public async Task<int> AdicionarProduto(Domain.Data.Produto produto)
    {
        return await _produtoRepository.AdicionarProduto(produto);
    }

    public async Task AtualizarProduto(Domain.Data.Produto produto)
    {
        await _produtoRepository.AtualizarProduto(produto);
    }

    public async Task<Domain.Data.Produto> ObterProdutoPorId(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Domain.Data.Produto>> ObterTodosProdutos()
    {
        var produtos = await _produtoRepository.ObterTodosProdutos();
        return produtos;
    }

    public async Task RemoverProduto(int produtoId)
    {
        await _produtoRepository.RemoverProduto(produtoId);
    }

    //private ProdutoDto MapToDto(Produto produto)
    //{
    //    return new ProdutoDto
    //    {
    //        Id = produto.Id,
    //        Nome = produto.Nome,

    //    };
    //}

}
