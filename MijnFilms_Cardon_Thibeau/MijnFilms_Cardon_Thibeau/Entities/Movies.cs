using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MijnFilms_Cardon_Thibeau.Models;

namespace MijnFilms_Cardon_Thibeau.Entities
{
    public partial class Movies : DbContext
    {
        public virtual DbSet<Movies> Movie { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyShopLi;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>(entity =>
            {
                entity.Property(e => e.MovieID);
                entity.Property(e => e.Title);
                entity.Property(e => e.Year);
                entity.Property(e => e.GenreID);
                entity.Property(e => e.DirectorID);
                entity.Property(e => e.Stars);
                entity.Property(e => e.Description);

            });
        }
    }    
    }
}