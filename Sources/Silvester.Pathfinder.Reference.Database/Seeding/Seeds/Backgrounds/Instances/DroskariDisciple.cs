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
            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Constitution.ID);
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Intelligence.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse(""));
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.SkillTraining.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Lores.Instances.Droskar.ID);
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
