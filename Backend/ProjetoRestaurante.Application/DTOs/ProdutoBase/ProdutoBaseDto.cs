using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoRestaurante.Application.DTOs.ProdutoBase
{
    public record ProdutoBaseDto(int Id, string Nome, decimal PrecoEmbalagem, double QuantidadeEmbalagem);
}
