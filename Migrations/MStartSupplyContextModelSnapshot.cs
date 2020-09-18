﻿// <auto-generated />
using System;
using MStartSupply.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MStartSupply_CT.Migrations
{
    [DbContext(typeof(MStartSupplyContext))]
    partial class MStartSupplyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("MStartSupply.Models.Entrada", b =>
                {
                    b.Property<int>("EntradaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataEntrada")
                        .HasColumnType("TEXT");

                    b.Property<string>("LocalEntrada")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MercadoriaID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("MercadoriaID1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantidade")
                        .HasColumnType("INTEGER");

                    b.HasKey("EntradaID");

                    b.HasIndex("MercadoriaID1");

                    b.ToTable("Entrada");
                });

            modelBuilder.Entity("MStartSupply.Models.Mercadoria", b =>
                {
                    b.Property<int>("MercadoriaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(300);

                    b.Property<string>("Fabricante")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(60);

                    b.Property<string>("NumeroRegistro")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantidade")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MercadoriaID");

                    b.ToTable("Mercadoria");
                });

            modelBuilder.Entity("MStartSupply.Models.Saida", b =>
                {
                    b.Property<int>("SaidaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataSaida")
                        .HasColumnType("TEXT");

                    b.Property<string>("LocalSaida")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MercadoriaID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("MercadoriaID1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantidade")
                        .HasColumnType("INTEGER");

                    b.HasKey("SaidaID");

                    b.HasIndex("MercadoriaID1");

                    b.ToTable("Saida");
                });

            modelBuilder.Entity("MStartSupply.Models.Entrada", b =>
                {
                    b.HasOne("MStartSupply.Models.Mercadoria", "Mercadoria")
                        .WithMany()
                        .HasForeignKey("MercadoriaID1");
                });

            modelBuilder.Entity("MStartSupply.Models.Saida", b =>
                {
                    b.HasOne("MStartSupply.Models.Mercadoria", "Mercadoria")
                        .WithMany()
                        .HasForeignKey("MercadoriaID1");
                });
#pragma warning restore 612, 618
        }
    }
}
