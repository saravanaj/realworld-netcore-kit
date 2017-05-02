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
            this.CreatedAt = model.GetCreationDate();
            this.UpdatedAt = model.GetModificationDate();
        }

        public string Slug { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Body { get; set; }

        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime CreatedAt { get; set; } = new DateTime();

        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime UpdatedAt { get; set; } = new DateTime();

        public bool Favorited { get; set; }

        public List<string> TagList {get;set; } = new List<string>();

        public int FavoritesCount { get; set; }

        public Person Author {get;set;}

    }
}