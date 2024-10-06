using Exam.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Helper
{
    public static class DBInitializer
    {
        public static void SeedAvtor(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Avtor>().HasData(
              new Avtor[]
              {
                    new Avtor { Id = 1,SurName = "Boeing 747"},
                    new Avtor { Id = 2,SurName = "Mria"},
                    new Avtor { Id = 3,SurName = "AN 225"}
              });
        }

        public static void SeedGanr(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ganr>().HasData(
              new Ganr[]
              {
                    new Ganr { Id = 1,Name = "BMW"},
                    new Ganr { Id = 2,Name = "AUDI"},
                    new Ganr { Id = 3,Name = "LADA"}
              });
        }

        public static void SeedVydacnytstvo(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vydacnytstvo>().HasData(
              new Vydacnytstvo[]
              {
                    new Vydacnytstvo { Id = 1,Name = "AAAA"},
                    new Vydacnytstvo { Id = 2,Name = "SSS"},
                    new Vydacnytstvo { Id = 3,Name = "DDDDDDD"}
              });
        }

        public static void SeedKnyga(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Knyga>().HasData(
              new Knyga[]
              {
                    new Knyga { Id = 1,Name = "Chorna dyra",CountPages = 1, Year = 2020, Sobivartist = 1200, CinaDlaProdagy = 100000, Prodovgenna = "yes", AvtorId = 1, GanrId = 1, VydacnytstvoId=1   },
                    new Knyga { Id = 2,Name = "Povorot ne tuda",CountPages = 5, Year = 2022, Sobivartist = 12000, CinaDlaProdagy = 1000000, Prodovgenna = "no", AvtorId = 2, GanrId = 2, VydacnytstvoId=2 },
                    new Knyga { Id = 3, Name = "Marianskaa vpadina", CountPages = 10, Year = 2024, Sobivartist = 10200, CinaDlaProdagy = 1000000, Prodovgenna = "yes", AvtorId = 3, GanrId = 3, VydacnytstvoId = 3}
              });
        }
    }
}
