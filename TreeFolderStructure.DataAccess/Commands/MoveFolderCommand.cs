using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeFolderStructure.DataAccess.Model;

namespace TreeFolderStructure.DataAccess.Commands
{
    public record MoveFolderCommand(int folderId, int parentId) : IRequest<FolderModel>;
}
