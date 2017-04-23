using System;
using System.Collections.Generic;
using Sandbox.Server.DomainObjects.Models;
using Sandbox.Server.Http.WebApi.V1.Views.Abstract;

namespace Sandbox.Server.Http.WebApi.V1.Views.ArticleViews
{
    public class RootArticleView
    {
        public RootArticleView()
        {
        }

        public ArticleView article {get;set;}

    }
}