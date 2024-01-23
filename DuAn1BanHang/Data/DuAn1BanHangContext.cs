using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DuAn1BanHang.Models;

namespace DuAn1BanHang.Data
{
    public class DuAn1BanHangContext : DbContext
    {
        public DuAn1BanHangContext (DbContextOptions<DuAn1BanHangContext> options)
            : base(options)
        {
        }

        public DbSet<DuAn1BanHang.Models.Category> Category { get; set; } = default!;

        public DbSet<DuAn1BanHang.Models.Product>? Product { get; set; }

        public DbSet<DuAn1BanHang.Models.User>? User { get; set; }
    }
}
