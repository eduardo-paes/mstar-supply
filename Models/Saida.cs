using System;
using System.ComponentModel.DataAnnotations;

namespace MStartSupply.Models
{
    public class Saida
    {
        [Key]
        [Display(Name = "ID")]
        public int SaidaID { get; set; }

        [Required]
        public int Quantidade { get; set; }

        [Required]
        [Display(Name = "Data")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataSaida { get; set; }

        [Required]
        [Display(Name = "Local")]
        public string LocalSaida { get; set; }

        [Required]
        [Display(Name = "Mercadoria")]
        public string MercadoriaID { get; set; }
        public Mercadoria Mercadoria { get; set; }
    }
}
