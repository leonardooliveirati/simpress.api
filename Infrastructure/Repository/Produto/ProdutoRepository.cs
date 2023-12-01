using Domain;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Produto
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ApplicationDbContext _context;

        public ProdutoRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<int> AdicionarProduto(Domain.Data.Produto produto)
        {
            try
            {
                _context.Produtos.Add(produto);
                await _context.SaveChangesAsync();
                return produto.Id;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task AtualizarProduto(Domain.Data.Produto produto)
        {
            try
            {
                _context.Produtos.Update(produto);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IEnumerable<Domain.Data.Produto>> ObterTodosProdutos()
        {
            try
            {
                return await _context.Produtos.ToListAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task RemoverProduto(int produtoId)
        {
            try
            {
                var produto = await _context.Produtos.FindAsync(produtoId);
                _context.Produtos.Remove(produto);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        Task<List<Domain.Data.Produto>> IProdutoRepository.RemoverProduto(int produtoId)
        {
            throw new NotImplementedException();
        }
    }
}
