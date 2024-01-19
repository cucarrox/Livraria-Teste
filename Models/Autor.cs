using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Livraria.Models
{
    [Table("autores")]
    public class Autor
    {

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }
        [Required]
        public DateOnly Nascimento { get; set; }
        [Required]
        [MaxLength(2)]
        public string Nacionalidade { get; set; }

    }
}
