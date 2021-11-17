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
    public class Detective : Template
    {
        public static readonly Guid ID = Guid.Parse("6c77edee-5e29-4e2d-9161-e63b0d77190e");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Detective",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d4c237dc-fd12-40ca-86d3-933c511cbf1e"), Type = TextBlockType.Text, Text = "You solved crimes as a police inspector or took jobs for wealthy clients as a private investigator. You might have become an adventurer as part of your next big mystery, but likely it was due to the consequences or aftermath of a prior case." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("ab1e72f3-4044-443d-b55f-2a2ffd71d2ff"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("38f7d23f-ad78-4aa0-a313-ac63ad3f362c"), Stats.Instances.Intelligence.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("c93311f2-0c9a-443c-8a7a-ec54921a51b1"), Stats.Instances.Wisdom.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("91b854ed-adf7-47db-8e9c-63c5c83228c0"));
            builder.GainSpecificSkillProficiency(Guid.Parse("d1862335-8ec0-4036-abec-c2aadfbad965"), Proficiencies.Instances.Trained.ID, Skills.Instances.Society.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("7db9a172-37a5-4023-bbeb-b868ef32af4f"), Proficiencies.Instances.Trained.ID, Lores.Instances.Underworld.ID);
            builder.GainSpecificFeat(Guid.Parse("985e039a-8765-4972-851e-bbc2363e3841"), Feats.Instances.Streetwise.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("be0183a3-7eaf-416a-9c1e-3e7a65573d1c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 61
            };
        }
    }
}
