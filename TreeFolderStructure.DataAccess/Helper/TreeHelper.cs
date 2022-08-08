using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeFolderStructure.DataAccess.Data;
using TreeFolderStructure.DataAccess.Model;

namespace TreeFolderStructure.DataAccess.Helper
{
    public static class TreeHelper
    {
        private static void AddChildren(FolderModel parent, List<FolderModel> folders)
        {
            var children = folders.Where(x => x.ParentId == parent.Id);
            parent.Children = children.ToList();
            foreach (var child in parent.Children)
                AddChildren(child, folders);
        }

        public static List<FolderModel> BuildTree(List<FolderModel> folders)
        {
            List<FolderModel> parents = new List<FolderModel>();

            parents = folders.Where(x => !x.ParentId.HasValue).ToList();

            foreach (var parent in parents)   
                AddChildren(parent, folders);

            return parents;
        }
    }
}
