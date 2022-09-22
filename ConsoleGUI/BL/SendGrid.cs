using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;
using Domain;

namespace BL
{
    public class SendGrid
    {
        public static async Task SendMail(string recipient)
        {
            var apiKey = "xxxxxxxxxxxxxxxxxxxxxxxxxx";
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("articles@sender.lv", "News Mailer");
            var subject = "Google News XML";
            var to = new EmailAddress(recipient);
            var plainTextContent = "Google News Db XML";
            var htmlContent = "";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);

            var xml = Helpers.GetArticleXML();

            var log = new Log { RawXML = xml, SendDate = DateTime.Now, Email = recipient };
            ArticleContext.AddLog(log);

            msg.AddAttachment("articles.xml", xml.EncodeXML());

            var response = await client.SendEmailAsync(msg);
        }
    }
}