using System;
using System.Collections.Generic;
using Sandbox.Server.DomainObjects.Models;
using Sandbox.Server.Http.WebApi.V1.Views.Abstract;

namespace Sandbox.Server.Http.WebApi.V1.Views.PersonViews
{
    public class ProvileView : EntityView<Person>
    {
        public ProvileView() : base()
        {
        }

        public ProvileView(Person person) : base(person)
        {
        }

           public string username { get; set; }

            public string bio {get;set;}

            public string image {get;set;}

            public bool following {get;set;}

    }
}