using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using System.Threading.Tasks;
using Domain;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace BL
{
    public static class Helpers
    {
        public static string GetArticleXML()
        {
            var dbArticles = new ArticlesList { Article = ArticleContext.GetArticles() };

            XmlSerializer xsSubmit = new XmlSerializer(typeof(ArticlesList));
            var xml = "";

            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xsSubmit.Serialize(writer, dbArticles);
                    xml = sww.ToString();
                }
            }      
            return xml;
        }
        public static string EncodeXML(this string xml)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(xml);
            return Convert.ToBase64String(bytes);
        }
    }
}
