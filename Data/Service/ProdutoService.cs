using SelesMiudeza.Data.Context;
using SelesMiudeza.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelesMiudeza.Data.Service
{
    public class ProdutoService
    {
        AppDbContext context;
        public ProdutoService(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Produto>> GetProdutoAsync()
        {
            var result = context.Produtos;
            return await Task.FromResult(result.ToList());
        }

        public async Task<Produto> PostProdutoAsync(Produto pessoa)
        {
            context.Add(pessoa);
            await context.SaveChangesAsync();
            return pessoa;
        }

        public async Task DeleteProdutoAsync(Guid Id)
        {
            context.Remove(Id);
            await context.SaveChangesAsync();

        }
    }
}
