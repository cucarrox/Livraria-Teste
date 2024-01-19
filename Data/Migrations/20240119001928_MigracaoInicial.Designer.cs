﻿// <auto-generated />
using System;
using Livraria.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Livraria.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240119001928_MigracaoInicial")]
    partial class MigracaoInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Livraria.Models.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nacionalidade")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)");

                    b.Property<DateOnly>("Nascimento")
                        .HasColumnType("date");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("autores");
                });

            modelBuilder.Entity("Livraria.Models.Editora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.HasIndex("CNPJ")
                        .IsUnique();

                    b.ToTable("editoras");
                });

            modelBuilder.Entity("Livraria.Models.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AutorId")
                        .HasColumnType("integer");

                    b.Property<int>("EditoraId")
                        .HasColumnType("integer");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Paginas")
                        .HasColumnType("integer");

                    b.Property<double>("Preco")
                        .HasColumnType("numeric(6,2)");

                    b.Property<DateOnly>("Publicacao")
                        .HasColumnType("date");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Versao")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AutorId");

                    b.HasIndex("EditoraId");

                    b.ToTable("livros");
                });

            modelBuilder.Entity("Livraria.Models.Livro", b =>
                {
                    b.HasOne("Livraria.Models.Autor", "Autor")
                        .WithMany()
                        .HasForeignKey("AutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Livraria.Models.Editora", "Editora")
                        .WithMany()
                        .HasForeignKey("EditoraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autor");

                    b.Navigation("Editora");
                });
#pragma warning restore 612, 618
        }
    }
}
