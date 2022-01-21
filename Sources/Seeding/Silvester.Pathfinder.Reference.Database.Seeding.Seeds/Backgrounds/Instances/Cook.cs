using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Cook : Template
    {
        public static readonly Guid ID = Guid.Parse("905c8239-ef8e-480b-b45e-e75222d2af6c");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Cook",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("177d5826-30a3-4617-8751-eef030328d5f"), Type = TextBlockType.Text, Text = "You grew up in the kitchens of a tavern or other dining establishment and excelled there, becoming an exceptional cook. Baking, cooking, a little brewing on the side'you've spent lots of time out of sight. It's about time you went out into the world to catch some sights for yourself." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("878a4a72-24c4-46df-b49e-bcdaea54f1d0"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("755c84b7-39d8-4253-9825-7e1eab03744a"), Stats.Instances.Constitution.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("5393a23f-b654-4321-b0e7-cb86d906f159"), Stats.Instances.Intelligence.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("8a12a11d-71b9-4508-9373-08b5091aa11e"));
            builder.GainSpecificSkillProficiency(Guid.Parse("2c4eca16-ac25-4a76-b8c4-c469cabf805f"), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("16feb875-88c2-4e35-a98a-8983fce60717"), Proficiencies.Instances.Trained.ID, Lores.Instances.Cooking.ID);
            builder.GainSpecificFeat(Guid.Parse("9fedc708-0020-4c10-965c-84fc413ef98b"), Feats.Instances.Seasoned.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("36aa989d-8094-4985-a688-250cf36bf70b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 48
            };
        }
    }
}
