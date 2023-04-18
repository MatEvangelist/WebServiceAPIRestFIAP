﻿// <auto-generated />
using System;
using Fiap.Api.AspNet.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace Fiap.Api.AspNet.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20230418024637_Enchente")]
    partial class Enchente
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Fiap.Api.AspNet.Models.AreaDeRiscoModel", b =>
                {
                    b.Property<int>("AreaDeRiscoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AreaDeRiscoId"));

                    b.Property<DateTime>("DataUltimoRegistro")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("LocalizacaoAreaDeRisco")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("NivelRioAreaDeRisco")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("PluviometroId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("RioId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("AreaDeRiscoId");

                    b.ToTable("AreaDeRisco");
                });

            modelBuilder.Entity("Fiap.Api.AspNet.Models.BoiaModel", b =>
                {
                    b.Property<int>("FerramentaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FerramentaId"));

                    b.Property<bool>("AlertaRisco")
                        .HasColumnType("NUMBER(1)");

                    b.Property<string>("DataUltimoRegistro")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("LocalizacaoFerramenta")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("RioId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("StatusRio")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("FerramentaId");

                    b.ToTable("Boia");
                });

            modelBuilder.Entity("Fiap.Api.AspNet.Models.PluviometroModel", b =>
                {
                    b.Property<int>("PluviometroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PluviometroId"));

                    b.Property<string>("DataUltimoRegistro")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("DescricaoPluviometro")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("NivelChuva")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("PluviometroId");

                    b.ToTable("Pluviometro");
                });

            modelBuilder.Entity("Fiap.Api.AspNet.Models.RioModel", b =>
                {
                    b.Property<int>("RioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RioId"));

                    b.Property<string>("DescricaoRio")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("NomeRio")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("RioId");

                    b.ToTable("Rio");
                });
#pragma warning restore 612, 618
        }
    }
}
