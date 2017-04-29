using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sandbox.Server.DomainObjects.Interfaces.Handlers;
using Sandbox.Server.DomainObjects.Interfaces.Handlers.Abstract;
using Sandbox.Server.DomainObjects.Models;
using Sandbox.Server.Http.WebApi.V1.Controllers.Abstract;
using Sandbox.Server.Http.WebApi.V1.Views.ArticleViews;

namespace Sandbox.Server.Http.WebApi.V1.Controllers
{

    [Route("api")]
    public class ArticleController : EntityController<Article, IEntityHandler<Article>>
    {
        public ArticleController(IArticleHandler handler) : base(handler)
        {

        }

        [Route("articles/feed")]
        [HttpGet]
        public async Task<IEnumerable<Article>> Feed(){
            
            var list = await _handler.RetrieveAll();
            return list;
        }

        [HttpPost]
        [Route("articles")]
        public async Task<JsonResult> Post([FromBody] RootArticleView request)
        {
            Article entity = new Article();
            request.Article.Hydrate(entity);

            var created = await _handler.Create(entity);

            Response.StatusCode = 201;

            // anon type to have "article" root object name (API contract)
            return Json(new RootArticleView() { Article = new ArticleView(created) } );
        }
    }
}