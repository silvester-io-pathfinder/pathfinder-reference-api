using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class StreetUrchin : Template
    {
        public static readonly Guid ID = Guid.Parse("09e50ee9-5dc2-4490-8b24-091cbd72294e");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Street Urchin",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("5650a0b0-969b-4f47-87e9-9fc0f26b4ee9"), Type = TextBlockType.Text, Text = "You eked out a living by picking pockets on the streets of a major city, never knowing where you'd find your next meal. While some folk adventure for the glory, you do so to survive." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("ede974d1-e4a4-4b36-ad0e-22c9118f4039"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("b1529e52-63a2-4d03-9282-5d6d504e6c66"), Stats.Instances.Dexterity.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("75bfb3be-4c66-4aaf-9dab-b263c2c074c3"), Stats.Instances.Constitution.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("fa6285bc-ac4d-45ad-b443-524b5f79e461"));
            builder.GainSpecificSkillProficiency(Guid.Parse("a31077ae-770f-456d-ac61-65448b5f51f9"), Proficiencies.Instances.Trained.ID, Skills.Instances.Thievery.ID);
            builder.GainSpecificLoreCategoryProficiency(Guid.Parse("5736bf85-23fb-4b96-a0d9-866299d7aadb"), Proficiencies.Instances.Trained.ID, LoreCategories.Instances.Settlements.ID, "The chosen Lore skill must be related to the settlement you lived in as a street urchin (such as Absalom Lore or Magnimar Lore).");
            builder.GainSpecificFeat(Guid.Parse("5915be3b-99a3-4cb4-a006-49444937a6cd"), Feats.Instances.Pickpocket.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("20e84e57-638d-4bad-b737-a17dad02695d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 64
            };
        }
    }
}
