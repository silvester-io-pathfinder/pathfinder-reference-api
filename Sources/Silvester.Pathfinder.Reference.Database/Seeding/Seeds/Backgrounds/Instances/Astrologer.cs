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
    public class Astrologer : Template
    {
        public static readonly Guid ID = Guid.Parse("17db4a2a-cd6c-4516-b39e-60fff10f5ba3");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Astrologer",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("b3b686ba-e30a-455e-9da1-089063bceb33"), Type = TextBlockType.Text, Text = "Astrologers look to the stars for signs and portents, using their positions to chart courses for those living beneath them. As the celestial spheres move, so does fate itself. You studied the stars and learned to divine your path based on their guidance. Whether the stars directly called you to a life of adventure or you use the stars to guide your wanderlust, you're living out the stars' guidance in a life of adventure." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Intelligence.ID);
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Wisdom.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse(""));
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Lores.Instances.Astrology.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.OddityIdentification.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dd0bebd6-de33-41b9-8f1f-ce9658340802"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 28
            };
        }
    }
}
