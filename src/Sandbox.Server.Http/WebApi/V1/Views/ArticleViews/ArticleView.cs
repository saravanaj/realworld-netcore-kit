using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Sandbox.Server.DomainObjects.Models;
using Sandbox.Server.Http.WebApi.V1.Views.Abstract;

namespace Sandbox.Server.Http.WebApi.V1.Views.ArticleViews
{
    public class ArticleView : EntityView<Article>
    {
        public ArticleView() : base()
        {
        }

        public ArticleView(Article model) : base(model)
        {
        }

        public string slug { get; set; }

        public string title { get; set; }

        public string description { get; set; }

        public string body { get; set; }

        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime createdAt { get; set; } = new DateTime();

        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime updatedAt { get; set; } = new DateTime();

        public bool favorited { get; set; }

        public List<string> tagList {get;set; } = new List<string>();

        public int favoritesCount { get; set; }

        public Person author {get;set;}

    }
}