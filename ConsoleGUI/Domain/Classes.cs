using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Article
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Authors { get; set; }
        public DateTimeOffset? PublishDate { get; set; }
        public string Summary { get; set; }
        public string Url { get; set; }
    }
    public class Log
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Email { get; set; }
        public string RawXML { get; set; }
        public DateTime? SendDate { get; set; }
    }
}
