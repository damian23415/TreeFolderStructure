using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeFolderStructure.DataAccess.DataAccess;
using TreeFolderStructure.DataAccess.Model;

namespace TreeFolderStructure.DataAccess.Data
{
    public class FolderRepository : IFolderRepository
    {
        private readonly FolderContext _folderContext;

        public FolderRepository(FolderContext folderContext)
        {
            _folderContext = folderContext;
        }
        public FolderModel AddFolder(FolderModel model)
        {
            using (_folderContext)
            {
                var folder = new FolderModel()
                {
                    Id = model.Id,
                    Name = model.Name,
                    ParentId = model.ParentId
                };

                _folderContext.Folder.Add(folder);
                _folderContext.SaveChanges();
                return folder;
            }
        }

        public List<FolderModel> GetAllFolders()
        {
            using (_folderContext)
            {
                return _folderContext.Folder.ToList();
            }
        }

        public FolderModel GetFolderById(int id)
        {
            throw new NotImplementedException();
        }

        public FolderModel MoveFolder(int folderId, int parentId)
        {
            throw new NotImplementedException();
        }
    }
}
