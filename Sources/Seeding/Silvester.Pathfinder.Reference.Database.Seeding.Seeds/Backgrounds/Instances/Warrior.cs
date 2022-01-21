using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Warrior : Template
    {
        public static readonly Guid ID = Guid.Parse("8db4cff6-1fe2-4152-800f-26bfb1596620");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Warrior",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("870c5ad8-f4a2-4762-a6a4-75507b21b614"), Type = TextBlockType.Text, Text = "In your younger days, you waded into battle as a mercenary, a warrior defending a nomadic people, or a member of a militia or army. You might have wanted to break out from the regimented structure of these forces, or you could have always been as independent a warrior as you are now." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("d2e891de-f822-4eaf-8900-47555bdfd433"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("51976af0-9fd6-4f11-918c-1b4940b39186"), Stats.Instances.Strength.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("a11cf16c-4f2a-4484-bc8c-1e467f88f17a"), Stats.Instances.Constitution.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("b4050890-9e63-4f88-b255-b66389e4761d"));
            builder.GainSpecificSkillProficiency(Guid.Parse("d083ab1b-8e8b-4f58-ac7c-a5a145f4bfaa"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("2c593457-c752-4053-ac61-90b870990e7f"), Proficiencies.Instances.Trained.ID, Lores.Instances.Warfare.ID);
            builder.GainSpecificFeat(Guid.Parse("d76ca337-24a8-4f12-b0e8-471e2377d917"), Feats.Instances.IntimidatingGlare.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c002d8dc-ca50-4bca-a303-854137d9ea1b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 64
            };
        }
    }
}
