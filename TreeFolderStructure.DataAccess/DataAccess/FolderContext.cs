using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeFolderStructure.DataAccess.Model;

namespace TreeFolderStructure.DataAccess.DataAccess
{
    public class FolderContext : DbContext
    {
        public FolderContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FolderModel>().HasData(new FolderModel[]
            {
                new FolderModel{ Id = 20, Name = "Root"},
                new FolderModel{ Id = 21, Name = "Dokumenty", ParentId = 20},
                new FolderModel{ Id = 22, Name = "Wideo", ParentId = 20},
                new FolderModel{ Id = 23, Name = "Obrazki", ParentId = 20},
                new FolderModel{ Id = 24, Name = "Moje zdjęcia", ParentId = 23}
            });
        }

        public DbSet<FolderModel> Folder { get; set; }
    }
}
