using System;
using Microsoft.EntityFrameworkCore;
using EncoraTestBLL.Models;

namespace EncoraTestBLL.DLL
{
    public class EncoraTestContext : DbContext
    {
        public DbSet<Property> Properties { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseSqlServer("Server=localhost,1433; Database=EncoraTest;User=sa; Password=password@");
    }
}
