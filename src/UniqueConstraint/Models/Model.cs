using System;

namespace UniqueConstraint.Models
{
    public class Model : BaseModel
    {
        public Int32? RelationId { get; set; }
        public virtual Relation Relation { get; set; }
    }
}
