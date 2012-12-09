using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
using System.Configuration;
using System.Net.Mail;
using Womyads.Models;


namespace Womyads.Models
{
    public class EnvMail
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string From { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public string Message { get; set; }
    }
    public class Email
    {
        public void Send(EnvMail contact)
        {
            MailMessage mail = new MailMessage(
                contact.From,
                ConfigurationManager.AppSettings[ContactToEmail],
                contact.Subject,
                contact.Message);
            new SmtpClient().Send(mail);
        }
    }
}
 
