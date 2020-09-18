using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
namespace MStartSupply.Models
{
    public class MercadoriaTipoViewModel
    {
        public List<Mercadoria> Mercadorias { get; set; }
        public SelectList Tipos { get; set; }
        public string MercadoriaTipo { get; set; }
        public string SearchString { get; set; }
    }
}
