﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using back_end.Infrastructure.Data;

#nullable disable

namespace back_end.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241023160055_CriandoProjeto")]
    partial class CriandoProjeto
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("back_end.Domain.Entities.Cadastro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Contato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CotaId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroCota")
                        .HasColumnType("int");

                    b.Property<string>("Parcelamento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CotaId");

                    b.ToTable("Cadastros");
                });

            modelBuilder.Entity("back_end.Domain.Entities.Consorcios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("QuantidadeCotas")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Valor")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Consorcios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            QuantidadeCotas = 10,
                            Tipo = "Imóvel",
                            Titulo = "Consórcio de Casa",
                            Valor = 500000
                        },
                        new
                        {
                            Id = 2,
                            QuantidadeCotas = 10,
                            Tipo = "Carro",
                            Titulo = "Consórcio de Carro",
                            Valor = 200000
                        },
                        new
                        {
                            Id = 3,
                            QuantidadeCotas = 10,
                            Tipo = "Serviço",
                            Titulo = "Consórcio de Reforma",
                            Valor = 70000
                        });
                });

            modelBuilder.Entity("back_end.Domain.Entities.Cotas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ConsorcioId")
                        .HasColumnType("int");

                    b.Property<int>("NumeroCota")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.HasIndex("ConsorcioId");

                    b.ToTable("Cotas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConsorcioId = 1,
                            NumeroCota = 5656,
                            Status = "Disponível",
                            Valor = 50000m
                        },
                        new
                        {
                            Id = 11,
                            ConsorcioId = 2,
                            NumeroCota = 5656,
                            Status = "Disponível",
                            Valor = 20000m
                        },
                        new
                        {
                            Id = 21,
                            ConsorcioId = 3,
                            NumeroCota = 5656,
                            Status = "Disponível",
                            Valor = 7000m
                        },
                        new
                        {
                            Id = 2,
                            ConsorcioId = 1,
                            NumeroCota = 4226,
                            Status = "Disponível",
                            Valor = 50000m
                        },
                        new
                        {
                            Id = 12,
                            ConsorcioId = 2,
                            NumeroCota = 4226,
                            Status = "Disponível",
                            Valor = 20000m
                        },
                        new
                        {
                            Id = 22,
                            ConsorcioId = 3,
                            NumeroCota = 4226,
                            Status = "Disponível",
                            Valor = 7000m
                        },
                        new
                        {
                            Id = 3,
                            ConsorcioId = 1,
                            NumeroCota = 2451,
                            Status = "Disponível",
                            Valor = 50000m
                        },
                        new
                        {
                            Id = 13,
                            ConsorcioId = 2,
                            NumeroCota = 2451,
                            Status = "Disponível",
                            Valor = 20000m
                        },
                        new
                        {
                            Id = 23,
                            ConsorcioId = 3,
                            NumeroCota = 2451,
                            Status = "Disponível",
                            Valor = 7000m
                        },
                        new
                        {
                            Id = 4,
                            ConsorcioId = 1,
                            NumeroCota = 3643,
                            Status = "Disponível",
                            Valor = 50000m
                        },
                        new
                        {
                            Id = 14,
                            ConsorcioId = 2,
                            NumeroCota = 3643,
                            Status = "Disponível",
                            Valor = 20000m
                        },
                        new
                        {
                            Id = 24,
                            ConsorcioId = 3,
                            NumeroCota = 3643,
                            Status = "Disponível",
                            Valor = 7000m
                        },
                        new
                        {
                            Id = 5,
                            ConsorcioId = 1,
                            NumeroCota = 2592,
                            Status = "Disponível",
                            Valor = 50000m
                        },
                        new
                        {
                            Id = 15,
                            ConsorcioId = 2,
                            NumeroCota = 2592,
                            Status = "Disponível",
                            Valor = 20000m
                        },
                        new
                        {
                            Id = 25,
                            ConsorcioId = 3,
                            NumeroCota = 2592,
                            Status = "Disponível",
                            Valor = 7000m
                        },
                        new
                        {
                            Id = 6,
                            ConsorcioId = 1,
                            NumeroCota = 2729,
                            Status = "Disponível",
                            Valor = 50000m
                        },
                        new
                        {
                            Id = 16,
                            ConsorcioId = 2,
                            NumeroCota = 2729,
                            Status = "Disponível",
                            Valor = 20000m
                        },
                        new
                        {
                            Id = 26,
                            ConsorcioId = 3,
                            NumeroCota = 2729,
                            Status = "Disponível",
                            Valor = 7000m
                        },
                        new
                        {
                            Id = 7,
                            ConsorcioId = 1,
                            NumeroCota = 8135,
                            Status = "Disponível",
                            Valor = 50000m
                        },
                        new
                        {
                            Id = 17,
                            ConsorcioId = 2,
                            NumeroCota = 8135,
                            Status = "Disponível",
                            Valor = 20000m
                        },
                        new
                        {
                            Id = 27,
                            ConsorcioId = 3,
                            NumeroCota = 8135,
                            Status = "Disponível",
                            Valor = 7000m
                        },
                        new
                        {
                            Id = 8,
                            ConsorcioId = 1,
                            NumeroCota = 5524,
                            Status = "Disponível",
                            Valor = 50000m
                        },
                        new
                        {
                            Id = 18,
                            ConsorcioId = 2,
                            NumeroCota = 5524,
                            Status = "Disponível",
                            Valor = 20000m
                        },
                        new
                        {
                            Id = 28,
                            ConsorcioId = 3,
                            NumeroCota = 5524,
                            Status = "Disponível",
                            Valor = 7000m
                        },
                        new
                        {
                            Id = 9,
                            ConsorcioId = 1,
                            NumeroCota = 9622,
                            Status = "Disponível",
                            Valor = 50000m
                        },
                        new
                        {
                            Id = 19,
                            ConsorcioId = 2,
                            NumeroCota = 9622,
                            Status = "Disponível",
                            Valor = 20000m
                        },
                        new
                        {
                            Id = 29,
                            ConsorcioId = 3,
                            NumeroCota = 9622,
                            Status = "Disponível",
                            Valor = 7000m
                        },
                        new
                        {
                            Id = 10,
                            ConsorcioId = 1,
                            NumeroCota = 5005,
                            Status = "Disponível",
                            Valor = 50000m
                        },
                        new
                        {
                            Id = 20,
                            ConsorcioId = 2,
                            NumeroCota = 5005,
                            Status = "Disponível",
                            Valor = 20000m
                        },
                        new
                        {
                            Id = 30,
                            ConsorcioId = 3,
                            NumeroCota = 5005,
                            Status = "Disponível",
                            Valor = 7000m
                        });
                });

            modelBuilder.Entity("back_end.Domain.Entities.Cadastro", b =>
                {
                    b.HasOne("back_end.Domain.Entities.Cotas", null)
                        .WithMany()
                        .HasForeignKey("CotaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("back_end.Domain.Entities.Cotas", b =>
                {
                    b.HasOne("back_end.Domain.Entities.Consorcios", null)
                        .WithMany()
                        .HasForeignKey("ConsorcioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
