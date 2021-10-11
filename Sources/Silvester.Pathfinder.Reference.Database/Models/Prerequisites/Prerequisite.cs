using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites
{
    public class Prerequisite : BaseEntity
    {
        public Guid BindingId { get; set; }
        public BasePrerequisiteBinding Binding { get; set; } = default!;
    }

}
