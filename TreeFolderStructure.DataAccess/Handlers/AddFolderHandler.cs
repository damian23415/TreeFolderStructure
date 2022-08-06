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
    public class AddFolderHandler : IRequestHandler<AddFolderCommand, FolderModel>
    {
        private readonly IFolderRepository _folderRepository;

        public AddFolderHandler(IFolderRepository folderRepository)
        {
            _folderRepository = folderRepository;
        }
        public Task<FolderModel> Handle(AddFolderCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_folderRepository.AddFolder(request.model));
        }
    }
}
