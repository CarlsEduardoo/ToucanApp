using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToucanShoes.Models
{

    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int Id { get; }
        [Required, MaxLength(128)]
        public string Name { get; set; }

        [Required, MaxLength(128)]
        public string Email { get; set; }

        [Required, MaxLength(128)]
        public string Senha { get; set; }

        [ReadOnly(true)]
        public DateTime? DataCadastro { get; }
    }
}
