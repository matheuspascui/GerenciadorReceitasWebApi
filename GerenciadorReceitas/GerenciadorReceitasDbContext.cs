using GerenciadorReceitas.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorReceitas
{
    public partial class GerenciadorReceitasDbContext : DbContext
    {
        public GerenciadorReceitasDbContext(DbContextOptions<GerenciadorReceitasDbContext> options): base(options)
        {

        }
        public DbSet<Receita> Receitas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Receita>(entity =>
            {
                entity.HasKey(x => x.Id);
            });
            //OnModelCreatingPartial(builder);
        }

        //partial void OnModelCreatingPartial(ModelBuilder builder);

    }
}
