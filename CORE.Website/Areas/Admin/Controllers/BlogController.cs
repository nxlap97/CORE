using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CORE.Service.IF;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using CORE.Domain.Models;
using CORE.Service.Model;

namespace CORE.Website.Areas.Admin.Controllers
{
    public class BlogController : AdminController
    {
        private readonly IBlogService _blogService;
        private readonly ICategoryService _categoryService;
        private readonly IMDocumentService _documentService;
        public BlogController(IBlogService blogService, ICategoryService categoryService, IMDocumentService documentService)
        {
            _blogService = blogService; _categoryService = categoryService; _documentService = documentService;
        }
        public IActionResult Index()
        {
            var lst =  _blogService.GetAll().Where(x=> !x.DeletedDate.HasValue);
            var model = lst.Select(x => x.ToViewModel(_blogService, _categoryService, _documentService)).ToList();
            return View(model);
        }

        public IActionResult AddOrUpdate(string id)
        {
            var model = new BlogModel();
            model.Published = true;
            if (!string.IsNullOrWhiteSpace(id))
            {
                var entity = _blogService.GetById(id);
                 model = entity.ToViewModel(_blogService, _categoryService, _documentService);
            }
            else
            {
                model.Categories = _categoryService.GetAll().Select(x => new SelectListItem() { Text = x.Name, Value = x.Id }).ToList();
            }
           
            return View(model);
        }

        [HttpPost]
        public IActionResult AddOrUpdateBlog(string dataJson)
        {
            var dataObj = JsonConvert.DeserializeObject<BlogModel>(dataJson);
          
            try
            {
                if (!string.IsNullOrWhiteSpace(dataObj.Id))
                {
                    var entity = _blogService.GetById(dataObj.Id);
                    entity = dataObj.ToEntity(entity);
                    _blogService.Update(entity);
                    _blogService.UpdateToCategory(entity.Id, dataObj.CategoryId);
                 
                }
                else
                {
                    var entity = dataObj.ToEntity();
                    _blogService.Add(entity);
                    _blogService.AddToCategory(new BlogCategory() { BlogId = entity.Id, CategoryId = dataObj.CategoryId });
                }
            }
            catch(Exception ex)
            {
                return Json(new
                {
                    status = false,
                    message = ex.Message
                });
            }
           
            return Json(new { 
                status = true,
                message = "Lưu dữ liệu thành công"
            });
        }

        [HttpPost]
        public IActionResult Delete(string ids)
        {
            var lstId = JsonConvert.DeserializeObject<List<string>>(ids);
            foreach(var id in lstId)
            {
                _blogService.Delete(id);
            }
            return Json(new { status = true, message = "Xóa dữ liệu thành công." });
        }
    }
}
