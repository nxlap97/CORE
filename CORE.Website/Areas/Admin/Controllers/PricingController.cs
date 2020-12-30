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
    public class PricingController : AdminController
    {
        private readonly IPricingService _pricingService;
        private readonly IMDocumentService _documentService;
        public PricingController(IPricingService pricingService, IMDocumentService documentService)
        {
            _pricingService = pricingService; _documentService = documentService;
        }
        public IActionResult Index()
        {
            var lst = _pricingService.GetAll().Where(x => !x.DeletedDate.HasValue);
            var model = lst.Select(x => x.ToViewModel(_pricingService, _documentService)).ToList();
            return View(model);
        }

        public IActionResult AddOrUpdate(string id)
        {
            var model = new PricingModel();
            model.Published = true;
            if (!string.IsNullOrWhiteSpace(id))
            {
                var entity = _pricingService.GetById(id);
                model = entity.ToViewModel(_pricingService, _documentService);
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult AddOrUpdatePricing(string dataJson)
        {
            var dataObj = JsonConvert.DeserializeObject<PricingModel>(dataJson);

            try
            {
                if (!string.IsNullOrWhiteSpace(dataObj.Id))
                {
                    var entity = _pricingService.GetById(dataObj.Id);
                    entity = dataObj.ToEntity(entity);
                    _pricingService.Update(entity);

                }
                else
                {
                    var entity = dataObj.ToEntity();
                    _pricingService.Add(entity);
                  
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

            return Json(new
            {
                status = true,
                message = "Lưu dữ liệu thành công"
            });
        }

        [HttpPost]
        public IActionResult Delete(string ids)
        {
            var lstId = JsonConvert.DeserializeObject<List<string>>(ids);
            foreach (var id in lstId)
            {
                _pricingService.Delete(id);
            }
            return Json(new { status = true, message = "Xóa dữ liệu thành công." });
        }
    }
}
