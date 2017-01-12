using System;
using System.ComponentModel.DataAnnotations;

namespace UniqueConstraint.Models
{
    public abstract class BaseModel
    {
        [Key]
        public Int32 Id
        {
            get;
            set;
        }
    }
}
