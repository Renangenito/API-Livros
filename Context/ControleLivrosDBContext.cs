using Microsoft.EntityFrameworkCore;

namespace APICodeFirstLivros.Context
{
    public class ControleLivrosDBContext : DbContext
    {

        public ControleLivrosDBContext(DbContextOptions<ControleLivrosDBContext> options) : base(options)
        {

        }

        public DbSet<Livro> Livros { get; set; }

    }
}
