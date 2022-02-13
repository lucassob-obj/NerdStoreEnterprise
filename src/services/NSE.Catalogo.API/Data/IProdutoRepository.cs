﻿using NSE.Catalogo.API.Models;
using NSE.Core.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NSE.Catalogo.API.Data
{
    public interface IProdutoRepository: IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterTodos();
        Task<Produto> ObterPorId(Guid id);
        void Adicionar(Produto produto);
        void Atualizar(Produto produto);
        Task<List<Produto>> ObterProdutosPorId(string ids);
    }
}
