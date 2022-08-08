using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeFolderStructure.DataAccess.Model;

namespace TreeFolderStructure.DataAccess.Data
{
    public interface IFolderRepository
    {
        List<FolderModel> GetAllFolders();
        FolderModel AddFolder(FolderModel folder);
        FolderModel GetFolderById(int id);
        FolderModel MoveFolder(int folderId, int parentId);
        FolderModel RemoveFolder(int folderId);
        FolderModel EditFolder(int folderId, string name);
    }
}
