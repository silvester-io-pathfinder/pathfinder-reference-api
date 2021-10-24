
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites
{
    public class BasePrerequisite : BaseEntity
    {
        public Guid BindingId { get; set; }
        public BasePrerequisiteBinding Binding { get; set; } = default!;
    }
}
