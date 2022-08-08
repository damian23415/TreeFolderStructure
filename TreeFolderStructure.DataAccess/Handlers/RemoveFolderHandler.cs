using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeFolderStructure.DataAccess.Commands;
using TreeFolderStructure.DataAccess.Data;
using TreeFolderStructure.DataAccess.Model;

namespace TreeFolderStructure.DataAccess.Handlers
{
    public class RemoveFolderHandler : IRequestHandler<RemoveFolderCommand, FolderModel>
    {
        private readonly IFolderRepository _folderRepository;

        public RemoveFolderHandler(IFolderRepository folderRepository)
        {
            _folderRepository = folderRepository;
        }

        public Task<FolderModel> Handle(RemoveFolderCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_folderRepository.RemoveFolder(request.id));
        }
    }
}
