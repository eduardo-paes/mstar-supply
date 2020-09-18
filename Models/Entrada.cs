using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MStartSupply.Models
{
    public class Entrada
    {
        [Key]
        [Display(Name = "ID")]
        public int EntradaID { get; set; }

        [Required]
        public int Quantidade { get; set; }

        [Required]
        [Display(Name = "Data")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataEntrada { get; set; }

        [Required]
        [Display(Name = "Local")]
        public string LocalEntrada { get; set; }

        [Required]
        [Display(Name = "Mercadoria")]
        public string MercadoriaID { get; set; }
        public Mercadoria Mercadoria { get; set; }
    }
}
