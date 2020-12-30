using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CORE.Service.IF;
using CORE.Service.Model;
using CORE.Service.Model.ModelMapping;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CORE.Website.Areas.Admin.Controllers
{
    public class CategoryController : AdminController
    {
        private readonly IBlogService _blogService;
        private readonly ICategoryService _categoryService;
        private readonly IMDocumentService _documentService;
        public CategoryController(IBlogService blogService, ICategoryService categoryService, IMDocumentService documentService)
        {
            _blogService = blogService; _categoryService = categoryService; _documentService = documentService;
        }
        public IActionResult Index()
        {
            var categories = _categoryService.GetAll().Where(x=> !x.DeletedDate.HasValue).Select(x => x.ToModel()).ToList();

            return View(categories);
        }



        [HttpPost]
        public IActionResult AddOrUpdateCategory(string dataJson)
        {
            var dataObj = JsonConvert.DeserializeObject<CategoryModel>(dataJson);

            try
            {
                if (!string.IsNullOrWhiteSpace(dataObj.Id))
                {
                    var entity = _categoryService.GetById(dataObj.Id);
                    entity = dataObj.ToEntity(entity);
                    _categoryService.Update(entity);
                }
                else
                {
                    var entity = dataObj.ToEntity();
                    _categoryService.Add(entity);
                }
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    status = false,
                    message = ex.Message
                });
            }

            var categories = _categoryService.GetAll().Where(x => !x.DeletedDate.HasValue).Select(x => x.ToModel()).ToList();
            var resData = JsonConvert.SerializeObject(categories);

            return Json(new
            {
                status = true,
                message = "Lưu dữ liệu thành công",
                data = resData
            });
        }

        [HttpPost]
        public IActionResult Delete(string ids)
        {
            var lstId = JsonConvert.DeserializeObject<List<string>>(ids);
            foreach (var id in lstId)
            {
                _categoryService.Delete(id);
            }
            return Json(new { status = true, message = "Xóa dữ liệu thành công." });
        }
    }
}
