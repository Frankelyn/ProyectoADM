﻿// <auto-generated />
using System;
using CondominioADM.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CondominioADM.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20211201183015_Segunda Migracion")]
    partial class SegundaMigracion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("CondominioADM.Entidades.Apartamentos", b =>
                {
                    b.Property<int>("ApartamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Disponible")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Habitaciones")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Numero")
                        .HasColumnType("INTEGER");

                    b.Property<float>("PrecioRenta")
                        .HasColumnType("REAL");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ApartamentoId");

                    b.ToTable("Apartamentos");
                });

            modelBuilder.Entity("CondominioADM.Entidades.ArriendaApartamentos", b =>
                {
                    b.Property<int>("ArriendaApartamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ApartamentoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("TEXT");

                    b.Property<int>("ResidenteId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ArriendaApartamentoId");

                    b.HasIndex("ApartamentoId");

                    b.HasIndex("ResidenteId");

                    b.ToTable("ArriendaApartamentos");
                });

            modelBuilder.Entity("CondominioADM.Entidades.ArriendaParqueos", b =>
                {
                    b.Property<int>("ArriendaParqueosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("TEXT");

                    b.Property<int>("ParqueoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ResidenteId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ArriendaParqueosId");

                    b.HasIndex("ParqueoId");

                    b.HasIndex("ResidenteId");

                    b.ToTable("ArriendaParqueos");
                });

            modelBuilder.Entity("CondominioADM.Entidades.DepositoApartamento", b =>
                {
                    b.Property<int>("DepositoApartamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ApartamentoId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Monto")
                        .HasColumnType("REAL");

                    b.Property<int>("ResidenteId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DepositoApartamentoId");

                    b.HasIndex("ApartamentoId");

                    b.HasIndex("ResidenteId");

                    b.ToTable("DepositoApartamento");
                });

            modelBuilder.Entity("CondominioADM.Entidades.DepositoParqueo", b =>
                {
                    b.Property<int>("DepositoParqueoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Monto")
                        .HasColumnType("REAL");

                    b.Property<int>("ParqueoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ResidenteId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DepositoParqueoId");

                    b.HasIndex("ParqueoId");

                    b.HasIndex("ResidenteId");

                    b.ToTable("DepositoParqueo");
                });

            modelBuilder.Entity("CondominioADM.Entidades.Deudas", b =>
                {
                    b.Property<int>("DeudaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Monto")
                        .HasColumnType("REAL");

                    b.Property<int>("ResidenteId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Tiempo")
                        .HasColumnType("INTEGER");

                    b.HasKey("DeudaId");

                    b.HasIndex("ResidenteId");

                    b.ToTable("Deudas");
                });

            modelBuilder.Entity("CondominioADM.Entidades.EstadosCiviles", b =>
                {
                    b.Property<int>("EstadoCivilId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.HasKey("EstadoCivilId");

                    b.ToTable("EstadosCiviles");

                    b.HasData(
                        new
                        {
                            EstadoCivilId = 1,
                            Descripcion = "Casado/a"
                        },
                        new
                        {
                            EstadoCivilId = 2,
                            Descripcion = "Soltero/a"
                        });
                });

            modelBuilder.Entity("CondominioADM.Entidades.PagoApartamentos", b =>
                {
                    b.Property<int>("PagoApartamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ApartamentoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArriendaApartamentoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<float>("MontoPago")
                        .HasColumnType("REAL");

                    b.Property<int>("ResidenteId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PagoApartamentoId");

                    b.HasIndex("ArriendaApartamentoId");

                    b.ToTable("PagoApartamentos");
                });

            modelBuilder.Entity("CondominioADM.Entidades.PagoParqueo", b =>
                {
                    b.Property<int>("PagoParqueoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArriendaParqueosId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<float>("MontoPago")
                        .HasColumnType("REAL");

                    b.Property<int>("ParqueoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ResidenteId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PagoParqueoId");

                    b.HasIndex("ArriendaParqueosId");

                    b.ToTable("PagoParqueo");
                });

            modelBuilder.Entity("CondominioADM.Entidades.Parqueos", b =>
                {
                    b.Property<int>("ParqueoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Disponible")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Numero")
                        .HasColumnType("INTEGER");

                    b.Property<float>("PrecioRenta")
                        .HasColumnType("REAL");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ParqueoId");

                    b.ToTable("Parqueos");
                });

            modelBuilder.Entity("CondominioADM.Entidades.Residentes", b =>
                {
                    b.Property<int>("ResidenteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Activo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cedula")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<int>("EstadoCivilId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.Property<int>("SexoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Telefono")
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ResidenteId");

                    b.HasIndex("EstadoCivilId");

                    b.HasIndex("SexoId");

                    b.ToTable("Residentes");
                });

            modelBuilder.Entity("CondominioADM.Entidades.Sexos", b =>
                {
                    b.Property<int>("SexoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.HasKey("SexoId");

                    b.ToTable("Sexos");

                    b.HasData(
                        new
                        {
                            SexoId = 1,
                            Descripcion = "Masculino"
                        },
                        new
                        {
                            SexoId = 2,
                            Descripcion = "Femenino"
                        });
                });

            modelBuilder.Entity("CondominioADM.Entidades.Usuarios", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Clave")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            UsuarioId = 1,
                            Clave = "1234",
                            Email = "fulano@gmail.com",
                            Fecha = new DateTime(2021, 12, 1, 14, 30, 13, 588, DateTimeKind.Local).AddTicks(2835),
                            Nombres = "Admin"
                        });
                });

            modelBuilder.Entity("CondominioADM.Entidades.ArriendaApartamentos", b =>
                {
                    b.HasOne("CondominioADM.Entidades.Apartamentos", "Apartamento")
                        .WithMany()
                        .HasForeignKey("ApartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CondominioADM.Entidades.Residentes", "Residente")
                        .WithMany()
                        .HasForeignKey("ResidenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Apartamento");

                    b.Navigation("Residente");
                });

            modelBuilder.Entity("CondominioADM.Entidades.ArriendaParqueos", b =>
                {
                    b.HasOne("CondominioADM.Entidades.Parqueos", "Parqueo")
                        .WithMany()
                        .HasForeignKey("ParqueoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CondominioADM.Entidades.Residentes", "Residente")
                        .WithMany()
                        .HasForeignKey("ResidenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Parqueo");

                    b.Navigation("Residente");
                });

            modelBuilder.Entity("CondominioADM.Entidades.DepositoApartamento", b =>
                {
                    b.HasOne("CondominioADM.Entidades.Apartamentos", "Apartamento")
                        .WithMany()
                        .HasForeignKey("ApartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CondominioADM.Entidades.Residentes", "Residente")
                        .WithMany()
                        .HasForeignKey("ResidenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Apartamento");

                    b.Navigation("Residente");
                });

            modelBuilder.Entity("CondominioADM.Entidades.DepositoParqueo", b =>
                {
                    b.HasOne("CondominioADM.Entidades.Parqueos", "Parqueo")
                        .WithMany()
                        .HasForeignKey("ParqueoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CondominioADM.Entidades.Residentes", "Residente")
                        .WithMany()
                        .HasForeignKey("ResidenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Parqueo");

                    b.Navigation("Residente");
                });

            modelBuilder.Entity("CondominioADM.Entidades.Deudas", b =>
                {
                    b.HasOne("CondominioADM.Entidades.Residentes", "Residente")
                        .WithMany()
                        .HasForeignKey("ResidenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Residente");
                });

            modelBuilder.Entity("CondominioADM.Entidades.PagoApartamentos", b =>
                {
                    b.HasOne("CondominioADM.Entidades.ArriendaApartamentos", "Arrienda")
                        .WithMany()
                        .HasForeignKey("ArriendaApartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Arrienda");
                });

            modelBuilder.Entity("CondominioADM.Entidades.PagoParqueo", b =>
                {
                    b.HasOne("CondominioADM.Entidades.ArriendaParqueos", "Arrienda")
                        .WithMany()
                        .HasForeignKey("ArriendaParqueosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Arrienda");
                });

            modelBuilder.Entity("CondominioADM.Entidades.Residentes", b =>
                {
                    b.HasOne("CondominioADM.Entidades.EstadosCiviles", "EstadoCivil")
                        .WithMany()
                        .HasForeignKey("EstadoCivilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CondominioADM.Entidades.Sexos", "Sexo")
                        .WithMany()
                        .HasForeignKey("SexoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EstadoCivil");

                    b.Navigation("Sexo");
                });
#pragma warning restore 612, 618
        }
    }
}
