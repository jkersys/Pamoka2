using Microsoft.EntityFrameworkCore;
using P_054_batu_parduotuve.Domain.Models;
using P_054_batu_parduotuve.Infrastructure.Database.InitialData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_054_batu_parduotuve.Infrastructure.Database
{
    public class ParduotuveContext : DbContext
    {  
       
            public ParduotuveContext()
            {
            }
            public ParduotuveContext(DbContextOptions options) : base(options)
            {
            }


            public DbSet<Batas> Batai { get; set; }
            public DbSet<BatuDydis> BatuDydziai { get; set; }
            public DbSet<Pardavimas> Pardavimai { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlite("Data Source=Parduotuve.db");
                    optionsBuilder.UseLazyLoadingProxies();
                }
                base.OnConfiguring(optionsBuilder);
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<BatuDydis>().HasKey(k => k.Id);
                modelBuilder.Entity<BatuDydis>().Property(p => p.Id).HasColumnName("BatuDydisId");

                modelBuilder.Entity<BatuDydis>()
                    .HasOne(o => o.Batas)
                    .WithMany(m => m.Dydziai)
                    .HasForeignKey(f => f.BatasId);

                //modelBuilder.Entity<Batas>()
                //    .HasMany(m => m.Dydziai)
                //    .WithOne(o => o.Batas)
                //    .HasForeignKey(f => f.BatasId);

                modelBuilder.Entity<Pardavimas>()
                    .HasOne(o => o.BatuDydis)
                    .WithMany()
                    .HasForeignKey(f => f.BatuDydisId);

            modelBuilder.Entity<Batas>().HasData(BatasInitialData.DataSeed);
            modelBuilder.Entity<BatuDydis>().HasData(BatuDydisInitialData.DataSeed);


        }


        }
    }