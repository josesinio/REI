﻿// <auto-generated />
using System;
using Aplicacion.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Aplicacion.Persistencia.Migraciones
{
    [DbContext(typeof(AplicacionDbContext))]
    partial class AplicacionDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Dominio.Dispositivo", b =>
                {
                    b.Property<Guid>("IdDispositivo")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("char(20)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<int>("NumSerie")
                        .HasColumnType("int");

                    b.HasKey("IdDispositivo");

                    b.ToTable("Dispositvo");
                });

            modelBuilder.Entity("Dominio.Falta", b =>
                {
                    b.Property<Guid>("Idfalta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("DispositivoIdDispositivo")
                        .HasColumnType("char(20)");

                    b.Property<int>("IdDispositivo")
                        .HasColumnType("int");

                    b.Property<string>("Mensaje")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Idfalta");

                    b.HasIndex("DispositivoIdDispositivo");

                    b.ToTable("Falta");
                });

            modelBuilder.Entity("Dominio.Medicion", b =>
                {
                    b.Property<Guid>("IdMedicion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("DispositivoIdDispositivo")
                        .HasColumnType("char(20)");

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdDispositivo")
                        .HasColumnType("int");

                    b.Property<string>("Unidad")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<int>("Valor")
                        .HasColumnType("int");

                    b.HasKey("IdMedicion");

                    b.HasIndex("DispositivoIdDispositivo");

                    b.ToTable("Medicion");
                });

            modelBuilder.Entity("Dominio.Notificacion", b =>
                {
                    b.Property<Guid>("IdNotificacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("DispositivoIdDispositivo")
                        .HasColumnType("char(20)");

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdDispositivo")
                        .HasColumnType("int");

                    b.Property<string>("Mensaje")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("IdNotificacion");

                    b.HasIndex("DispositivoIdDispositivo");

                    b.ToTable("Notificacion");
                });

            modelBuilder.Entity("Dominio.Falta", b =>
                {
                    b.HasOne("Dominio.Dispositivo", null)
                        .WithMany("Faltas")
                        .HasForeignKey("DispositivoIdDispositivo");
                });

            modelBuilder.Entity("Dominio.Medicion", b =>
                {
                    b.HasOne("Dominio.Dispositivo", null)
                        .WithMany("Mediciones")
                        .HasForeignKey("DispositivoIdDispositivo");
                });

            modelBuilder.Entity("Dominio.Notificacion", b =>
                {
                    b.HasOne("Dominio.Dispositivo", null)
                        .WithMany("Notificaciones")
                        .HasForeignKey("DispositivoIdDispositivo");
                });

            modelBuilder.Entity("Dominio.Dispositivo", b =>
                {
                    b.Navigation("Faltas");

                    b.Navigation("Mediciones");

                    b.Navigation("Notificaciones");
                });
#pragma warning restore 612, 618
        }
    }
}
