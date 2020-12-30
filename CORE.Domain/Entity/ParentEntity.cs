using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CORE.Domain.Entity
{
    public class ParentEntity<T>
    {
        public ParentEntity()
        {
            if (typeof(T) == typeof(string))
            {
                if (string.IsNullOrWhiteSpace(Id?.ToString()))
                {
                    Id = (T)(object)(Guid.NewGuid().ToString());
                }
            }

        }

        [Key]
        [Required]
        [MaxLength(128)]
        public T Id { get; set; }

        public string CreatedBy { get; set; }

        [StringLength(128)]
        public string UpdatedBy { get; set; }

        public string DeletedBy { get; set; }

        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool Published { get; set; }
    }
}
