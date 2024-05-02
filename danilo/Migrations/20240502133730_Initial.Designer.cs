﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using victor.Models;

#nullable disable

namespace victor.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240502133730_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("victor.Models.Folha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ano")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Mes")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Quantidade")
                        .HasColumnType("REAL");

                    b.Property<double>("Valor")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("FuncionarioId");

                    b.ToTable("Folhas");
                });

            modelBuilder.Entity("victor.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cpf")
                        .HasColumnType("TEXT");

                    b.Property<int>("FolhaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FolhaId");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("victor.Models.Folha", b =>
                {
                    b.HasOne("victor.Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("victor.Models.Funcionario", b =>
                {
                    b.HasOne("victor.Models.Folha", "Folha")
                        .WithMany()
                        .HasForeignKey("FolhaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Folha");
                });
#pragma warning restore 612, 618
        }
    }
}
