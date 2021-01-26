using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace DevCard_MVC.ViewComponents
{
    public class LateastArticles :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>()
            {
                new Article(1,"PYTHONE","کاملترین دوره آموزشی پایتون","blog-post-thumb-card-1.jpg"),
                new Article(1,"asp.net core","کاملترین دوره آموزشی asp.net core","blog-post-thumb-card-2.jpg"),
                new Article(1,"C#","کاملترین دوره آموزشی C#","blog-post-thumb-card-3.jpg"),
                new Article(1,"JAVA","کاملترین دوره آموزشی JAVA","blog-post-thumb-card-4.jpg"),

            };
            return View("_LateastArticles",articles);
        }

    }
}
