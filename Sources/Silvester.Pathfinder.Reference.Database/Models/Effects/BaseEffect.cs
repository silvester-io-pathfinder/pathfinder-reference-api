using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;

using Silvester.Pathfinder.Reference.Database.Seeding;
using Silvester.Pathfinder.Reference.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects
{
    public abstract class BaseEffect : BaseEntity
    {
        public string? Name { get; set; }
        public bool IsOptional { get; set; }

        public Guid? PrerequisiteId { get; set; }
        public BasePrerequisite? Prerequisite { get; set; }

        public ICollection<EffectIncrement> Increments { get; set; } = new List<EffectIncrement>();
    }
}
