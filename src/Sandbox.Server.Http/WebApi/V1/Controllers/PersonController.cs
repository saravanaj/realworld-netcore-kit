using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sandbox.Server.DomainObjects.Interfaces.Handlers;
using Sandbox.Server.DomainObjects.Interfaces.Handlers.Abstract;
using Sandbox.Server.DomainObjects.Models;
using Sandbox.Server.Http.WebApi.V1.Controllers.Abstract;
using Sandbox.Server.Http.WebApi.V1.Views;

namespace Sandbox.Server.Http.WebApi.V1.Controllers
{
   [Route("api/users")]
   [Route("api/user")]
   [Route("api/profiles")]
    public class PersonController : EntityController<Person, IEntityHandler<Person>>
    {
        public PersonController(IPersonHandler handler) : base(handler)
        {
        }

    }
}
