using CORE.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CORE.Domain.Models
{
    [Table("Pricings")]
    public class Pricing : ParentEntity<string>
    {
        [StringLength(250)]
        [Required]
        public string Name { get; set; }
        public string ImageId { get; set; }
        public int ViewCount { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }

    }
}
