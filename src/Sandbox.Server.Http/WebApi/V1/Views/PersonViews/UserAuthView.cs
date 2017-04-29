using System;
using System.Collections.Generic;
using Sandbox.Server.DomainObjects.Models;
using Sandbox.Server.Http.WebApi.V1.Views.Abstract;

namespace Sandbox.Server.Http.WebApi.V1.Views.PersonViews
{
    public class RootUserAuthView
    {
        public UserAuthView User {get;set;}
    }

    public class UserAuthView : EntityView<Person>
    {
        public UserAuthView() : base()
        {
        }

        public UserAuthView(Person person) : base(person)
        {
        }

        public string Username { get; set; }
    
        public string Email { get; set; }

        public string Bio {get;set;}

        public string Image {get;set;}

        public string Token {get;set;}

    }
}