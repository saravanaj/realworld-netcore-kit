using System;
using System.Collections.Generic;
using Sandbox.Server.DomainObjects.Models.Abstract;

namespace Sandbox.Server.DomainObjects.Models
{
    public class Article : Entity
    {
        public string slug { get; set; }

        public string title { get; set; }

        public string description { get; set; }

        public string body { get; set; }

        public List<String> tagList { get; set; }

        public Guid authorId {get;set;}

        public List<Guid> comments {get;set;}
    }
}