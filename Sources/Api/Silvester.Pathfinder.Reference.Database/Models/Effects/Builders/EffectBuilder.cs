using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Builders
{
    public class EffectBuilder
    {
        private BaseEffect Effect { get; }

        public EffectBuilder(BaseEffect effect)
        {
            Effect = effect;
        }

        public EffectBuilder Name(string name)
        {
            Effect.Name = name;
            return this;
        }

        public EffectBuilder AddPrerequisites(Guid id, Action<BooleanPrerequisiteBuilder> buildAction)
        {
            BooleanPrerequisiteBuilder builder = BooleanPrerequisiteBuilder.CreateAnd(id, buildAction);
            Effect.Prerequisite = builder.Build();

            return this;
        }

        public EffectBuilder AddIncrements(Action<EffectIncrementsBuilder> buildAction)
        {
            EffectIncrementsBuilder builder = new EffectIncrementsBuilder();
            buildAction.Invoke(builder);

            foreach (EffectIncrement increment in builder.Build())
            {
                Effect.Increments.Add(increment);
            }

            return this;
        }

        public BaseEffect Build()
        {
            return Effect;
        }
    }
}
