using CORE.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.Service.Model
{
    public class SettingModel
    {
        public string CODE { get; set; }

        public string HTMLContent { get; set; }
        public string FileId { get; set; }

        public bool Show { get; set; }

        public SettingType Type { get; set; }

        public string Id { get; set; }

        public string CreatedBy { get; set; }

        public string FileUrl { get; set; }

        public DateTime? CreatedDate { get; set; }
        public bool Published { get; set; }
    }
}
