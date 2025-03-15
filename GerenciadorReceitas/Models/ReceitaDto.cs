using System.ComponentModel.DataAnnotations;

namespace GerenciadorReceitas.Models
{
    public class ReceitaDto
    {
        public string Titulo { get; set; } = string.Empty;
        public string ModoDePreparo { get; set; } = string.Empty;
        public string Ingredientes { get; set; } = string.Empty;
        public string Categorias { get; set; } = string.Empty;
        public string Nacionalidade { get; set; } = string.Empty;
    }
}
