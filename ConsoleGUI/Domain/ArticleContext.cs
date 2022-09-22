using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ArticleContext : DbContext
    {
        public ArticleContext() : base("ArticleContext") { }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Log> Logs { get; set; }

        public static void AddArticle(Article article)
        {
            using (var context = new ArticleContext())
            {
                var entry = context.Articles.Any(w => w.Title == article.Title);

                if (entry)
                    return;

                context.Articles.Add(article);
                context.SaveChanges();
            }
        }
        public static void AddLog(Log log)
        {
            using (var context = new ArticleContext())
            {
                context.Logs.Add(log);
                context.SaveChanges();
            }
        }
        public static List<Contains> GetArticles()
        {
            using (var context = new ArticleContext())
            {
                return context.Articles.Select(s => new Contains { Authors = s.Authors,PublishDate = s.PublishDate, Summary = s.Summary, Title = s.Title, Url = s.Url}).ToList();
            }
        }
        public static List<Log> GetLogs()
        {
            using (var context = new ArticleContext())
            {
                return context.Logs.ToList();
            }
        }
    }
}