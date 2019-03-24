﻿//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Http;
//using NewInstagramApp.Models;
//using System.IO;
//using Microsoft.AspNetCore.Hosting;

//namespace NewInstagramApp.Controllers
//{
//    public class FileController : Controller
//    {
//        NewInstagramAppContext _context;
//        IHostingEnvironment _appEnvironment;

//        public FileController(NewInstagramAppContext context, IHostingEnvironment appEnvironment)
//        {
//            _context = context;
//            _appEnvironment = appEnvironment;
//        }

//        public IActionResult Index()
//        {
//            return View(_context.Files.ToList());
//        }
//        [HttpPost]
//        public async Task<IActionResult> AddFile(IFormFile uploadedFile)
//        {
//            if (uploadedFile != null)
//            {
//                // путь к папке Files
//                string path = "/Files/" + uploadedFile.FileName;
//                // сохраняем файл в папку Files в каталоге wwwroot
//                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
//                {
//                    await uploadedFile.CopyToAsync(fileStream);
//                }
//                FileModel file = new FileModel { Name = uploadedFile.FileName, Path = path };
//                _context.Files.Add(file);
//                _context.SaveChanges();
//            }

//            return RedirectToAction("Index");
//        }

//    }
//}
