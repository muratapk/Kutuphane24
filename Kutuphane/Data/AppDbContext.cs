using Kutuphane.Models;
using Microsoft.EntityFrameworkCore;

namespace Kutuphane.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Kitap> Kitaps { get; set; }
        public DbSet<Odunc> Oduncs { get; set; }
        public DbSet<Uyeler> Uyelers { get; set; }
        public DbSet<Yazarlar> Yazarlars { get; set; }
        public DbSet<Kategoriler> Kategorilers { get; set; }
        public DbSet<Admin> Admins { get; set; }

    }
}
