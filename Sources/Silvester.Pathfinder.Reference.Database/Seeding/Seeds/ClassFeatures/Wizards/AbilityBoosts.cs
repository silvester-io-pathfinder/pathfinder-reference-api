using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Wizards
{
    public class AbilityBoosts : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 5,
                Name = "Ability Boosts", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "At 5th level and every 5 levels thereafter, you boost four different ability scores. You can use these ability boosts to increase your ability scores above 18. Boosting an ability score increases it by 1 if it's already 18 or above, or by 2 if it starts out below 18." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAbilityBoost(Guid.Parse(""), Guid.Parse(""), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse(""), Guid.Parse(""), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse(""), Guid.Parse(""), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse(""), Guid.Parse(""), requiredLevel: 5);

            builder.GainAnyAbilityBoost(Guid.Parse(""), Guid.Parse(""), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse(""), Guid.Parse(""), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse(""), Guid.Parse(""), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse(""), Guid.Parse(""), requiredLevel: 10);

            builder.GainAnyAbilityBoost(Guid.Parse(""), Guid.Parse(""), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse(""), Guid.Parse(""), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse(""), Guid.Parse(""), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse(""), Guid.Parse(""), requiredLevel: 15);

            builder.GainAnyAbilityBoost(Guid.Parse(""), Guid.Parse(""), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse(""), Guid.Parse(""), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse(""), Guid.Parse(""), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse(""), Guid.Parse(""), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 207
            };
        }
    }
}
