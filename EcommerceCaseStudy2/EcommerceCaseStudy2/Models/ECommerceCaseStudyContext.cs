using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EcommerceCaseStudy2.Models
{
    public partial class ECommerceCaseStudyContext : DbContext
    {
        public ECommerceCaseStudyContext()
        {
        }

        public ECommerceCaseStudyContext(DbContextOptions<ECommerceCaseStudyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ProductTable> ProductTables { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
          //  if (!optionsBuilder.IsConfigured)
         //   {
         //       optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=ECommerceCaseStudy;Trusted_Connection=True;");
         //   }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ProductTable>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("ProductTable");

                entity.Property(e => e.Category)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ProductColor)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ProductDescription)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
