using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
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

    public interface IEffectCollection<TBinding>
        where TBinding : BaseEffectBinding, new()
    {
        ICollection<TBinding> Entries { get; set; }
    }

    public class EffectCollectionBuilder<TConcrete, TBinding>
        where TConcrete : Effect, IEffectCollection<TBinding>
        where TBinding : BaseEffectBinding, new()
    {
        private TConcrete Effect { get; }

        public EffectCollectionBuilder(TConcrete effect)
        {
            Effect = effect;
        }

        public EffectCollectionBuilder<TConcrete, TBinding> Add(Guid bindingId, Effect effect, Action<EffectBuilder>? configureAction)
        {
            EffectBuilder builder = new EffectBuilder(effect);
            configureAction?.Invoke(builder);
            Effect.Entries.Add(new TBinding { Id = bindingId, Effect = builder.Build() });
            return this;
        }

        public TConcrete Build()
        {
            return Effect;
        }
    }

    public class EffectBuilder
    {
        private Effect Effect { get; }

        public static EffectBuilder Collection<TConcrete, TBinding>(TConcrete concrete, Action<EffectCollectionBuilder<TConcrete, TBinding>> buildAction)
            where TConcrete : Effect, IEffectCollection<TBinding>
            where TBinding : BaseEffectBinding, new()
        {
            EffectCollectionBuilder<TConcrete, TBinding> builder = new EffectCollectionBuilder<TConcrete, TBinding>(concrete);
            buildAction.Invoke(builder);
            return new EffectBuilder(builder.Build());
        }

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
        LessThanOrEqualTo,
        LessThan,
        GreaterThan,
        EqualTo,
        NotEqualTo,
    }

    public enum RollType
    {
        Attack,
        SkillCheck,
        PerceptionCheck,
        SavingThrow,
        SpellAttack,
        SpellDc
    }

    public enum RangeTier
    {
        First,
        Second,
        Third
    }
}
