using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Assignment.Models
{
    public partial class AssignmentContext : DbContext
    {
        public virtual DbSet<Courses> Courses { get; set; }

        public AssignmentContext(DbContextOptions<AssignmentContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Courses>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasColumnType("char(4)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Compulsory)
                    .IsRequired()
                    .HasColumnName("compulsory")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.PrereqCourseCode)
                    .HasColumnName("prereq_course_code")
                    .HasColumnType("char(4)");

                entity.Property(e => e.SemesterOffered).HasColumnName("semester_offered");

                entity.Property(e => e.SemesterOffered2).HasColumnName("semester_offered_2");
            });
        }
    }
}
