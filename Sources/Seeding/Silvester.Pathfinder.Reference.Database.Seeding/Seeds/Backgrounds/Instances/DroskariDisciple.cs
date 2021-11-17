using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class DroskariDisciple : Template
    {
        public static readonly Guid ID = Guid.Parse("99c9ba97-c42f-478d-aee1-2dffd37194ed");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Droskari Disciple",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("058cc227-1a31-4500-825d-dcdb2079b171"), Type = TextBlockType.Text, Text = "You grew up in the church of the Dark Smith, where you learned the value of hard work and achieving vocational mastery." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("af5a4a41-c3c7-4ab8-ad11-c7cda5996d18"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("1d7d4ea7-837d-411a-9b61-9918720a2829"), Stats.Instances.Constitution.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("d5fd6084-8184-4dc2-bc03-5b9b038a7220"), Stats.Instances.Intelligence.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("e61ee37d-5f76-4eea-b00e-8875be29ce6e"));
            builder.GainSpecificFeat(Guid.Parse("656aef08-05bc-457f-88be-4abcde788c45"), Feats.Instances.SkillTraining.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("dcc50af3-2767-4367-b3a7-84e5f303ec1a"), Proficiencies.Instances.Trained.ID, Lores.Instances.Droskar.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f386e3dd-7014-4530-b0ac-225b3c2b2cad"),
                SourceId = Sources.Instances.Pathfinder148.ID,
                Page = 65
            };
        }
    }
}
