using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelProject.WebUI.Models.Mail;
using MailKit.Net.Smtp;
using MimeKit;

namespace HotelProject.WebUI.Controllers
{
    public class AdminMailController : Controller
    {//114
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AdminMailViewModel adminMailViewModel)
        {//114
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("SincomOtel", "sincomyazilim@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);//kimden

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", adminMailViewModel.receiverMail);
            mimeMessage.To.Add(mailboxAddressTo);//kime

            var bodyBuilder = new BodyBuilder();//mesajın iceriği
            bodyBuilder.TextBody = adminMailViewModel.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = adminMailViewModel.Subject;
            
            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com",587,false);
            client.Authenticate("sincomyazilim@gmail.com", "qjmiukfekqcjqsnf");
            client.Send(mimeMessage);
            client.Disconnect(true);

            return View();
        }
    }
}
