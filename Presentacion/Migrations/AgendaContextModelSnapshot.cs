﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Presentacion.Modelos;

#nullable disable

namespace Presentacion.Migrations
{
    [DbContext(typeof(AgendaContext))]
    partial class AgendaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Presentacion.Modelos.Contacto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Direccion")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<bool?>("Favorito")
                        .HasColumnType("bit");

                    b.Property<int?>("LocalidadId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<long?>("Telefono")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("LocalidadId");

                    b.ToTable("Contactos");
                });

            modelBuilder.Entity("Presentacion.Modelos.Localidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CodigoPostal")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProvinciaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProvinciaId");

                    b.ToTable("Localidades");
                });

            modelBuilder.Entity("Presentacion.Modelos.Provincia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Region")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Provincias");
                });

            modelBuilder.Entity("Presentacion.Modelos.Contacto", b =>
                {
                    b.HasOne("Presentacion.Modelos.Localidad", "Localidad")
                        .WithMany()
                        .HasForeignKey("LocalidadId");

                    b.Navigation("Localidad");
                });

            modelBuilder.Entity("Presentacion.Modelos.Localidad", b =>
                {
                    b.HasOne("Presentacion.Modelos.Provincia", "Provincia")
                        .WithMany()
                        .HasForeignKey("ProvinciaId");

                    b.Navigation("Provincia");
                });
#pragma warning restore 612, 618
        }
    }
}
