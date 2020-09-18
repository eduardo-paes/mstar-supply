using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using MStartSupply.Data;

namespace MStartSupply.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MStartSupplyContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MStartSupplyContext>>()))
            {
                // Verifica se há mercadorias
                if (context.Mercadoria.Any())
                {
                    return;   // DB semeado.
                }

                context.Mercadoria.AddRange(
                    new Mercadoria
                    {
                        Nome = "Resma de Papel",
                        NumeroRegistro = "A001",
                        Fabricante = "Chamex",
                        Tipo = "Papelaria",
                        Descricao = "Pacote com 500 folhas de papel.",
                        Quantidade = 0
                    },

                    new Mercadoria
                    {
                        Nome = "Mouse MX3 Master",
                        NumeroRegistro = "I003",
                        Fabricante = "Logitech",
                        Tipo = "Informática",
                        Descricao = "Mouse multifuncional para produtividade em escritório",
                        Quantidade = 0
                    },

                    new Mercadoria
                    {
                        Nome = "Pacote Sacola Plástica",
                        NumeroRegistro = "T017",
                        Fabricante = "Trash Bag",
                        Tipo = "Limpeza",
                        Descricao = "Pacote com 20 sacolas plásticas para lixeira.",
                        Quantidade = 0
                    }
                );

                // Verifica se há entradas
                if (context.Entrada.Any())
                {
                    return;   // DB semeado.
                }

                context.Entrada.AddRange(
                    new Entrada
                    {
                        Quantidade = 2,
                        DataEntrada = DateTime.Parse("2020-2-12"),
                        LocalEntrada = "Duque de Caxias",
                        MercadoriaID = "1"
                    },

                    new Entrada
                    {
                        Quantidade = 5,
                        DataEntrada = DateTime.Parse("2020-3-13"),
                        LocalEntrada = "Petrópolis",
                        MercadoriaID = "2"
                    },

                    new Entrada
                    {
                        Quantidade = 8,
                        DataEntrada = DateTime.Parse("2020-4-26"),
                        LocalEntrada = "Magé",
                        MercadoriaID = "3"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
