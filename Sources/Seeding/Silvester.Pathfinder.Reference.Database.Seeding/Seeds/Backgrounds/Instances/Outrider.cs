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
            builder.AddOr(Guid.Parse("9f1e9ba1-5f08-48f9-b976-8dd7606e9d04"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("6a66797d-3cbf-4d14-a8ce-8bca44d14240"), Stats.Instances.Constitution.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("f86feddf-012a-4791-b6be-7479f77d575e"), Stats.Instances.Wisdom.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("963e0608-cda4-4e6d-a986-903da86d6f6f"));
            builder.GainSpecificSkillProficiency(Guid.Parse("667f869a-fe96-45ab-a84c-8c5bd8425e80"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("98a21f79-7f78-4d8f-a254-3a33c52431b0"), Proficiencies.Instances.Trained.ID, Lores.Instances.Plains.ID);
            builder.GainSpecificFeat(Guid.Parse("dcb064d5-9723-4c39-8805-4ddf31706f1c"), Feats.Instances.ExpressRider.ID);
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
