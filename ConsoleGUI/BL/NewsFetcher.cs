using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Domain;
using Newtonsoft.Json.Linq;

namespace BL
{
    public static class NewsFetcher
    {
        public static void GetLatestTopics()
        {
            var url = @"https://newsapi.org/v2/top-headlines?sources=google-news&apiKey=xxxxxxxxxxxxx";

            var json = new WebClient().DownloadString(url);

            var jo = JObject.Parse(json);

            var articles = jo["articles"].Select(m => new Article {
                Authors  = (string)m.SelectToken("author")
                , Title = (string)m.SelectToken("title")
                , Summary = (string)m.SelectToken("description")
                , PublishDate = (DateTimeOffset)m.SelectToken("publishedAt")
                , Url = (string)m.SelectToken("url")
            }).ToList();

            foreach(var article in articles)
            {
                ArticleContext.AddArticle(article);
            }
        }        
    }
}