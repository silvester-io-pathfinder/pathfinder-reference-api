using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding;
using Silvester.Pathfinder.Reference.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects
{
    public abstract class Effect : BaseEntity
    {
        public bool IsOptional { get; set; }

        public Guid BindingId { get; set; }
        public BaseEffectBinding Binding { get; set; } = default!;

        public ICollection<EffectIncrement> Increments { get; set; } = new List<EffectIncrement>();
        public ICollection<EffectPrerequisiteBinding> Prerequisites { get; set; } = new List<EffectPrerequisiteBinding>();
    }

    public enum ModifierType
    {
        Subtract,
        Add,
        Multiply,
        Divide
    }
}
