using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToucanShoes.Models
{

    [Table("Produto")]
    public class Produto
    {
        [Key]
        [Column("Id")]
        [Display(Name="Código")]
        public int Id { get; set; }
        
        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("Preco")]
        [Display(Name = "Preço")]
        public double Preco { get; set; }

        [Column("Categoria")]
        [Display(Name ="Categoria")]
        public string Categoria { get; set; }   
    }
}
