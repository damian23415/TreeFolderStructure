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

        public DbSet<FolderModel> Folder { get; set; }
    }
}
