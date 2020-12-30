using CORE.Domain.Models;
using CORE.Service.IF;
using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.Service.Model.ModelMapping
{
    public static class PricingExtension
    {
        public static PricingModel ToViewModel(this Pricing entity, IPricingService pricingService, IMDocumentService documentService)
        {
            var img = new MDocument();
            if (!string.IsNullOrWhiteSpace(entity.ImageId))
                img = documentService.GetById(entity.ImageId);

            var modelVm = new PricingModel()
            {
                Id = entity.Id,
                CreatedBy = entity.CreatedBy,
                CreatedDate = entity.CreatedDate,
                Description = entity.Description,
                ViewCount = entity.ViewCount,
                ImageId = entity.ImageId,
                Name = entity.Name,
                Published = entity.Published,
                ShortDescription = entity.ShortDescription,
                ImageUrl = img?.FileUrl
            };
            return modelVm;
        }


        //create
        public static Pricing ToEntity(this PricingModel modelVm)
        {
            var entity = new Pricing()
            {
                Description = modelVm.Description,
                Name = modelVm.Name,
                Published = modelVm.Published,
                ShortDescription = modelVm.ShortDescription,
                ImageId = modelVm.ImageId,
                ViewCount = 0
            };
            return entity;
        }


        //update
        public static Pricing ToEntity(this PricingModel modelVm, Pricing entity)
        {
            entity.Id = modelVm.Id;
            entity.Description = modelVm.Description;
            entity.Name = modelVm.Name;
            entity.Published = modelVm.Published;
            entity.ShortDescription = modelVm.ShortDescription;
            entity.ImageId = modelVm.ImageId;
            return entity;
        }
    }
}
