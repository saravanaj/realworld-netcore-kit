using System;
using System.Collections.Generic;
using Sandbox.Server.DomainObjects.Models;
using Sandbox.Server.Http.WebApi.V1.Views.Abstract;

namespace Sandbox.Server.Http.WebApi.V1.Views.PersonViews
{
    public class RootUserAuthView
    {
        public UserAuthView user {get;set;}
    }

    public class UserAuthView : EntityView<Person>
    {
        public UserAuthView() : base()
        {
        }

        public UserAuthView(Person person) : base(person)
        {
        }

           public string username { get; set; }
    
            public string email { get; set; }

            public string bio {get;set;}

            public string image {get;set;}

            public string token {get;set;}

    }
}