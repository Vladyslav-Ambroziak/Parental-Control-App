using Microsoft.EntityFrameworkCore;
using Parental_Control_WinForms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parental_Control_WinForms.ModelView
{
    internal class MyContextDB : DbContext
    {
        public DbSet<LockedApp> LockedApps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=HOME;Database=My_DataBase;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
