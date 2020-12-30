using CORE.Domain.Entity;
using CORE.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CORE.Domain.Models
{
    [Table("Categories")]
    public class Category : ParentEntity<string>
    {
        [Required]
        [StringLength(250)]
        public string Name { get; set; }
        public string Alias { get; set; }
        public string ParentId { get; set; }

        public string IConCss { get; set; }
        public CategoryType Type { get; set; }
        public string Url { get; set; }
        public int DisplayOrder { get; set; }
        public bool ShowAtHome { get; set; }
        public bool IsPageUrl { get; set; }

    }
}
