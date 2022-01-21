using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects
{
    public abstract class BaseEffect : BaseEntity
    {
        public string? Name { get; set; }

        public Guid? PrerequisiteId { get; set; }
        public BooleanPrerequisite? Prerequisite { get; set; }

        public ICollection<EffectIncrement> Increments { get; set; } = new List<EffectIncrement>();
    }
}
