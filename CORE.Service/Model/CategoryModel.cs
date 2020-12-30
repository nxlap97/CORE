using CORE.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.Service.Model
{
    public class CategoryModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedDateStr
        {
            get
            {
                if (CreatedDate.HasValue)
                    return CreatedDate?.ToString("dd/MM/yyyy");
                return "";
            }
        }
        public string CreatedBy { get; set; }
        public bool Published { get; set; }
        public string ParentId { get; set; }
        public CategoryType Type { get; set; }
        public string Url { get; set; }
        public int DisplayOrder { get; set; }
        public bool ShowAtHome { get; set; }
        public bool IsPageUrl { get; set; }
        public string Alias { get; set; }

        public string IConCss { get; set; }
    }
}
