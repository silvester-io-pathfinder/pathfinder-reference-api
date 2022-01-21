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
    public class Hunter : Template
    {
        public static readonly Guid ID = Guid.Parse("430d7860-f18e-47da-b533-d8690ecff734");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Hunter",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("99a39f7d-b29a-4f2b-8aa1-1f6bb2414427"), Type = TextBlockType.Text, Text = "You stalked and took down animals and other creatures of the wild. Skinning animals, harvesting their flesh, and cooking them were also part of your training, all of which can give you useful resources while you adventure." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("3ae12110-18ff-45b1-83f0-1f8b7a74e6f9"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("3d295602-f210-437a-98d0-c1da7f6f5c39"), Stats.Instances.Dexterity.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("2e081442-69c1-4b87-bda3-7883bb51df56"), Stats.Instances.Wisdom.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("373d22bb-1bf1-4bd7-a6a9-c2d0077447b4"));
            builder.GainSpecificSkillProficiency(Guid.Parse("2b223ad7-b539-4da2-8005-934982e7950c"), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("28c567e1-9286-422d-99cd-2423825f16da"), Proficiencies.Instances.Trained.ID, Lores.Instances.Tanning.ID);
            builder.GainSpecificFeat(Guid.Parse("c5b785d7-7159-46b1-bcfc-cecddf755a3f"), Feats.Instances.SurveyWildlife.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1b8ebfd7-e85c-49bb-ae9d-82a0e2b8bd7a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 62
            };
        }
    }
}
