using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            ViewBag.String = "Please call Support at <strong><u>801-555-1212</u></strong>. Thank you!";
            ViewBag.Email = "To get an email from BlowOut, enter your email in the URL followed by a '/' then your name.";
            return View();
        }

        //the route receives an email parameter first to handle user errors with the closing slash '/'
        [Route("email/{email}/{name}")]
        public ActionResult Email(string email, string name)
        {
            //make sure email is valid
            if (email.Contains('@'))
            {
                ViewBag.Email = "Thank you, " + name + ". We will email you at <a>" + email + "</a>";

                //write body message
                string body = name + ", <br><br>Thank you for your interest. We will be in touch shortly.<br><br> Gary Anderson<br>BlowOut CEO";

                //set up email message
                MailMessage mail = new MailMessage();
                mail.To.Add(email);
                mail.From = new MailAddress("profgaryanderson@gmail.com");
                mail.Subject = "BlowOut Contact";
                mail.Body = body;
                mail.IsBodyHtml = true;

                //set up smtp client
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("profgaryanderson@gmail.com", "Magsungay17");
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
            //handle exception
            else
            {
                ViewBag.Email = "Please enter a valid email address. Thank you.";
            }
            

            return View("Index");
        }
    }
}