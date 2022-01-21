using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Reference.Database.Models.Choices.Instances
{
    public class AnySkillChoice : Choice
    {

    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder ChooseAnySkill(this BooleanEffectBuilder builder, Guid id, Guid andId, Action<BooleanEffectBuilder> buildAction)
        {
            IList<ChoiceEffectBinding> entries = BooleanEffectBuilder
                .CreateAnd(andId, buildAction)
                .Build()
                .Entries
                .Select(e => new ChoiceEffectBinding { EffectId = e.EffectId, Effect = e.Effect })
                .ToList();

            return builder.GainChoice(id, new AnySkillChoice { Id = id }, entries);
        }
    }
}
