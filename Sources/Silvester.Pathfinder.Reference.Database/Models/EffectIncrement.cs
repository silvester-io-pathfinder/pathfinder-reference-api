using Silvester.Pathfinder.Reference.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Silvester.Pathfinder.Reference.Database.Models
{
    public abstract class EffectIncrement : BaseEntity
    {
        public int Level { get; set; }

        public Guid EffectId { get; set; }
        public Effect Effect { get; set; } = default!;
    }

    public class IncreaseProficiencyIncrement : EffectIncrement
    {
        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;
    }
}
