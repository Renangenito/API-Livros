using APICodeFirstLivros.Context;
using Microsoft.EntityFrameworkCore;

namespace APICodeFirstLivros.Extensoes
{
    public static class ServicoExtensoes
    {
        public static void ConfigurarServicos(this IServiceCollection services)
        {
            string connectionstring = "data source=localhost,1433;user id=sa;password=senha@1234xxxy;initial catalog=BancoLivros;";

            services.AddDbContext<ControleLivrosDBContext>(item => item.UseSqlServer(connectionstring));
        }
    }
}
