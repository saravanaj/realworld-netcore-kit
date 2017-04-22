using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sandbox.Server.DomainObjects.Interfaces.Handlers;
using Sandbox.Server.DomainObjects.Interfaces.Handlers.Abstract;
using Sandbox.Server.DomainObjects.Models;
using Sandbox.Server.Http.WebApi.V1.Controllers.Abstract;

namespace Sandbox.Server.Http.WebApi.V1.Controllers
{

    [Route("api/articles")]
    [Route("api/tags")]
    public class ArticleController : EntityController<Article, IEntityHandler<Article>>
    {
        public ArticleController(IArticleHandler handler) : base(handler)
        {

        }

        [Route("feed")]
        [HttpGet]
        public async Task<IEnumerable<Article>> Feed(){
            
            var list = await _handler.RetrieveAll();
            return list;
        }

        [HttpPost]
        public async Task<Article> Post([FromBody] Article request)
        {
            var entity = await _handler.Create(request);

            Response.StatusCode = 201;
            return entity;
        }
    }
}