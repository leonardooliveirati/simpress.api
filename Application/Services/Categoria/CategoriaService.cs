using Domain.Data;
using Infrastructure.Repository.Categoria;
using Infrastructure.Repository.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Categoria
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public async Task<int> AdicionarCategoria(CategoriaProduto categoriaProduto)
        {
            return await _categoriaRepository.AdicionarCategoria(categoriaProduto);
        }

        public async Task AtualizarCategoria(CategoriaProduto categoriaProduto)
        {
            await _categoriaRepository.AtualizarCategoria(categoriaProduto);
        }

        public async Task<IEnumerable<CategoriaProduto>> ObterTodosCategorias()
        {
            return await _categoriaRepository.ObterTodosCategorias();
        }

        public Task RemoverCategoria(int id)
        {
            throw new NotImplementedException();
        }
    }
}
