using SelesMiudeza.Data.Context;
using SelesMiudeza.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelesMiudeza.Data.Service
{
    public class PessoaService
    {
        AppDbContext context;
        public PessoaService(AppDbContext context)
        {
            this.context = context;
        }
        
        public async Task<List<Pessoa>> GetPessoaAsync()
        {
            var result = context.Pessoas;
            return await Task.FromResult(result.ToList());
        }

        public async Task<Pessoa> PostPessoaAsync(Pessoa pessoa)
        {
            context.Add(pessoa);
            await context.SaveChangesAsync();
            return pessoa;
        }

        public async Task DeletePessoaAsync(Guid Id)
        {
            context.Remove(Id);
            await context.SaveChangesAsync();

        }
    }
}
