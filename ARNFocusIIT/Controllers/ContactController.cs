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
            return View(new ARNFocusIIT.Models.Mail());
            //return RedirectToAction("EmailSend");
        }
        [HttpPost]
        public ViewResult index(ARNFocusIIT.Models.Mail objMail)
        {
            if (ModelState.IsValid)
            {
                MailMessage message = new MailMessage();
                SmtpClient smtpClient = new SmtpClient();
                string msg = string.Empty;
                try
                {
                    MailMessage m = new MailMessage();
                    m.From = new MailAddress("info@focusiit.com");
                    m.To.Add("focusiit2014@gmail.com");
                    m.Body = @"<h1>Subject : " + objMail.Subject + "</h1><h3>My Name is:" + objMail.Name + "</h3> <h3>My Email:" + objMail.Email + "</h3><p><strong>Message:</strong>" + objMail.Message + "</p></div>";
                    m.Subject =objMail.Subject;
                    m.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient("relay-hosting.secureserver.net");
                    smtp.UseDefaultCredentials = true;
                    smtp.Send(m);

                    ViewBag.Error = "Your email successfully sent.";
                }
                catch (Exception ex)
                {
                    ViewBag.Error = ex.Message;
                }
                return View();
            }
            else
            {
                return View();
            }
        }
	}
}