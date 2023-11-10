using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToucanShoes.Models
{
    [Table("Cliente")]
    public class Cliente : Usuario
    {
        [Required, Column(TypeName = "char(14)")]
        public int CPF { get; set; }
        public DateTime? DataNascimento { get; set; }
    }
}
