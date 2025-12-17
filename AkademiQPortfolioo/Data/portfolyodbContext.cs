using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using AkademiQPortfolioo.Data;

namespace PortfolyoDbContext
{
    public partial class portfolyodbContext : DbContext
    {
        public portfolyodbContext()
        {
        }

        public portfolyodbContext(DbContextOptions<portfolyodbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AboutTable> AboutTables { get; set; } = null!;
        public virtual DbSet<CategoriesTable> CategoriesTables { get; set; } = null!;
        public virtual DbSet<ContactTable> ContactTables { get; set; } = null!;
        public virtual DbSet<ExperienceTable> ExperienceTables { get; set; } = null!;
        public virtual DbSet<EducationTable> EducationTable { get; set; } = null!;
        public virtual DbSet<HomePage> HomePages { get; set; } = null!;
        public virtual DbSet<NewsTable> NewsTables { get; set; } = null!;
        public virtual DbSet<ProjectTable> ProjectTables { get; set; } = null!;
        public virtual DbSet<ServicesTable> ServicesTables { get; set; } = null!;
        public virtual DbSet<SkilTable> SkilTables { get; set; } = null!;
        public virtual DbSet<TestimonialTable> TestimonialTables { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-PELPDN7\\SQLEXPRESS01;Database=portfolyodb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AboutTable>(entity =>
            {
                entity.HasKey(e => e.AboutId);

                entity.ToTable("AboutTable");

                entity.Property(e => e.AboutId).HasColumnName("AboutID");
            });

            modelBuilder.Entity<CategoriesTable>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("CategoriesTable");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ContactTable>(entity =>
            {
                entity.HasKey(e => e.ContactId);

                entity.ToTable("ContactTable");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.Adress)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(90)
                    .IsFixedLength();

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.İcon)
                    .HasMaxLength(90)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ExperienceTable>(entity =>
            {
                entity.HasKey(e => e.ExperienceId);

                entity.ToTable("ExperienceTable");

                entity.Property(e => e.ExperienceId).HasColumnName("ExperienceID");

                entity.Property(e => e.Description).HasMaxLength(700);

                entity.Property(e => e.DescriptionTitle).HasMaxLength(100);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.Year).HasMaxLength(100);
            });

            modelBuilder.Entity<HomePage>(entity =>
            {
                entity.HasKey(e => e.HomeId);

                entity.ToTable("HomePage");

                entity.Property(e => e.HomeId).HasColumnName("HomeID");

                entity.Property(e => e.ImagePath).HasMaxLength(500);

                entity.Property(e => e.NameSurname).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(150);
            });

            modelBuilder.Entity<NewsTable>(entity =>
            {
                entity.HasKey(e => e.NewsId);

                entity.ToTable("NewsTable");

                entity.Property(e => e.NewsId).HasColumnName("NewsID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.DescriptionTitle).HasMaxLength(150);

                entity.Property(e => e.Image).HasMaxLength(150);

                entity.Property(e => e.Title).HasMaxLength(150);
            });

            modelBuilder.Entity<ProjectTable>(entity =>
            {
                entity.HasKey(e => e.ProjectId);

                entity.ToTable("ProjectTable");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Image).HasMaxLength(500);

                entity.Property(e => e.ProjectName).HasMaxLength(200);

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ProjectTables)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_ProjectTable_CategoriesTable");
            });

            modelBuilder.Entity<ServicesTable>(entity =>
            {
                entity.HasKey(e => e.ExperienceId);

                entity.ToTable("ServicesTable");

                entity.Property(e => e.ExperienceId).HasColumnName("ExperienceID");

                entity.Property(e => e.Description).HasMaxLength(400);

                entity.Property(e => e.Icon).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(100);
            });

            modelBuilder.Entity<SkilTable>(entity =>
            {
                entity.HasKey(e => e.SkilId);

                entity.ToTable("SkilTable");

                entity.Property(e => e.SkilId).HasColumnName("SkilID");

                entity.Property(e => e.Title).HasMaxLength(100);
            });

            modelBuilder.Entity<TestimonialTable>(entity =>
            {
                entity.HasKey(e => e.TestimonialId);

                entity.ToTable("TestimonialTable");

                entity.Property(e => e.TestimonialId).HasColumnName("TestimonialID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
