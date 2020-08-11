﻿// <auto-generated />
using System;
using Data.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Infrastructure.Migrations
{
    [DbContext(typeof(BibliotecaContext))]
    [Migration("20200811064404_AddedMoleculeModel")]
    partial class AddedMoleculeModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Model.Models.AutorModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataSintese")
                        .HasColumnType("datetime2");

                    b.Property<string>("Molecula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Autores");
                });

            modelBuilder.Entity("Domain.Model.Models.MoleculaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AutorId")
                        .HasColumnType("int");

                    b.Property<string>("FormulaMolecular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Lancamento")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Rendimento")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TipoReacao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AutorId");

                    b.ToTable("Moleculas");
                });

            modelBuilder.Entity("Domain.Model.Models.MoleculaModel", b =>
                {
                    b.HasOne("Domain.Model.Models.AutorModel", "Autor")
                        .WithMany("Moleculas")
                        .HasForeignKey("AutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
