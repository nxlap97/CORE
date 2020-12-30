using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.Service.Model
{
    public class SelectListItem
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public bool Selected { get; set; }

        public string OptionHTML { 
            get 
            {
                var selected = Selected ? "selected" : "";
                return $"<option value='{Value}' {selected}>{Text}</option>";
            }
        }
    }
}
