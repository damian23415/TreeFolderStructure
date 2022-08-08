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
    public class GetFolderByIdHandler : IRequestHandler<GetFolderByIdQuery, FolderModel>
    {
        private readonly IFolderRepository _folderRepository;

        public GetFolderByIdHandler(IFolderRepository folderRepository)
        {
            _folderRepository = folderRepository;
        }

        public Task<FolderModel> Handle(GetFolderByIdQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_folderRepository.GetFolderById(request.folderId));
        }
    }
}
