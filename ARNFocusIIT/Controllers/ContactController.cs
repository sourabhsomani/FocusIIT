using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using System.Net;

namespace ARNFocusIIT.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/
        public ActionResult Index()
        {
            return View();
            //return RedirectToAction("EmailSend");
        }
        [HttpPost]
        public ViewResult index(ARNFocusIIT.Models.Mail objMail)
        {
            if (ModelState.IsValid)
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(objMail.Name);
                mail.From = new MailAddress(objMail.Email);
                mail.Subject = objMail.Subject;
                string Body = objMail.Message;
                mail.Body = Body;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential
                ("username", "password");
                smtp.EnableSsl = true;
                smtp.Send(mail);
                return View("Index", objMail);
            }
            else
            {
                return View();
            }
        }
	}
}