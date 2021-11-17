using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Bards
{
    public class AbilityBoosts : Template
    {
        public static readonly Guid ID = Guid.Parse("57df94e1-45c0-4875-8179-364a313d24af");

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
            yield return new TextBlock { Id = Guid.Parse("7daea9ae-b65f-4bdb-8f4e-7db1659531aa"), Type = TextBlockType.Text, Text = "At 5th level and every 5 levels thereafter, you boost four different ability scores. You can use these ability boosts to increase your ability scores above 18. Boosting an ability score increases it by 1 if it's already 18 or above, or by 2 if it starts out below 18." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAbilityBoost(Guid.Parse("c9b21711-c7ef-4fa7-b472-a239b5603d77"), Guid.Parse("b8789b8a-aa10-484c-906f-555279235f0a"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("cd9e896c-15a5-4789-9b4b-a340896f61bd"), Guid.Parse("4b87dd30-4e77-449f-a13e-93475ba754bc"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("854d7d7f-2da3-473c-85ad-e4413ba08f04"), Guid.Parse("18dff7fe-0a96-4ec5-b249-47343c9feac2"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("ac909c47-09d9-4024-9db4-a098c2b1b6f2"), Guid.Parse("65c76f31-6eb7-4be7-bbbe-9f2c28727c9e"), requiredLevel: 5);

            builder.GainAnyAbilityBoost(Guid.Parse("251b5223-9f31-4e5a-8b97-4437480e680b"), Guid.Parse("781fbfe5-e238-4bda-b406-00069603613b"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("77c83861-4ce6-407e-a43b-7fce5c52e84d"), Guid.Parse("86b0accf-d527-48dd-8a42-b3c7f7c55e3e"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("6273cbb6-5aa2-420a-9b41-c0fb51c59529"), Guid.Parse("d8cfe74a-b52c-40c4-8abc-522497947677"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("ca3991d2-4219-4475-a712-ee8ad26989c4"), Guid.Parse("5130e8c5-e396-47f3-b9cc-9d93027679cb"), requiredLevel: 10);

            builder.GainAnyAbilityBoost(Guid.Parse("52ed68bc-4112-41c1-a4a5-9870a5f5e769"), Guid.Parse("381b599b-8037-4810-ab1f-b31fee0f2cfb"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("0b0eafe4-1d07-47e4-894a-2eed0593f4a9"), Guid.Parse("7d8ebd14-7c0b-4343-a30e-9abc3a45549d"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("a5943626-ec35-423d-981b-44a5cd06076d"), Guid.Parse("8929845a-cf09-4077-a686-901aa86a9041"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("6a7d8261-2277-4a21-ac16-b22b10990c35"), Guid.Parse("c4d2ee11-41bc-43ad-ae31-4d9497a72d0e"), requiredLevel: 15);

            builder.GainAnyAbilityBoost(Guid.Parse("eec529e1-4410-482b-ad82-932abaf5912c"), Guid.Parse("66ca5621-46dd-4626-83b5-d97a1ccc4552"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("9ab73c4e-180e-4d76-8f77-f06b7c91434b"), Guid.Parse("0e79dec7-9d38-45cf-8676-b432b6d50a37"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("52267399-a1d1-417f-ac79-49e2ae79482d"), Guid.Parse("bbe4c658-ebb4-488d-87b3-7f2e27f2a7fb"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("4b8ce88b-27c3-4f4c-b16a-3477872e0aab"), Guid.Parse("53d087b3-0338-4aa9-94d3-e6496341f9f5"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b8b137c8-6dcf-448e-8fed-48c742dafec0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 98
            };
        }
    }
}
