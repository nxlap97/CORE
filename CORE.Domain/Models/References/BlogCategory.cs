using CORE.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CORE.Domain.Models
{
    [Table("BlogCategories")]
    public class BlogCategory : ParentEntity<string>
    {
        public string BlogId { get; set; }
        public string CategoryId { get; set; }
    }
}
