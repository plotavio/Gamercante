﻿// <auto-generated />
using System;
using Gamercante.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Gamercante.Migrations
{
    [DbContext(typeof(GamercanteContext))]
    partial class GamercanteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Gamercante.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao");

                    b.Property<string>("Img");

                    b.Property<string>("Plataforma");

                    b.Property<double>("Preco");

                    b.Property<int>("TipoNegocio");

                    b.Property<string>("Titulo");

                    b.HasKey("Id");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("Gamercante.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Celular");

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Cpf");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Email");

                    b.Property<string>("Endereco");

                    b.Property<string>("Estado");

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
