﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using mycellstore.Models;

namespace mycellstore.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Contacto> DataContactos { get; set; }
    public DbSet<Producto> DataProductos { get; set; }
    public DbSet<Proforma> DataProforma { get; set; }
}
