using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using NewInstagramApp.Models;
using System.IO;

namespace NewInstagramApp.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index() 
        {
            return View();
        }

        //    [HttpPost]
        //    public ActionResult Index(IEnumerable<HttpPostAttribute> fileUpload)
        //{
        //    foreach (var file in fileUpload)
        //    {
        //        if (file == null) continue;
        //        string path = AppDomain.CurrentDomain.BaseDirectory + "UploadedFiles/";
        //        string filename = path.Get
        //        if (filename != null) file.SaveAs(Path.Combine(path, filename));
        //    }
        //}

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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