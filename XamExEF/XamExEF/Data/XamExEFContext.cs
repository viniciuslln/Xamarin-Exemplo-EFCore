using Microsoft.EntityFrameworkCore;
using System.IO;
using Xamarin.Essentials;
using XamExEF.Models;

namespace XamExEF.Data
{
    internal class XamExEFContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "blogs.db3");

            optionsBuilder
                .UseSqlite($"Filename={dbPath}");
        }
    }
}