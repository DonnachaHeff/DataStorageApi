using DataStorage.EF.Configurations;
using DataStorage.EF.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataStorage.EF.Context
{
    public class DataStorageContext : DbContext
    {
        public string DbPath { get; }

        public DataStorageContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "dataStorage.db");
        }

        public DbSet<ExpectedObject> ExpectedObjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
                    => options.UseSqlServer("Server=.\\SQLExpress;Database=data-storage-db;Trusted_Connection=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ExpectedObjectConfiguration());
        }
    }
}
