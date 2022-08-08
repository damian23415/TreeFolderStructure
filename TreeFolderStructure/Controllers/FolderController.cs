using MediatR;
using Microsoft.AspNetCore.Mvc;
using TreeFolderStructure.DataAccess.Commands;
using TreeFolderStructure.DataAccess.Model;
using TreeFolderStructure.DataAccess.Queries;

namespace TreeFolderStructure.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FolderController : Controller
    {
        private readonly IMediator _mediator;
        public FolderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<FolderModel>> GetAllFolders()
        {
            return await _mediator.Send(new GetAllFoldersQuery());
        }

        [HttpPost]
        public async Task<FolderModel> AddFolder([FromBody] FolderModel folder)
        {
            return await _mediator.Send(new AddFolderCommand(folder));
        }

        [HttpDelete]
        [Route("{folderId}")]
        public async Task<FolderModel> DeleteFolder([FromRoute] int folderId)
        {
            return await _mediator.Send(new RemoveFolderCommand(folderId));
        }

        [HttpGet]
        [Route("{folderId}")]
        public async Task<FolderModel> GetFolderById([FromRoute] int folderId)
        {
            return await _mediator.Send(new GetFolderByIdQuery(folderId));
        }
    }
}
