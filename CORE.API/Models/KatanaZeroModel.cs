using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE.API.Models
{
    public class KatanaZeroModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string description { get; set; }
        public string Token_image { get; set; }
        public int Types { get; set; }
        public int Grade { get; set; }
        public string Grade_text { get; set; }
        public string Effect { get; set; }
        public int Power { get; set; }
    }
}
