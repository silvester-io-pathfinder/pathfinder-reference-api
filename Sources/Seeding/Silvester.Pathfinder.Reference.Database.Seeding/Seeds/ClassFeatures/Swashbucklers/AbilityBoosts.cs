using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Swashbucklers
{
    public class AbilityBoosts : Template
    {
        public static readonly Guid ID = Guid.Parse("4fb8f627-bcde-4711-9fa0-0562caaaaf62");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 5,
                Name = "Ability Boosts", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ec51d19a-e5bf-4789-806d-50eea7dbcf52"), Type = TextBlockType.Text, Text = "At 5th level and every 5 levels thereafter, you boost four different ability scores. You can use these ability boosts to increase your ability scores above 18. Boosting an ability score increases it by 1 if it's already 18 or above, or by 2 if it starts out below 18." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAbilityBoost(Guid.Parse("86166068-9adb-4a63-b15e-9529a0e70810"), Guid.Parse("45923669-09e5-48ba-b411-7fb6a27583ef"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("99d888e4-d7a2-4db6-9649-af65a98b96a4"), Guid.Parse("a7c6538d-1671-44b2-9132-ad5b388c6fcc"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("ea3a0211-1cc6-46c8-83c3-6353e87fc7b6"), Guid.Parse("88e1ddbc-1566-4b13-8c29-ff9a31333df4"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("c5ecfa5c-ea0c-4ad7-8334-87c44aa2a670"), Guid.Parse("925aab9f-b79f-42c9-85c1-808e3c85c470"), requiredLevel: 5);

            builder.GainAnyAbilityBoost(Guid.Parse("722a5bb1-c497-4201-860d-e08481639c76"), Guid.Parse("81bf1bdd-57f6-4861-b972-c693b0a185d0"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("9cccd1b1-5ccb-46f9-85a4-5eaa9d80aaf8"), Guid.Parse("0b1d224f-2489-457f-8d62-7d54eef99500"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("629bf277-7fee-4c47-a7ce-279bdb6c1d05"), Guid.Parse("4f19c21c-c590-4fcd-9870-d5259bf0c346"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("ab6d03c9-0c6b-4cff-8d6d-750928aeff33"), Guid.Parse("c1727110-c1bb-4735-b0a2-4c6437ddea93"), requiredLevel: 10);

            builder.GainAnyAbilityBoost(Guid.Parse("615d0452-e464-49d2-ad95-c4a8c4577dd1"), Guid.Parse("bf5c740c-d905-4352-a80c-107f7350a73b"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("c1c49faf-6bef-4ed0-9a20-c52d06f29ef2"), Guid.Parse("02472438-97f7-45e4-80d9-add0e0c5cc5b"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("036372ce-5c7d-4b41-9336-f00a4e11b9b3"), Guid.Parse("c754b0a8-960e-46d5-ab55-22163ba6f7e6"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("184884b0-4b45-4876-8b17-9f6c8aaec783"), Guid.Parse("7cb35ff5-0707-4499-90ac-ca777952769f"), requiredLevel: 15);

            builder.GainAnyAbilityBoost(Guid.Parse("3e8824dc-1df0-40fe-9ada-7dc1cb9cf7b3"), Guid.Parse("3f25aafd-5c44-48f1-b25a-220822c70855"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("30974847-9beb-4fa7-a062-ce3a37f33dc7"), Guid.Parse("822f2812-10b7-4aa9-86a4-a0fde496f17c"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("3d4fe4a0-4d3b-43c1-a5df-a806ef7d83d0"), Guid.Parse("bc0a0cea-6f46-44db-9b26-5d202bb168c4"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("b79945bf-b9d9-42c2-a067-966edeadb06a"), Guid.Parse("9ab49e1f-b336-4932-9386-141947b35c0f"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2c1e2e80-a1ef-4752-908e-74c6a9df4ca1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 86
            };
        }
    }
}
