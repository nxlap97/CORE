using CORE.Domain.Models;
using CORE.Utility.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.Service.Model.ModelMapping
{
    public static class CategoryExtension
    {
        public static CategoryModel ToModel(this Category entity)
        {
            var modelVm = new CategoryModel()
            {
                Id = entity.Id,
                CreatedBy = entity.CreatedBy,
                CreatedDate = entity.CreatedDate,
                Name = entity.Name,
                ParentId = entity.ParentId,
                Published = entity.Published,
                Type = entity.Type,
                IConCss = entity.IConCss,
                Alias = entity.Alias,
                IsPageUrl = entity.IsPageUrl,
                ShowAtHome = entity.ShowAtHome,
                Url = entity.Url,
                DisplayOrder = entity.DisplayOrder
                
            };
            return modelVm;
        }

        //create
        public static Category ToEntity(this CategoryModel modelVm)
        {
            var entity = new Category()
            {
               Name = modelVm.Name,
               Published = modelVm.Published,
               ParentId = modelVm.ParentId,
               Type = modelVm.Type,
               DisplayOrder = modelVm.DisplayOrder,
               IConCss = modelVm.IConCss,
               Alias = modelVm.Name.ToUnsignString(),
               IsPageUrl = modelVm.IsPageUrl,
               ShowAtHome = modelVm.ShowAtHome,
               Url = modelVm.Url
            };
            return entity;
        }


        //update
        public static Category ToEntity(this CategoryModel modelVm, Category entity)
        {
            entity.Id = modelVm.Id;
            entity.Name = modelVm.Name;
            entity.Published = modelVm.Published;
            entity.Type = modelVm.Type;
            entity.ParentId = modelVm.ParentId;
            entity.DisplayOrder = modelVm.DisplayOrder;
            entity.IConCss = modelVm.IConCss;
            entity.Alias = modelVm.Name.ToUnsignString();
            entity.IsPageUrl = modelVm.IsPageUrl;
            entity.ShowAtHome = modelVm.ShowAtHome;
            entity.Url = modelVm.Url;
            return entity;
        }
    }
}
