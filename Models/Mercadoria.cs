using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MStartSupply.Models
{
    public class Mercadoria
    {
        [Key]
        public int MercadoriaID { get; set; }

        [Display(Name = "Estoque")]
        public int Quantidade { get; set; }

        [Display(Name = "Número de Registro")]
        public string NumeroRegistro { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Nome { get; set; }

        //[RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        public string Tipo { get; set; }

        //[RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        public string Fabricante { get; set; }

        [StringLength(300, MinimumLength = 3)]
        [Required]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
    }
}
