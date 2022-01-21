using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Alchemists
{
    public class AbilityBoosts : Template
    {
        public static readonly Guid ID = Guid.Parse("994ed313-6c91-4720-ad4c-93b16ec41c0a");

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
            yield return new TextBlock { Id = Guid.Parse("ae1a4234-48e5-4c96-af96-70a6567ca09b"), Type = TextBlockType.Text, Text = "At 5th level and every 5 levels thereafter, you boost four different ability scores. You can use these ability boosts to increase your ability scores above 18. Boosting an ability score increases it by 1 if it's already 18 or above, or by 2 if it starts out below 18." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAbilityBoost(Guid.Parse("5b87389d-db6d-4d83-8c32-c8f77fd3d5b8"), Guid.Parse("2c2b03c8-cc17-478a-a315-38e578f13cbc"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("589ac568-5890-49bf-8bea-43500a27d7c7"), Guid.Parse("0c98e9a7-70c2-40ae-b851-f80fd5de1606"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("1259c542-9ec0-4bcd-ab25-024ba01b372e"), Guid.Parse("799a5b1a-7108-4772-9d4f-d7f5fa396e8f"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("deef0f72-4844-4585-b227-e8a367787465"), Guid.Parse("0c635892-6ee2-4265-8f96-05c2492175cc"), requiredLevel: 5);

            builder.GainAnyAbilityBoost(Guid.Parse("65e42f71-783a-4ac0-9b45-6651ca593fc8"), Guid.Parse("a6e1cdf6-e2bf-4618-89b1-0d87e907ae3e"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("84d09957-bd53-4763-8e62-d13379537d96"), Guid.Parse("5289d549-e9ef-4929-b48f-f3e7ba54e8d7"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("126141b9-926c-45a7-b070-5fc1318e2bb4"), Guid.Parse("40ae8fef-6630-4644-bfbe-805de253e6ad"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("797ee8e9-5655-43c5-af98-1183e4c6e0ef"), Guid.Parse("8a85783b-9e87-45fe-9daa-5fea50ecb951"), requiredLevel: 10);

            builder.GainAnyAbilityBoost(Guid.Parse("e163d556-2e3c-4870-b6c5-dd645c1e930e"), Guid.Parse("fdd7855b-a234-4d8b-930a-e761e25a092d"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("887789c9-b4d7-4622-99d1-768b6e0f39c2"), Guid.Parse("4f56c3ff-6e3d-4d52-bdf4-46b31df9a3a0"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("29469d9c-e6a2-4659-b2b8-5c07ccc38f58"), Guid.Parse("192723ef-f7a3-45ab-a271-3039ca711f6f"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("4d6a5bcb-b78d-454c-b3c2-cef7a3e8ee02"), Guid.Parse("2a3164c4-e389-4537-ba53-27c932afadc7"), requiredLevel: 15);

            builder.GainAnyAbilityBoost(Guid.Parse("bde2d88d-8684-4a50-af7f-6f1fc193f34a"), Guid.Parse("d242e6f6-d02a-4f42-ae2d-9d9cfcff359b"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("aec9ee3e-1a2a-493a-b456-d67f445f0022"), Guid.Parse("62c3ce67-653a-460a-aba8-1b0f18950ea2"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("59bce416-01ed-4b43-8d4e-36dec20d93a7"), Guid.Parse("7143d518-9c9d-4e39-b5f3-aaf74a48977d"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("1b88ba8a-8e01-4e87-84f8-8915f0b8390d"), Guid.Parse("cefc10d0-dd03-4b6f-9997-ed9c0bae0fbf"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d28b2cc9-f39e-47a1-b949-36f49e78c7bf"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 74
            };
        }
    }
}
