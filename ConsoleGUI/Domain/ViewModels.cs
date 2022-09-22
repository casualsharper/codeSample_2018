using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ArticlesList
    {
        public List<Contains> Article;
    }
    public class Contains
    {
        public string Title { get; set; }
        public string Authors { get; set; }
        public DateTimeOffset? PublishDate { get; set; }
        public string Summary { get; set; }
        public string Url { get; set; }
    }
}
