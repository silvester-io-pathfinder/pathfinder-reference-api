using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class TimeTraveler : Template
    {
        public static readonly Guid ID = Guid.Parse("0214d161-361e-456c-84dd-0a10ab1be7d2");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Time Traveler",
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("e579f108-7e23-447a-b127-6b5bf9c00b7b"), Type = TextBlockType.Text, Text = "You come from a different time. Whether by your own doing or a terrible accident, powerful magic has resulted in you coming to this time from the future or from the past, but you are unable to return. You might be from New Thassilon, an entire nation of time travelers." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Dexterity.ID);
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Intelligence.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse(""));
            builder.GainAnyLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, "The chosen Lore skill must be related to your own time.");
            builder.GainAnyLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, "The chosen Lore skill must be related to your own time.");
            builder.GainAnyLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, "The chosen Lore skill must be related to your own time.");
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.BendTime.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d408af42-4ba3-4a45-9ff4-db1b410c0da7"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 31
            };
        }
    }
}
