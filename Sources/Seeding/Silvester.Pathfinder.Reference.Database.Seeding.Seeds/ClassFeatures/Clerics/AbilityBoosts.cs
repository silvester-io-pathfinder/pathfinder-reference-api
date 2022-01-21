using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Clerics
{
    public class AbilityBoosts : Template
    {
        public static readonly Guid ID = Guid.Parse("0b4a57d2-2b3c-4673-be47-e74db6fdc74e");

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
            yield return new TextBlock { Id = Guid.Parse("a67371ca-adad-44c8-9e27-8747cdead7f4"), Type = TextBlockType.Text, Text = "At 5th level and every 5 levels thereafter, you boost four different ability scores. You can use these ability boosts to increase your ability scores above 18. Boosting an ability score increases it by 1 if it's already 18 or above, or by 2 if it starts out below 18." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAbilityBoost(Guid.Parse("064becbd-0245-4f0e-b677-7fdba25a09b5"), Guid.Parse("8fdfc529-1e42-4648-a17a-c1fe61b38232"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("be9aceb2-74d9-4548-bb4d-9edf7d660ebd"), Guid.Parse("8db24120-6fc4-4127-bd71-7689b7e6880f"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("ea7b4dd8-92af-48a7-b870-8c5d4183a746"), Guid.Parse("22f0c2d8-2b9b-4281-ae96-9c81ea639663"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("d7865b87-7a3f-4401-89ed-9db2d3de4e09"), Guid.Parse("9da9c5dd-14d5-4e61-940e-e475bc6be274"), requiredLevel: 5);

            builder.GainAnyAbilityBoost(Guid.Parse("32e86736-f054-4b40-b25f-968944370da4"), Guid.Parse("bdc66fd6-eee7-4d7f-9be9-fb930c709f5b"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("59c6640d-a0c2-4e3e-959e-f349739acc22"), Guid.Parse("45978a77-0c97-4b57-9dde-fd657951d5ed"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("dbf7a14b-8968-4608-bfbb-d446c5b289b5"), Guid.Parse("61808732-8bd7-44f2-b3f0-753c3c1dd86d"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("193fb9fa-d0be-4ae0-985e-e5ea3dd51c96"), Guid.Parse("ea4bdf16-3fa0-46c8-83f4-2a457a419aa9"), requiredLevel: 10);

            builder.GainAnyAbilityBoost(Guid.Parse("4b8332e9-967d-4351-a237-5f6815c0d2e0"), Guid.Parse("34fa51b2-8435-4f32-8728-6c76ae4fb500"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("6c5ac379-770f-4717-886a-d0c02c00355f"), Guid.Parse("cbba4f18-9706-40fc-b12a-3e8332368bbb"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("b57f7090-2308-4fb6-97f7-3f8a25550693"), Guid.Parse("c75be55c-72ec-4b66-91b6-2ac4742aeb6e"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("0282c2b6-3c01-4b83-b172-be6c662ae60a"), Guid.Parse("bfaad2dc-094c-462a-9363-d22c10599502"), requiredLevel: 15);

            builder.GainAnyAbilityBoost(Guid.Parse("73bbb1fe-2f9e-494f-b34b-36a40f515018"), Guid.Parse("a6f0e036-5c20-48d8-931d-9bfa9f3b500c"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("84b9ce20-04f8-4c18-a71d-bbcdc0ce518f"), Guid.Parse("779402ea-6370-463a-8f9d-153fe2b713cc"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("90b12af7-f122-48f5-aa5c-4f2567d4f452"), Guid.Parse("cb533f6f-413f-4a12-a564-a366428477c3"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("83009732-ed44-4d5a-b8ce-46d3bfe928a2"), Guid.Parse("af8d1b1c-89fc-4d8e-aac2-db002bad2744"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9aeb0897-99aa-4e24-805a-a99001d4a5c9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 120
            };
        }
    }
}
