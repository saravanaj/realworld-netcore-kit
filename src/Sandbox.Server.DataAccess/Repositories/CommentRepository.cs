using Sandbox.Server.DataAccess.Repositories.Abstract;
using Sandbox.Server.DomainObjects.Interfaces.Repositories;
using Sandbox.Server.DomainObjects.Models;

namespace Sandbox.Server.DataAccess.Repositories
{
  public class CommentRepository : EntityRepository<Comment>, ICommentRepository
  {

  }
}