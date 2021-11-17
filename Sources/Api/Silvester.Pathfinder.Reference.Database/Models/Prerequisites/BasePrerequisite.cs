
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites
{
    public abstract class BasePrerequisite : BaseEntity
    {
        public bool IsNegated { get; set; }
    }
}
