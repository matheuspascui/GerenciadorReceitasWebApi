using Microsoft.AspNetCore.Mvc;

namespace GerenciadorReceitas.Controllers
{
    [ApiController]
    public class ReceitaController : ControllerBase
    {
        private readonly ILogger<ReceitaController> _logger;
        public ReceitaController(ILogger<ReceitaController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
