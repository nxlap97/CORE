using CORE.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CORE.Domain.Models
{
    [Table("Blogs")]
    public class Blog : ParentEntity<string>
    {
        [StringLength(250)]
        [Required]
        public string Name { get; set; }

        public string Alias { get; set; }
        public string ImageId { get; set; }
        public int ViewCount { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }

        public int DisplayOrder { get; set; }
        public bool ShowAtHome { get; set; }
    }
}
