using GerenciadorReceitas.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorReceitas
{
    public class GerenciadorReceitasDbContext : DbContext
    {
        public DbSet<Receita> Receitas { get; set; }
    }
}
