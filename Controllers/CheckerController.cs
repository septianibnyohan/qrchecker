using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QRChecker.Models;

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

            SignerRequest sign_request;
            SignerFile sign_file;
            using (var context = new DigiSign2Context())
            {
                var sign_qr = context.SignerQrs.FirstOrDefault(o => o.Qrkey == qrkey);
                sign_file = context.SignerFiles.FirstOrDefault(o => o.RequestId == sign_qr.RequestId);
                sign_request = context.SignerRequests.FirstOrDefault(o => o.Id == sign_qr.RequestId);
            }

            var urlfile = sign_request.PdfCertified;
            ViewBag.urlfile = urlfile;
            ViewBag.docname = sign_file.Name;

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
