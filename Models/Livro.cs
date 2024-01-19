using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Livraria.Models
{
    [Table("livros")]
    public class Livro
    {

        [Required]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public int Paginas { get; set; }
        [Required]
        public Autor Autor { get; set; }
        [Required]
        public Editora Editora { get; set; }
        [Required]
        public DateOnly Publicacao { get; set; }
        [Required]
        public string Genero { get; set; }
        [Required]
        public int Versao { get; set; }
        [Required]
        [Column(TypeName = "NUMERIC(6, 2)")]
        public double Preco { get; set; }

    }
}
