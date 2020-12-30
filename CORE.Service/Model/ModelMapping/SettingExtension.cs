using CORE.Domain.Models;
using CORE.Service.IF;
using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.Service.Model.ModelMapping
{
    public static class SettingExtension
    {
        public static SettingModel ToModel(this Setting entity, IMDocumentService documentService)
        {
            var img = new MDocument();
            if (!string.IsNullOrWhiteSpace(entity.FileId))
                img = documentService.GetById(entity.FileId);

            var modelVm = new SettingModel()
            {
               Id = entity.Id,
               CODE = entity.CODE,
               CreatedBy = entity.CreatedBy,
               CreatedDate = entity.CreatedDate,
               FileId = entity.FileId,
               HTMLContent = entity.HTMLContent,
               Published = entity.Published,
                FileUrl = img?.FileUrl,
                Show = entity.Show,
                Type = entity.Type
            };
            return modelVm;
        }

        //create
        public static Setting ToEntity(this SettingModel modelVm)
        {
            var entity = new Setting()
            {
               CODE = modelVm.CODE,
               FileId  = modelVm.FileId,
               HTMLContent = modelVm.HTMLContent,
               Published = modelVm.Published,
               Show = modelVm.Show,
               Type = modelVm.Type,
               
            };
            return entity;
        }


        //update
        public static Setting ToEntity(this SettingModel modelVm, Setting entity)
        {
            entity.Id = modelVm.Id;
            entity.CODE = modelVm.CODE;
            entity.FileId = modelVm.FileId;
            entity.HTMLContent = modelVm.HTMLContent;
            entity.Published = modelVm.Published;
            entity.Show = modelVm.Show;
            entity.Type = modelVm.Type;

            return entity;
        }
    }
}
