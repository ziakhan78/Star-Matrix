using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StarMatrix.Models;

namespace StarMatrix.Controllers
{
    public class HomeController : Controller
    {
        private readonly StarMatrixContext _context;       
        private IHostingEnvironment _env;
        public HomeController(IHostingEnvironment env, StarMatrixContext context)
        {
            _env = env;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("About")]
        public IActionResult About()
        {
            return View();
        }

        [Route("Recycling")]
        public IActionResult Recycling()
        {
            return View();
        }

        [Route("Towage")]
        public async Task<IActionResult> Towage()
        {
            var starMatrixContext = _context.ShipLocation.Include(s => s.BollardPulls).Include(s => s.ClassTypes).Include(s => s.EngineHPs).Include(s => s.Tugs);
            return View(await starMatrixContext.ToListAsync());
        }

        [Route("Download")]
        public IActionResult Download()
        {
            return View();
        }

        [Route("Location")]
        public IActionResult Location()
        {
            return View();
        }


        [Route("Contact")]
        public IActionResult Contact()
        {

            return View();
        }

        [Route("Sitemap")]
        public IActionResult Sitemap()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Feedback feedback)
        {
            //if (this.IsCaptchaValid("Captcha is not valid"))
            //{
            if (ModelState.IsValid)
            {
                // feedback.DateAdded = DateTime.Now;
                // feedback.Ipaddress = GetIpaddress(); ;

                // db.Feedback.Add(feedback);
                // db.SaveChanges();
                SendEmail(feedback);
                return View("Contact");
            }
            //}
            //ViewBag.ErrMessage = "Error: captcha is not valid.";
            return View("Contact");
        }

        [AllowAnonymous]
        [NonAction]
        public void SendEmail(Feedback obj)
        {
            try
            {
                string ReadFileName = "";
                MailMessage mail = new MailMessage();

                mail.To.Add(obj.Email);
                //mail.To.Add("info@finefixengineering.com");
                // mail.To.Add("info@drtanaz.com");
                mail.Bcc.Add("zia@goradiainfotech.com");
                //mail.Bcc.Add("finefixengineering@gmail.com");
                mail.From = new MailAddress("mail@finefixengineering.com");
                //mail.Subject = obj.Subject;
                mail.Subject = "Feedback Enquiry Mail";

                mail.IsBodyHtml = true;
                var webRoot = _env.WebRootPath;
                var PathVal = "\\mail\\feedback.htm";

                // string PathVal =Microsoft.AspNetCore.Hosting.Server.Features. .MapPath("~");

                ReadFileName = webRoot + PathVal;

                string strMessage = "";
                StreamReader sr1 = new StreamReader(ReadFileName);

                strMessage = sr1.ReadToEnd();

                strMessage = strMessage.Replace("XXXname", obj.Name);
                strMessage = strMessage.Replace("XXXmobile", obj.Mobile);
                strMessage = strMessage.Replace("XXXemail", obj.Email);
                strMessage = strMessage.Replace("XXXmessage", obj.Message);

                mail.Body = strMessage;
                sr1.Close();

                SmtpClient emailClient = new SmtpClient();
                emailClient.Credentials = new NetworkCredential("mail@finefixengineering.com", "7Ih$pr#6");
                emailClient.Port = 25;
                emailClient.Host = "smtp.yandex.com";
                emailClient.EnableSsl = true;
                emailClient.Send(mail);

                ModelState.Clear();
                ViewBag.Message = "Your enquiry has been submitted successfully.";
            }
            catch (Exception ex)
            {
                ViewBag.ErrMessage = "Problem while sending email, Please check details.";
            }

        }
    }
}
