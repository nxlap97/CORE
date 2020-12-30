using CORE.Domain.Entity;
using CORE.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CORE.Domain.Models
{
    [Table("Settings")]
    public class Setting : ParentEntity<string>
    {
        [StringLength(250)]
        [Required]
        public string CODE { get; set; }

        public string HTMLContent { get; set; }
        public string FileId { get; set; }

        public bool Show { get; set; }

        public SettingType Type { get; set; }
    }
}
