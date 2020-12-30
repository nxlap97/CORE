using CORE.Domain.Models;
using CORE.Service.IF;
using CORE.Service.Model;
using CORE.Utility.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CORE.Service.Model
{
    public static class BlogExtension
    {
        public static BlogModel ToViewModel(this Blog entity, IBlogService blogService , ICategoryService categoryService, IMDocumentService documentService)
        {
            var img = new MDocument();
            if(!string.IsNullOrWhiteSpace(entity.ImageId))
                img = documentService.GetById(entity.ImageId);

            var categoryId = blogService.GetCategoryId(entity.Id);
            var category = categoryService.GetById(categoryId);

            var modelVm = new BlogModel()
            {
                Id = entity.Id,
                CategoryId = categoryId,
                CategoryName = category?.Name,
                CreatedBy = entity.CreatedBy,
                CreatedDate = entity.CreatedDate,
                Description = entity.Description,
                ViewCount = entity.ViewCount,
                ImageId = entity.ImageId,
                Name = entity.Name,
                Published = entity.Published,
                ShortDescription = entity.ShortDescription,
                ImageUrl = img?.FileUrl,
                Categories = categoryService.GetAll().Select(x=> new SelectListItem() { Selected = categoryId == x.Id , Text  = x.Name, Value = x.Id  }).ToList(),
                Alias = entity.Alias,
                DisplayOrder = entity.DisplayOrder,
                ShowAtHome = entity.ShowAtHome
                
            };
            return modelVm;
        }


        //create
        public static Blog ToEntity(this BlogModel modelVm)
        {
            var entity = new Blog()
            {
                Description = modelVm.Description,
                Name = modelVm.Name,
                Published = modelVm.Published,
                ShortDescription = modelVm.ShortDescription,
                ImageId = modelVm.ImageId,
                ViewCount = 0,
                ShowAtHome = modelVm.ShowAtHome,
                Alias = modelVm.Name.ToUnsignString(),
                DisplayOrder = modelVm.DisplayOrder 
            };
            return entity;
        }


        //update
        public static Blog ToEntity(this BlogModel modelVm, Blog entity)
        {
            entity.Id = modelVm.Id;
            entity.Description = modelVm.Description;
            entity.Name = modelVm.Name;
            entity.Published = modelVm.Published;
            entity.ShortDescription = modelVm.ShortDescription;
            entity.ImageId = modelVm.ImageId;
            entity.ShowAtHome = modelVm.ShowAtHome;
            entity.Alias = modelVm.Name.ToUnsignString();
            entity.DisplayOrder = modelVm.DisplayOrder;
            return entity;
        }
    }
}
