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
        public FolderModel AddFolder(string name, int parentId)
        {
            using (_folderContext)
            {
                var folder = new FolderModel()
                {
                    Name = name,
                    ParentId = parentId != 0 ? parentId : null,
                    Children = new List<FolderModel>()
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

        public FolderModel GetFolderById(int folderId)
        {
            using (_folderContext)
            { 
                return _folderContext.Folder.SingleOrDefault(x => x.Id == folderId); 
            }
        }

        public FolderModel MoveFolder(int folderId, int parentId)
        {
            using (_folderContext)
            {
                var folderToMove = _folderContext.Folder.SingleOrDefault(x => x.Id == folderId);

                if (folderToMove != null)
                {
                    folderToMove.ParentId = parentId;

                    _folderContext.Update(folderToMove);
                    _folderContext.SaveChanges();
                }

                return folderToMove;
            }
        }

        public FolderModel RemoveFolder(int folderId)
        {
            using (_folderContext)
            {
                var folderToRemove = _folderContext.Folder.SingleOrDefault(x => x.Id == folderId);
                if (folderToRemove != null)
                {
                    _folderContext.Remove(folderToRemove);
                    _folderContext.SaveChanges();
                }

                return folderToRemove;
            }
        }

        public FolderModel EditFolder(int folderId, string name)
        {
            using (_folderContext)
            {
                var folderToEdit = _folderContext.Folder.SingleOrDefault(x => x.Id == folderId);

                if (folderToEdit != null)
                {
                    folderToEdit.Name = name;
                    _folderContext.Update(folderToEdit);
                    _folderContext.SaveChanges();
                }

                return folderToEdit;
            }
        }
    }
}
