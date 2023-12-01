using Domain.Data;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Categoria
{
    internal class CategoriaRepository : ICategoriaRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoriaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> AdicionarCategoria(CategoriaProduto categoriaProduto)
        {
            try
            {
                _context.CategoriasProdutos.Add(categoriaProduto);
                await _context.SaveChangesAsync();
                return categoriaProduto.Id;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task AtualizarCategoria(CategoriaProduto categoriaProduto)
        {
            try
            {
                _context.CategoriasProdutos.Update(categoriaProduto);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IEnumerable<CategoriaProduto>> ObterTodosCategorias()
        {
            try
            {
                return await _context.CategoriasProdutos.ToListAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task RemoverCategoria(int id)
        {
            try
            {
                var categoria = await _context.CategoriasProdutos.FindAsync(id);
                _context.CategoriasProdutos.Remove(categoria);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
