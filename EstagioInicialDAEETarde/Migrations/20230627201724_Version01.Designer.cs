﻿// <auto-generated />
using EstagioInicialDAEETarde.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EstagioInicialDAEETarde.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20230627201724_Version01")]
    partial class Version01
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EstagioInicialDAEETarde.Models.Git", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.Property<string>("Descricao")
                        .HasMaxLength(120)
                        .HasColumnType("varchar(120)")
                        .HasColumnName("Descricao");

                    b.Property<string>("Titulo")
                        .HasColumnType("longtext")
                        .HasColumnName("Titulo");

                    b.HasKey("Id");

                    b.ToTable("gitContent");
                });
#pragma warning restore 612, 618
        }
    }
}
