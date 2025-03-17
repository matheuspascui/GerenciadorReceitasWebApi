using GerenciadorReceitas.Models;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorReceitas.Controllers
{
    [ApiController]
    [Route("Api/[Controller]")]
    public class ReceitasController : ControllerBase
    {
        private readonly GerenciadorReceitasDbContext _context;

        public ReceitasController(GerenciadorReceitasDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public IActionResult GetAllReceitas()
        {
            var receitas = _context.Receitas.ToList();
            return Ok(receitas);
        }

        [HttpGet]
        [Route("/id")]
        public IActionResult GetReceita(int id)
        {
            var receita = _context.Receitas.Find(id);
            return Ok(receita);
        }

        [HttpPost]
        public IActionResult CreateReceita(Receita receita)
        {
            _context.Receitas.Add(receita);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetReceita), new { id = receita.Id }, receita);
        }
    }
}
