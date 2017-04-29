using System;
using System.Collections.Generic;
using Sandbox.Server.DomainObjects.Models;
using Sandbox.Server.Http.WebApi.V1.Views.Abstract;

namespace Sandbox.Server.Http.WebApi.V1.Views.PersonViews
{
    public class RootProfileView
    {

        public ProfileView Profile {get;set;}

    }

    public class ProfileView : EntityView<Person>
    {
        public ProfileView() : base()
        {
        }

        public ProfileView(Person person) : base(person)
        {
        }

        public string Username { get; set; }

        public string Bio {get;set;}

        public string Image {get;set;}

        public bool Following {get;set;}

    }
}