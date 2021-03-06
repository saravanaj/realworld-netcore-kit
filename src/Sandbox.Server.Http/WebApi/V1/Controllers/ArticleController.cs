using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sandbox.Server.DomainObjects.Interfaces.Handlers;
using Sandbox.Server.DomainObjects.Interfaces.Handlers.Abstract;
using Sandbox.Server.DomainObjects.Models;
using Sandbox.Server.Http.WebApi.V1.Controllers.Abstract;
using Sandbox.Server.Http.WebApi.V1.Views.ArticleViews;
using System.Linq;
using Sandbox.Server.DomainObjects.Interfaces.Repositories;
using System;

namespace Sandbox.Server.Http.WebApi.V1.Controllers
{

    [Route("api")]
    public class ArticleController : EntityController<Article, IEntityHandler<Article>>
    {
        private IArticleRepository _repository;

        public ArticleController(IArticleHandler handler, IArticleRepository repository) : base(handler)
        {
            this._repository = repository;
        }


        [HttpPost]
        [Route("articles")]
        public async Task<JsonResult> Create([FromBody] RootArticleView request)
        {
            Article entity = new Article();
            request.Article.Hydrate(entity);

            var created = await _handler.Create(entity);

            Response.StatusCode = 201;

            // anon type to have "article" root object name (API contract)
            return Json(new RootArticleView() { Article = new ArticleView(created) } );
        }


        [Route("articles/feed")]
        [HttpGet]
        public async Task<ArticlesView> Feed(){
            
            var list = await _handler.RetrieveAll();
            var articles = new ArticlesView();
            // map domain objects to view objects
            articles.Articles = list.Select(x => new ArticleView(x)).ToList();
            articles.ArticlesCount = list.Count();
            return articles;
        }

        public async Task<IEnumerable<Article>> GetBy([FromQuery]string author = "", [FromQuery]string favorited = "", [FromQuery]string tag = "" ){
            // TODO 
            throw new NotImplementedException();

            var list = await _handler.RetrieveAll();
            return list;
        }

        [Route("articles/{slug}")]
        [HttpGet]
        public async Task<RootArticleView> Get([FromQuery]string slug ){
            
            var model = await _repository.RetrieveSingleBySlug(slug);
            return new RootArticleView() { Article = new ArticleView(model) };
        }

        [Route("articles/{slug}")]
        [HttpPut]
        public async Task<RootArticleView> Update([FromQuery]string slug, [FromBody]RootArticleView articleVm ){
            
            // TODO 
            throw new NotImplementedException();

        }

        [Route("articles/{slug}")]
        [HttpDelete]
        public async Task<RootArticleView> Delete([FromQuery]string slug ){
             // TODO 
            throw new NotImplementedException();

        }

        [Route("articles/{slug}/favorite")]
        [HttpPost]
        public async Task<RootArticleView> Favorite([FromQuery]string slug ){
            
            // TODO 
            throw new NotImplementedException();

        }

        [Route("articles/{slug}/favorite")]
        [HttpDelete]
        public async Task<RootArticleView> Unfavorite([FromQuery]string slug ){
             // TODO 
            throw new NotImplementedException();

        }


    }
}