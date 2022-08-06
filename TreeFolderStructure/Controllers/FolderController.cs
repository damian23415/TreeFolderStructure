using MediatR;
using Microsoft.AspNetCore.Mvc;
using TreeFolderStructure.DataAccess.Commands;
using TreeFolderStructure.DataAccess.Model;
using TreeFolderStructure.DataAccess.Queries;

namespace TreeFolderStructure.Controllers
{
    [Route("api/[controller]")]
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
    }
}
