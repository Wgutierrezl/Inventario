<<<<<<< HEAD
﻿using InventarioControlador.Entidades;
using Microsoft.EntityFrameworkCore;

namespace InventarioBack.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Tipo> Tipos { get; set; }
        // Para crear index y evitar repeticiones de nombres de los tipos de categorias 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Tipo>().HasIndex(c => c.Name).IsUnique();
        }
=======
﻿
using Microsoft.EntityFrameworkCore;
using InventarioControlador.Entidades;
namespace InventarioBack.Data;

    public class DataContext:DbContext 
    {
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }
    public DbSet<Tipo> Tipos { get; set; }
    // Para crear index y evitar repeticiones de nombres de los tipos de categorias
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Tipo>().HasIndex(c => c.Name).IsUnique();
>>>>>>> 9450789f37e32505161c567e7a6390898573df4f
    }
}

