using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;
using Sandbox.Server.DataAccess.Repositories.Abstract;
using Sandbox.Server.DomainObjects.Interfaces.Repositories;
using Sandbox.Server.DomainObjects.Models;

namespace Sandbox.Server.DataAccess.Repositories
{
    public class ArticleRepository : EntityRepository<Article>, IArticleRepository
    {

        public virtual async Task<Article> RetrieveSingleBySlug(string slug)
        {
            var filter = Builders<Article>.Filter.Eq("Slug", slug);

            var list = await collectionHandler.ReadOnly<Article>().FindAsync(filter);
            return await list.FirstOrDefaultAsync();
        }
    }
}