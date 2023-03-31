using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Almacen2.Models;

public partial class Almacen2Context : DbContext
{
    public Almacen2Context()
    {
    }

    public Almacen2Context(DbContextOptions<Almacen2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Producto2> Producto2s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-POJ0MVA\\SQLEXPRESS;Database=Almacen2;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Producto2>(entity =>
        {
            entity.ToTable("Producto2");

            entity.Property(e => e.Descripcion).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
