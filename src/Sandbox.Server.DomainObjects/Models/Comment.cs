using System;
using System.Collections.Generic;
using Sandbox.Server.DomainObjects.Models.Abstract;

namespace Sandbox.Server.DomainObjects.Models
{
    public class Comment : Entity
    {

        public string body {get;set;}

        public Person author {get;set;}

        public Article article {get;set;}
    }
}