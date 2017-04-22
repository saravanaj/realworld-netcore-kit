using Sandbox.Server.DomainObjects.Interfaces.Handlers;
using Sandbox.Server.DomainObjects.Interfaces.Handlers.Abstract;
using Sandbox.Server.DomainObjects.Models;
using Sandbox.Server.Http.WebApi.V1.Controllers.Abstract;

namespace Sandbox.Server.Http.WebApi.V1.Controllers
{

    public class CommentController : EntityController<Comment, IEntityHandler<Comment>>
    {
        public CommentController(ICommentHandler handler) : base(handler)
        {

        }
    }
}