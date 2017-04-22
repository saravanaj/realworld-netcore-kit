using Sandbox.Server.DomainObjects.Interfaces.Handlers.Abstract;
using Sandbox.Server.DomainObjects.Models;
using Sandbox.Server.Http.WebApi.V1.Controllers.Abstract;

namespace Sandbox.Server.Http.WebApi.V1.Controllers
{

    public class ArticlesController : EntityController<Article, IEntityHandler<Article>>
    {
        public ArticlesController(IArticleHandler handler) : base(handler)
        {

        }
    }
}