using CondominioADM.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominioADM.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Residentes> Residentes { get; set; }
        public DbSet<Apartamentos> Apartamentos { get; set; }
        public DbSet<Parqueos> Parqueos { get; set; }
        public DbSet<ArriendaParqueos> ArriendaParqueos { get; set; }
        public DbSet<ArriendaApartamentos> ArriendaApartamentos { get; set; }
        public DbSet<DepositoParqueo> DepositoParqueo { get; set; }
        public DbSet<DepositoApartamento> DepositoApartamento { get; set; }
        public DbSet<Deudas> Deudas { get; set; }
        public DbSet<EstadosCiviles> EstadosCiviles { get; set; }
        public DbSet<Sexos> Sexos { get; set; }
        public DbSet<PagoApartamentos> PagoApartamentos { get; set; }
        public DbSet<PagoParqueo> PagoParqueo { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>().HasData(new Usuarios
            {
                UsuarioId = 1,
                Nombres = "Admin",
                Clave = "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4",//Clave 1234
                Fecha = DateTime.Now,
                Email = "fulano@gmail.com"
            });

            modelBuilder.Entity<Sexos>().HasData(new Sexos
            {
                SexoId = 1,
                Descripcion = "Masculino"
            });

            modelBuilder.Entity<Sexos>().HasData(new Sexos
            {
                SexoId = 2,
                Descripcion = "Femenino"
            });

            modelBuilder.Entity<EstadosCiviles>().HasData(new EstadosCiviles
            {
                EstadoCivilId = 1,
                Descripcion = "Casado/a"
            });

            modelBuilder.Entity<EstadosCiviles>().HasData(new EstadosCiviles
            {
                EstadoCivilId = 2,
                Descripcion = "Soltero/a"
            });

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DATA\Condominio.db");
        }
    }
}
