namespace GerenciadorReceitas.Models
{
    public class Receita
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string ModoDePreparo { get; set; } = string.Empty;
        public List<string> Ingredientes { get; set; } = new List<string>();
        public List<string> Categorias { get; set; } = new List<string>();
        public string Nacionalidade { get; set; } = string.Empty;
        public DateTime DataCriacao { get; set; }
    }
}
