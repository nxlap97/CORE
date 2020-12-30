using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CORE.Domain.Enums;
using CORE.Domain.Models;
using CORE.Service.IF;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CORE.Website.Areas.Admin.Controllers
{
    public class MediaController : AdminController
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IMDocumentService _documentService;

        public MediaController(IWebHostEnvironment hostingEnvironment, IMDocumentService documentService)
        {
            _hostingEnvironment = hostingEnvironment;
            _documentService = documentService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UploadDocument()
        {
            var file = Request.Form.Files[0];

            string wwwRootPath = _hostingEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(file.FileName);
            string extension = Path.GetExtension(file.FileName);
            var pathRoot = "/Upload/Images/";
            var id = Guid.NewGuid().ToString();
            var fileNameFull = id + extension;

            string path = Path.Combine(wwwRootPath + pathRoot, fileNameFull);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }

            var document = new MDocument()
            {
                Id = id,
                Size = file.Length,
                Extension = extension,
                Type = DocumentType.Image,
                FileName = fileNameFull,
                FileNameDefault = fileName + extension,
                FileUrl = pathRoot + fileNameFull,
                Published = true,
            };
            _documentService.Add(document);

           

            return Json(new { status = true, message = "upload image thành công", data = JsonConvert.SerializeObject(document) });
        }
    }
}
