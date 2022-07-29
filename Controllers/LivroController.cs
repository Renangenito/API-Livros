using APICodeFirstLivros.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APICodeFirstLivros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly ControleLivrosDBContext _context;

        public LivroController(ControleLivrosDBContext context)
        {
            _context = context;
        }

        [HttpPost()]

        public void Post([FromBody] Livro livro)
        {
            _context.Livros.Add(livro);
            _context.SaveChanges();
        }

        [HttpGet()]

        public async Task<List<Livro>> Get()
        {
            return _context.Livros.ToList();
            
        }
    }
}
