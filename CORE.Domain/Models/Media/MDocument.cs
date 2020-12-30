using CORE.Domain.Entity;
using CORE.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CORE.Domain.Models
{
    [Table("MDocuments")]
    public class MDocument : ParentEntity<string>
    {
        public string FileName { get; set; }

        public string FileUrl { get; set; }

        public long Size { get; set; }

        public string Extension { get; set; }
        public string FileNameDefault { get; set; }

        public DocumentType Type { get; set; }
    }
}
