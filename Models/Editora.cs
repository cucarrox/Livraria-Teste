using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;

namespace Livraria.Models
{
    [Table("editoras")]
    [Index(nameof(CNPJ), IsUnique = true)]
    public class Editora
    {

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }
        [Required]
        public string Endereco { get; set; }
        [Required]
        [RegularExpression("\\d{2}\\.?\\d{3}\\.?\\d{3}\\/?\\d{4}\\-?\\d{2}\\")]
        [MaxLength(18)]
        public string CNPJ { get; set; }

    }
}
