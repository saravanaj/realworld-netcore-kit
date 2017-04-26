using System;
using System.Collections.Generic;
using Sandbox.Server.DomainObjects.Models.Abstract;

namespace Sandbox.Server.DomainObjects.Models
{
    public class Comment : Entity
    {

        public string Body {get;set;}

        public Person Author {get;set;}

        public Article Article {get;set;}
    }
}