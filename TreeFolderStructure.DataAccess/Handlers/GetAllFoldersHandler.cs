using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeFolderStructure.DataAccess.Data;
using TreeFolderStructure.DataAccess.Model;
using TreeFolderStructure.DataAccess.Queries;

namespace TreeFolderStructure.DataAccess.Handlers
{
    public class GetAllFoldersHandler : IRequestHandler<GetAllFoldersQuery, List<FolderModel>>
    {
        private readonly IFolderRepository _folderRepository;

        public GetAllFoldersHandler(IFolderRepository folderRepository)
        {
            _folderRepository = folderRepository;
        }

        public Task<List<FolderModel>> Handle(GetAllFoldersQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_folderRepository.GetAllFolders());
        }
    }
}
