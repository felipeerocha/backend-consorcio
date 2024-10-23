using Microsoft.EntityFrameworkCore;
using back_end.Domain.Entities;
using System;
using System.Collections.Generic;

namespace back_end.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Consorcios> Consorcios { get; set; }
        public DbSet<Cotas> Cotas { get; set; }
        public DbSet<Cadastro> Cadastros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var consorcios = new List<Consorcios>
            {
                new Consorcios { Id = 1, Titulo = "Consórcio de Casa", Tipo = "Imóvel", Valor = 500000, QuantidadeCotas = 10 },
                new Consorcios { Id = 2, Titulo = "Consórcio de Carro", Tipo = "Carro", Valor = 200000, QuantidadeCotas = 10 },
                new Consorcios { Id = 3, Titulo = "Consórcio de Reforma", Tipo = "Serviço", Valor = 70000, QuantidadeCotas = 10 }
            };
            modelBuilder.Entity<Consorcios>().HasData(consorcios);

            var random = new Random();
            var usedNumbers = new HashSet<int>();

            for (int i = 0; i < 10; i++)
            {
                int numeroCota;
                do
                {
                    numeroCota = random.Next(1000, 10000); 
                } while (!usedNumbers.Add(numeroCota));

                modelBuilder.Entity<Cotas>().HasData(new Cotas
                {
                    Id = i + 1,
                    ConsorcioId = 1,
                    NumeroCota = numeroCota,
                    Valor = 50000,
                    Status = "Disponível"
                });

                modelBuilder.Entity<Cotas>().HasData(new Cotas
                {
                    Id = i + 11,
                    ConsorcioId = 2,
                    NumeroCota = numeroCota,
                    Valor = 20000,
                    Status = "Disponível"
                });

                modelBuilder.Entity<Cotas>().HasData(new Cotas
                {
                    Id = i + 21,
                    ConsorcioId = 3,
                    NumeroCota = numeroCota,
                    Valor = 7000,
                    Status = "Disponível"
                });
            }

            modelBuilder.Entity<Cotas>()
                .HasOne<Consorcios>()
                .WithMany()
                .HasForeignKey(c => c.ConsorcioId);

            modelBuilder.Entity<Cadastro>()
                .HasOne<Cotas>()
                .WithMany()
                .HasForeignKey(c => c.CotaId);

            modelBuilder.Entity<Cotas>()
                .Property(c => c.Valor)
                .HasColumnType("decimal(18, 2)");
        }
    }
}
