using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Prisoner : Template
    {
        public static readonly Guid ID = Guid.Parse("360fa755-f23d-41bb-9e3c-2c0de114df6b");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Prisoner",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("a19b57a1-69a5-4d66-99de-1adf93eac862"), Type = TextBlockType.Text, Text = "You might have been imprisoned for crimes (whether you were guilty or not), or enslaved for some part of your upbringing. In your adventuring life, you take full advantage of your newfound freedom." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("8b7f7301-0964-454c-b35b-d0acf4bab6fe"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("dcdead6e-2b41-416f-9e1a-5cbb6bf5f8d1"), Stats.Instances.Strength.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("1c02f486-7830-4ed8-bb99-ffdd800ea024"), Stats.Instances.Constitution.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("3ddc29a2-a1a4-4124-b9a1-f4dc67da806c"));
            builder.GainSpecificSkillProficiency(Guid.Parse("327d7c34-51cf-44c2-a8b3-7f3da7808b0b"), Proficiencies.Instances.Trained.ID, Skills.Instances.Stealth.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("2cd6eda7-2ccf-4b02-a1a6-c475c222b13e"), Proficiencies.Instances.Trained.ID, Lores.Instances.Underworld.ID);
            builder.GainSpecificFeat(Guid.Parse("702b0b92-e191-418d-8e45-9f58f3d7272d"), Feats.Instances.ExperiencedSmuggler.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0f6c5963-e8cb-4d8e-8151-0c0d76ee0761"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 63
            };
        }
    }
}
