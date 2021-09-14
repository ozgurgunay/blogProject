using BlogProje.DataAccess;
using BlogProje.DataAccess.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace BlogProje.Models
{
    public class EMailVM
    {
        public static bool SendMail(string eMail, int id)
        {
            var varifyUrl = "http" + "://" + "localhost" + ":" + 19817 + "/User/ActivedUser/" + id;
            MailMessage mail = new MailMessage();
            mail.To.Add(eMail);
            mail.Body = "<!DOCTYPE html><html><head><meta charset = 'utf-8'/><title></title></head><body><h2> Merhaba </h2><p> Blog sayfasınıza erişmek için <a href = '" + varifyUrl + "'> buraya </a> tıklayınız. </p></body></html>";
            mail.Subject = "Aktivasyon Mailiniz";
            mail.From = new MailAddress("ozma3535@gmail.com");
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("ozma3535@gmail.com", "oz123321");
            smtp.Send(mail);

            return true;
        }
        

    }
}
