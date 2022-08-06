using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeFolderStructure.DataAccess.Model;

namespace TreeFolderStructure.DataAccess.Queries
{
    public record GetAllFoldersQuery : IRequest<List<FolderModel>>;
}
