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
    public class EditFolderHandler : IRequestHandler<EditFolderCommand, FolderModel>
    {
        private readonly IFolderRepository _folderRepository;

        public EditFolderHandler(IFolderRepository folderRepository)
        {
            _folderRepository = folderRepository;
        }

        public Task<FolderModel> Handle(EditFolderCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_folderRepository.EditFolder(request.folderId, request.name));
        }
    }
}
