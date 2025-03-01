using System;
using System.Collections.Generic;
using ExamenBASEA.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamenBASEA.Context;

public partial class BaseaContext : DbContext
{
    public BaseaContext()
    {
    }

    public BaseaContext(DbContextOptions<BaseaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Estudiante> Estudiantes { get; set; }

    public virtual DbSet<Libro> Libros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-G7I0G2V\\SQLEXPRESS; Initial Catalog=BASEA; User ID=sa; Password=Eli_21@; Trust Server Certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Estudiante>(entity =>
        {
            entity.HasKey(e => e.EstudianteId).HasName("PK__ESTUDIAN__6F76833899D0253C");

            entity.ToTable("ESTUDIANTES");

            entity.Property(e => e.EstudianteId).HasColumnName("EstudianteID");
            entity.Property(e => e.Apellido)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Carrera)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreacion).HasColumnName("Fecha_Creacion");
            entity.Property(e => e.FechaNacimiento).HasColumnName("Fecha_Nacimiento");
            entity.Property(e => e.Genero)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Semestre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Libro>(entity =>
        {
            entity.HasKey(e => e.LibroId).HasName("PK__LIBROS__35A1EC8D0396DAA3");

            entity.ToTable("LIBROS");

            entity.Property(e => e.LibroId).HasColumnName("LibroID");
            entity.Property(e => e.AnioPublicacion).HasColumnName("Anio_Publicacion");
            entity.Property(e => e.Autor)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Editorial)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreacion).HasColumnName("Fecha_Creacion");
            entity.Property(e => e.Genero)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Idioma)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Isbn)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ISBN");
            entity.Property(e => e.NumeroPaginas).HasColumnName("Numero_Paginas");
            entity.Property(e => e.Titulo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
