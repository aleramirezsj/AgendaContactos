using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AgendaConsola.Modelos;

public partial class AgendaContext : DbContext
{
    public AgendaContext()
    {
    }

    public AgendaContext(DbContextOptions<AgendaContext> options)
        : base(options)
    {
    }

    //se crean tantos DbSet como tablas existen en la base de datos
    public virtual DbSet<Contacto> Contactos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=agenda;User Id = sa; Password = 123; MultipleActiveResultSets = True; Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contacto>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
