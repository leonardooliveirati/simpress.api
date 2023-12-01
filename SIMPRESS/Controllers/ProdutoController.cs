using Microsoft.AspNetCore.Mvc;
using Infrastructure.Data;
using Application.Services.Produto;
using Domain.Data;

namespace SIMPRESS.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProdutoController : ControllerBase
{
    private readonly IProdutoService _produtoService;
    public ProdutoController(IProdutoService produtoService)
    {
        _produtoService = produtoService;
    }

    // GET: api/produto
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var produtos = await _produtoService.ObterTodosProdutos();
        return Ok(produtos);
    }

    // GET: api/produto/5
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var produto = await _produtoService.ObterProdutoPorId(id);

        if (produto == null)
        {
            return NotFound();
        }

        return Ok(produto);
    }

    // POST: api/produto
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Produto produtoDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var produtoId = await _produtoService.AdicionarProduto(produtoDto);

        return CreatedAtAction(nameof(Get), new { id = produtoId }, produtoDto);
    }

    // PUT: api/produto/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] Produto produtoDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        if (id != produtoDto.Id)
        {
            return BadRequest();
        }

        await _produtoService.AtualizarProduto(produtoDto);

        return NoContent();
    }

    // DELETE: api/produto/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var produto = await _produtoService.ObterProdutoPorId(id);

        if (produto == null)
        {
            return NotFound();
        }

        await _produtoService.RemoverProduto(id);

        return NoContent();
    }
}
