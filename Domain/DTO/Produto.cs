using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    // outras propriedades...

    public int CategoriaProdutoId { get; set; }
    public CategoriaProduto CategoriaProduto { get; set; }
}
