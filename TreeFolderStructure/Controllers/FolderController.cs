﻿using MediatR;
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
        public async Task<FolderModel> AddFolder([FromQuery] string name, int parentId)
        {
            return await _mediator.Send(new AddFolderCommand(name, parentId));
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

        [HttpPut]
        public async Task<FolderModel> MoveFolder(int folderId, int parentId)
        {
            return await _mediator.Send(new MoveFolderCommand(folderId, parentId));
        }

        [HttpPut]
        [Route("{folderId}/{name}")]
        public async Task<FolderModel> EditFolder(int folderId, string name)
        {
            return await _mediator.Send(new EditFolderCommand(folderId, name));
        }
    }
}
