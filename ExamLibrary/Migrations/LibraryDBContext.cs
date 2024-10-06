using Exam.Entities;
using Exam.Helper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Migrations
{
    public class LibraryDBContext : DbContext
    {
        public DbSet<Avtor> Avtors { get; set; }
        public DbSet<Ganr> Ganrs { get; set; }
        public DbSet<Knyga> Knygas { get; set; }
        public DbSet<Vydacnytstvo> Vydacnytstvo { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"workstation id=KsandrOO.mssql.somee.com;
                                            packet size=4096;
                                            user id=Shelr1_SQLLogin_1;
                                            pwd=hdk39xgvik;
                                            data source=KsandrOO.mssql.somee.com;
                                            persist security info=False;
                                            initial catalog=KsandrOO;
                                            TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Avtor>()
                .Property(a => a.SurName)
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnName("Avtor");

            modelBuilder.Entity<Ganr>()
               .Property(c => c.Name)
               .HasMaxLength(100)
               .IsRequired()
               .HasColumnName("Ganr");

            modelBuilder.Entity<Vydacnytstvo>()
               .Property(c => c.Name)
               .HasMaxLength(100)
               .IsRequired()
               .HasColumnName("Vydacnytstvo");

            modelBuilder.Entity<Knyga>()
               .Property(c => c.Name)
               .HasMaxLength(100)
               .IsRequired()
               .HasColumnName("Knyga");

            modelBuilder.Entity<Knyga>()
                .HasOne(k => k.Avtor)
                .WithMany(a => a.Knygi)
                .HasForeignKey(k => k.AvtorId);

            modelBuilder.Entity<Knyga>()
                .HasOne(k => k.Ganr)
                .WithMany(g => g.Knygi)
                .HasForeignKey(k => k.GanrId);

            modelBuilder.Entity<Knyga>()
                .HasOne(k => k.Vydacnytstvo)
                .WithMany(v => v.Knygi)
                .HasForeignKey(k => k.VydacnytstvoId);

            modelBuilder.SeedAvtor();
            modelBuilder.SeedGanr();
            modelBuilder.SeedVydacnytstvo();
            modelBuilder.SeedKnyga();
        }
    }
}