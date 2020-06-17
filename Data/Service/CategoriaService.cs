using Microsoft.EntityFrameworkCore;
using SelesMiudeza.Data.Context;
using SelesMiudeza.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelesMiudeza.Data.Service
{
    public class CategoriaService
    {
        AppDbContext context;
        public CategoriaService(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Categoria>> GetCategoriaAsync()
        {
            var result = context.Categorias;
            return await Task.FromResult(result.ToList());
        }

        public async Task<Categoria> GetCategoriaAsync(int Id)
        {
            var result = await context.Categorias.FirstAsync(x => x.IdCategoria == Id);
            return await Task.FromResult(result);
        }

        public async Task<Categoria> PostCategoriaAsync(Categoria categoria)
        {
            context.Add(categoria);
            await context.SaveChangesAsync();
            return categoria;
        }

        public async Task<Categoria> UpdateCategoriaAsync(int Id, Categoria categoria)
        {
            var cat = await GetCategoriaAsync(Id);

            if (cat == null)
                return null;

            cat.Nome = categoria.Nome;
            cat.Descricao = categoria.Descricao;
            context.Categorias.Update(cat);
            await context.SaveChangesAsync();
            return categoria;
        }

        public async Task DeleteCategoriaAsync(int Id)
        {
            context.Remove(Id);
            await context.SaveChangesAsync();

        }
    }
}
