using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MVCG20250320S1.AppWebMVC.Models;

public partial class ClientesDbContext : DbContext
{
    public ClientesDbContext()
    {
    }

    public ClientesDbContext(DbContextOptions<ClientesDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

   
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Clientes__3214EC0710D4914A");

            entity.Property(e => e.Direccion).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Telefono).HasMaxLength(20);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
