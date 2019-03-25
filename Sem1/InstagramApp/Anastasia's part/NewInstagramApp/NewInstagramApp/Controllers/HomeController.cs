using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewInstagramApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace NewInstagramApp.Controllers
{
    public class HomeController : Controller
    {
        NewInstagramAppContext _context;
        IHostingEnvironment _appEnvironment;

        public HomeController(NewInstagramAppContext context, IHostingEnvironment appEnvironment)
        {
            _context = context;
            _appEnvironment = appEnvironment;
        }

        public IActionResult Photo()
        {
            return View(_context.FileModels.ToList());
        }
        [HttpPost]
        public async Task<IActionResult> AddFile(IFormFile uploadedFile)
        {
            if (uploadedFile != null)
            {
                // путь к папке Files
                string path1 = "/Files/" + uploadedFile.FileName;
                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path1, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }
                FileModel file = new FileModel { Name = uploadedFile.FileName, Path = path1 };
                _context.FileModels.Add(file);
                _context.SaveChanges();
            }

            return RedirectToAction("Photo");
        }
        [Authorize]
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
