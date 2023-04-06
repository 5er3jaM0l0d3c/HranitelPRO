using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Entities;

public partial class UsersContext : DbContext
{
    public UsersContext()
    {
    }

    public UsersContext(DbContextOptions<UsersContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<Otdel> Otdels { get; set; }

    public virtual DbSet<Podrasdel> Podrasdels { get; set; }

    public virtual DbSet<Visitor> Visitors { get; set; }

    public virtual DbSet<Worker> Workers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-V7DEGCSO\\SQLEXPRESS;Initial Catalog=Users;Integrated Security=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Group>(entity =>
        {
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Otdel>(entity =>
        {
            entity.ToTable("Otdel");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Podrasdel>(entity =>
        {
            entity.ToTable("Podrasdel");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Visitor>(entity =>
        {
            entity.Property(e => e.BirthDate).HasColumnType("date");
            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIO");
            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pasport)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.CodeWorkerNavigation).WithMany(p => p.Visitors)
                .HasForeignKey(d => d.CodeWorker)
                .HasConstraintName("FK_Visitors_Worker1");

            entity.HasOne(d => d.Groupe).WithMany(p => p.Visitors)
                .HasForeignKey(d => d.GroupeId)
                .HasConstraintName("FK_Visitors_Groups");
        });

        modelBuilder.Entity<Worker>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("Worker");

            entity.Property(e => e.Code).ValueGeneratedNever();
            entity.Property(e => e.Fio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIO");

            entity.HasOne(d => d.Otdel).WithMany(p => p.Workers)
                .HasForeignKey(d => d.OtdelId)
                .HasConstraintName("FK_Worker_Otdel");

            entity.HasOne(d => d.Podrasdel).WithMany(p => p.Workers)
                .HasForeignKey(d => d.PodrasdelId)
                .HasConstraintName("FK_Worker_Podrasdel");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
