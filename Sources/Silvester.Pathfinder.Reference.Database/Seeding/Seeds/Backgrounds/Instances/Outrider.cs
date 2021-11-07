using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Outrider : Template
    {
        public static readonly Guid ID = Guid.Parse("90fa7caa-4286-45c1-a0b9-85051d822db4");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Outrider",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("22221b84-11a4-4ee8-94ad-89db5d4f6c67"), Type = TextBlockType.Text, Text = "In your youth, you galloped on horseback over vast prairies, serving as a vanguard for your settlement, an army, or another group. Seeing so many different lands built a thirst in you to adventure and explore the world instead of just racing past it." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Constitution.ID);
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Wisdom.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse(""));
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Lores.Instances.Plains.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.ExpressRider.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("30c35551-92d1-4e41-961b-a3f424955e70"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 48
            };
        }
    }
}
