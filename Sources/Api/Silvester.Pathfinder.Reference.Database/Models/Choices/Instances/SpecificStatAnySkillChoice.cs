using Silvester.Pathfinder.Reference.Database.Models.Choices;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Reference.Database.Models.Choices.Instances
{
    public class SpecificStatAnySkillChoice : Choice
    {
        public Guid StatId { get; set; }
        public Stat Stat { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder ChooseSpecificStatAnySkill(this BooleanEffectBuilder builder, Guid id, Guid andId, Guid statId, Action<BooleanEffectBuilder> buildAction)
        {
            IList<ChoiceEffectBinding> entries = BooleanEffectBuilder
                .CreateAnd(andId, buildAction)
                .Build()
                .Entries
                .Select(e => new ChoiceEffectBinding { EffectId = e.EffectId, Effect = e.Effect })
                .ToList();

            return builder.GainChoice(id, new SpecificStatAnySkillChoice { Id = id, StatId = statId }, entries);
        }
    }
}
