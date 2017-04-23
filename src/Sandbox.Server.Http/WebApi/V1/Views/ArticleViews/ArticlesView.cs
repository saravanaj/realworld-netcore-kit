using System;
using System.Collections.Generic;
using Sandbox.Server.DomainObjects.Models;
using Sandbox.Server.Http.WebApi.V1.Views.Abstract;

namespace Sandbox.Server.Http.WebApi.V1.Views.ArticleViews
{
    public class ArticlesView
    {
        public ArticlesView()
        {
        }

        public List<ArticleView> articles {get;set;}

    }
}