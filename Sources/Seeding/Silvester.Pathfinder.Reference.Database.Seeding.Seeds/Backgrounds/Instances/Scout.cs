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
    public class Scout : Template
    {
        public static readonly Guid ID = Guid.Parse("a6116a94-0555-4882-969e-c7b245e2b6b3");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Scout",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7ea32318-8408-4144-95fd-8b852ad3d83b"), Type = TextBlockType.Text, Text = "You called the wilderness home as you found trails and guided travelers. Your wanderlust could have called you to the adventuring life, or perhaps you served as a scout for soldiers and found you liked battle." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("b88d29a2-bb7d-4d78-98a4-2cd82b59f8dd"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("50928a79-def0-4583-b914-c95a3c7b51a2"), Stats.Instances.Dexterity.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("17ba80a9-a4c8-4a6d-8853-e5e1bcc128b3"), Stats.Instances.Wisdom.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("1c569283-20b5-45de-992e-1eb79860b826"));
            builder.GainSpecificSkillProficiency(Guid.Parse("c7e2d17f-a7d1-4f38-8e71-2b28b72b641a"), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
            builder.GainSpecificLoreCategoryProficiency(Guid.Parse("02f13fb1-89d6-4961-880c-3023a3e7f91b"), Proficiencies.Instances.Trained.ID, LoreCategories.Instances.Terrains.ID, "The chosen Lore skill must relate to a terrain you scouted in (such as Forest Lore or Cavern Lore).");
            builder.GainSpecificFeat(Guid.Parse("b64a982e-c4a2-40f9-aed3-aad94c50575a"), Feats.Instances.Forager.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9cd0aeea-0c78-4124-b30b-eb06751d37b3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 64
            };
        }
    }
}
