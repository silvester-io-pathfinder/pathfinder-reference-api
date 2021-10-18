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
        public string? Name { get; set; }
        public bool IsOptional { get; set; }

        public Guid BindingId { get; set; }
        public BaseEffectBinding Binding { get; set; } = default!;

        public ICollection<EffectIncrement> Increments { get; set; } = new List<EffectIncrement>();
        public ICollection<EffectPrerequisiteBinding> Prerequisites { get; set; } = new List<EffectPrerequisiteBinding>();
    }

    public class EffectBuilder
    {
        private Effect Effect { get; }

        public EffectBuilder(Effect effect)
        {
            Effect = effect;
        }
        
        public EffectBuilder AddPrerequisites(Action<Prerequisites> buildAction)
        {
            Prerequisites builder = new Prerequisites(this);
            buildAction.Invoke(builder);

            return this;
        }

        public Effect Build()
        {
            return Effect;
        }

        public class Prerequisites
        {
            private EffectBuilder EffectBuilder { get; }

            public Prerequisites(EffectBuilder effectBuilder)
            {
                EffectBuilder = effectBuilder;
            }

            public Prerequisites Add(Guid bindingId, Prerequisite prerequisite)
            {
                EffectBuilder.Effect.Prerequisites.Add(new EffectPrerequisiteBinding { Id = bindingId, Prerequisite = prerequisite });
                return this;
            }
        }
    }


    public enum ModifierType
    {
        Subtract,
        Add,
        Multiply,
        Divide
    }
    
    public enum RollResult
    {
        CriticalSuccess,
        Success,
        Failure,
        CriticalFailure
    }

    public enum Comparator
    {
        GreaterThanOrEqualTo,
        LessThanOrEqualTo
        LessThan,
        GreaterThan,
        EqualTo,
        NotEqualTo,
    }
}
