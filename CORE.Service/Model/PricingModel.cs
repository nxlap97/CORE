using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.Service.Model
{
    public class PricingModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ImageId { get; set; }
        public string ImageUrl { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public bool Published { get; set; }
        public int ViewCount { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
