using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciadorReceitas.Models
{
    [Table("Receitas")]
    public class Receita
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required, MaxLength(255)]
        public string Titulo { get; set; } = string.Empty;
        [Required, MaxLength(1200)]
        public string ModoDePreparo { get; set; } = string.Empty;
        [Required]
        public List<string> Ingredientes { get; set; } = new List<string>();
        public List<string> Categorias { get; set; } = new List<string>();
        public string Nacionalidade { get; set; } = string.Empty;
        public DateTime DataCriacao { get; }

        //public Receita(ReceitaDto dto)
        //{
        //    this.Titulo = dto.Titulo;
        //    this.ModoDePreparo = dto.ModoDePreparo;
        //    this.Ingredientes = dto.Ingredientes.Split(',').ToList();
        //    this.Categorias = dto.Categorias.Split(',').ToList();
        //    this.Nacionalidade = dto.Nacionalidade;
        //    this.DataCriacao = DateTime.Today;
        //}

        //public Receita(Receita receita)
        //{
        //    this.Titulo = receita.Titulo;
        //    this.ModoDePreparo = receita.ModoDePreparo;
        //    this.Ingredientes = receita.Ingredientes;
        //    this.Categorias = receita.Categorias;
        //    this.Nacionalidade = receita.Nacionalidade;
        //}
    }
}
