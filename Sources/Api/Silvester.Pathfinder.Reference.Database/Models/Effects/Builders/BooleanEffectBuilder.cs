
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Builders
{
    public class BooleanEffectBuilder
    {
        private BooleanEffect BooleanEffect { get; }
        private IList<EffectBuilder> Entries { get; }

        public static implicit operator BaseEffect(BooleanEffectBuilder builder) => builder.Build();

        public static BooleanEffectBuilder CreateAnd(Guid id, Action<BooleanEffectBuilder>? buildAction = null)
        {
            BooleanEffectBuilder builder = new BooleanEffectBuilder(new BooleanEffect { Id = id, Operator = BooleanOperator.And });
            buildAction?.Invoke(builder);
            return builder;
        }

        public static BooleanEffectBuilder CreateOr(Guid id, Action<BooleanEffectBuilder>? buildAction = null)
        {
            BooleanEffectBuilder builder = new BooleanEffectBuilder(new BooleanEffect { Id = id, Operator = BooleanOperator.And });
            buildAction?.Invoke(builder);
            return builder;
        }

        public BooleanEffectBuilder(BooleanEffect booleanEffect)
        {
            BooleanEffect = booleanEffect;
            Entries = new List<EffectBuilder>();
        }

        public BooleanEffectBuilder Addendum(string addendum)
        {
            BooleanEffect.Addendum = addendum;
            return this;
        }

        public BooleanEffectBuilder Name(string name)
        {
            BooleanEffect.Name = name;
            return this;
        }

        public BooleanEffectBuilder AddAnd(Guid id, Action<BooleanEffectBuilder> buildAction)
        {
            return AddBoolean(CreateAnd(id), buildAction);
        }

        public BooleanEffectBuilder AddOr(Guid id, Action<BooleanEffectBuilder> buildAction)
        {
            return AddBoolean(CreateOr(id), buildAction);
        }

        public BooleanEffectBuilder AddDailyPreparation(Guid id, Action<BooleanEffectBuilder> buildAction)
        {
            BooleanEffectBuilder builder = new BooleanEffectBuilder(new BooleanEffect { Id = id, Operator = BooleanOperator.And });
            buildAction?.Invoke(builder);
            return builder;
        }

        private BooleanEffectBuilder AddBoolean(BooleanEffectBuilder subBuilder, Action<BooleanEffectBuilder> buildAction)
        {
            buildAction.Invoke(subBuilder);
            Add(subBuilder.Build());

            return this;
        }

        public EffectBuilder Add(BaseEffect effect)
        {
            EffectBuilder builder = new EffectBuilder(effect);
            Entries.Add(builder);
            return builder;
        }

        public BooleanEffectBuilder AddPrerequisites(Guid id, Action<BooleanPrerequisiteBuilder> buildAction)
        {
            BooleanPrerequisiteBuilder builder = BooleanPrerequisiteBuilder.CreateAnd(id, buildAction);
            BooleanEffect.Prerequisite = builder.Build();

            return this;
        }

        public BooleanEffect Build()
        {
            foreach (EffectBuilder entry in Entries)
            {
                BaseEffect effect = entry.Build();
                BooleanEffect.Entries.Add(new BooleanEffectBinding { Id = effect.Id, BooleanEffectId = BooleanEffect.Id, Effect = effect, EffectId = effect.Id });
            }

            return BooleanEffect;
        }
    }

    public static class SeedingExtensions
    {
        
    }
}
