using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QRChecker.Models;
using System.Net;
using QRChecker.Helpers;
using Microsoft.AspNetCore.Http;
using System.IO;


namespace QRChecker.Controllers
{
    public class CheckerController : Controller
    {
        private readonly ILogger<CheckerController> _logger;

        public CheckerController(ILogger<CheckerController> logger)
        {
            _logger = logger;
        }

        [Route("checker/{id?}")]
        public IActionResult Index(string id)
        {
            var qrkey = id;

            //var qrkeys = qrkey.Split(new string[] {"&tkn="}, StringSplitOptions.None);

            var qr_id = id;
            var tkn = HttpContext.Request.Query["tkn"].ToString();

            var last_filename = qr_id.Substring(qr_id.Length - 5);
            var enc_filename = qr_id.Replace(last_filename, "");
            var filename = EncryptDecrypt.Decrypt(enc_filename);
            filename = filename.Trim() + ".pdf";

            // SignerRequest sign_request;
            // SignerFile sign_file;
            // using (var context = new DigiSign2Context())
            // {
            //     var sign_qr = context.SignerQrs.FirstOrDefault(o => o.Qrkey == qrkey);
            //     sign_file = context.SignerFiles.FirstOrDefault(o => o.RequestId == sign_qr.RequestId);
            //     sign_request = context.SignerRequests.FirstOrDefault(o => o.Id == sign_qr.RequestId);
            // }

            // using (var client = new WebClient())
            // {
            //     client.DownloadFile(sign_request.PdfCertified, "wwwroot/pdf/" + sign_file.Filename);
            // }

            var urlfile = "../pdf/" + filename;
            ViewBag.urlfile = urlfile;
            //ViewBag.docname = sign_file.Name;

            return View();
        }

        [Route("checker/get-captcha-image")]
        public IActionResult GetCaptchaImage()
        {
            int width = 100;
            int height = 36;
            var captchaCode = Captcha.GenerateCaptchaCode();
            var result = Captcha.GenerateCaptchaImage(width, height, captchaCode);
            HttpContext.Session.SetString("CaptchaCode", result.CaptchaCode);
            Stream s = new MemoryStream(result.CaptchaByteData);
            return new FileStreamResult(s, "image/png");
        }

        [Route("/captcha-auth")]
        public IActionResult CaptchaAuth()
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
    }
}
