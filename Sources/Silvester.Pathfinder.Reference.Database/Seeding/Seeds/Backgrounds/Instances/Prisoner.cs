using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

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

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("746b0b2f-7550-47e5-a1cb-00069d1bfc7e"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("c5d00b85-be1a-4d67-8622-54397ccfca97"), StatId = Stats.Instances.Strength.ID },
                    new StatEffectBinding{Id = Guid.Parse("3f3ea920-5acf-4b00-a230-0bbbf3736c9f"), StatId = Stats.Instances.Constitution.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("3fa809a3-0141-4039-9f81-4950e8b6af50")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("2dee64e4-421c-47dd-bebf-6562c7dde66b"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Stealth.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("5aed41c7-a40e-4b1c-aafc-e025dea53158"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Underworld.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("68761e25-33bf-41f6-8b6d-f1650216a5dd"),
                FeatId = Feats.General.ExperiencedSmugglerFeat.ID
            };
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
