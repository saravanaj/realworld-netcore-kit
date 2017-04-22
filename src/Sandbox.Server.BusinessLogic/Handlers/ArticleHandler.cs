using Sandbox.Server.BusinessLogic.Handlers.Abstract;
using Sandbox.Server.DomainObjects.Interfaces.Handlers;
using Sandbox.Server.DomainObjects.Interfaces.Repositories;
using Sandbox.Server.DomainObjects.Interfaces.Repositories.Abstract;
using Sandbox.Server.DomainObjects.Models;

namespace Sandbox.Server.BusinessLogic.Handlers
{
    public class ArticleHandler : EntityHandler<Article, IEntityRepository<Article>>, IArticleHandler
    {
        public ArticleHandler(IArticleRepository repository) : base(repository)
        {
        }
    }
}