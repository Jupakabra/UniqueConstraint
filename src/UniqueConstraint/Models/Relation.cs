using System;
using System.ComponentModel.DataAnnotations;

namespace UniqueConstraint.Models
{
    public class Relation : BaseModel
    {
        [Required]
        [StringLength(128)]
        public String Title { get; set; }
    }
}
