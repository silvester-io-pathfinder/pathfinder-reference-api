using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;

using Silvester.Pathfinder.Reference.Database.Seeding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

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
