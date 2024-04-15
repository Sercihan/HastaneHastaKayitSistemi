using System;
using System.Collections.Generic;
using HastaneHastaKayit.Models;
using Microsoft.EntityFrameworkCore;

namespace HastaneHastaKayit.DAL;

public partial class HastaneSistemiContext : DbContext
{
    public HastaneSistemiContext()
    {
    }

    public HastaneSistemiContext(DbContextOptions<HastaneSistemiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Doktor> Doktors { get; set; }

    public virtual DbSet<Hastum> Hasta { get; set; }

    public virtual DbSet<Hemsire> Hemsires { get; set; }

    public virtual DbSet<SistemKullanicisi> SistemKullanicisis { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=JUDGMENTDAY;Database=HastaneSistemi;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Doktor>(entity =>
        {
            entity.ToTable("Doktor");

            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DoktorKimligi)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Sifre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Soyad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tc).HasColumnName("TC");
        });

        modelBuilder.Entity<Hastum>(entity =>
        {
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Soyad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tc).HasColumnName("TC");
            entity.Property(e => e.Telefon)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.Teshis)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Hemsire>(entity =>
        {
            entity.ToTable("Hemsire");

            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Soyad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tc).HasColumnName("TC");
        });

        modelBuilder.Entity<SistemKullanicisi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SistemKu__3214EC07C003F5D9");

            entity.ToTable("SistemKullanicisi");

            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Sifre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
