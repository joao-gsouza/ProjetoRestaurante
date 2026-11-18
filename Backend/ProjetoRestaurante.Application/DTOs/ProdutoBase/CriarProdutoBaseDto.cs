using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoRestaurante.Application.DTOs.ProdutoBase
{
    public record CriarProdutoBaseDto(string Nome, decimal PrecoEmbalagem, double QuantidadeEmbalagem);
}
