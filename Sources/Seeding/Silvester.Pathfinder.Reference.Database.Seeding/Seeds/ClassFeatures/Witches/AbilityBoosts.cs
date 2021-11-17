using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Witches
{
    public class AbilityBoosts : Template
    {
        public static readonly Guid ID = Guid.Parse("f1ad062f-def1-42bd-acca-a77b69fcb44a");

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
            yield return new TextBlock { Id = Guid.Parse("419da5d8-7cd7-42ef-90b4-b39378a7fd88"), Type = TextBlockType.Text, Text = "At 5th level and every 5 levels thereafter, you boost four different ability scores. You can use these ability boosts to increase your ability scores above 18. Boosting an ability score increases it by 1 if it's already 18 or above, or by 2 if it starts out below 18." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAbilityBoost(Guid.Parse("6a7d79ab-ab84-4a0d-94e9-01f83b067bc2"), Guid.Parse("bec030f6-a943-40ae-86c7-5757f677f190"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("011e4a43-b4f8-448b-bc49-e66f8f4da1e8"), Guid.Parse("11ad1d0e-bb2f-4b68-a46a-845104e5d919"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("6c6d2fc1-d359-4a49-b908-9dfb0b26d1c6"), Guid.Parse("680d07c0-934f-4d48-9bdb-cbb059f4c0c3"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("5594136c-43b9-47c9-a581-534ba87aef61"), Guid.Parse("bd2e7b5b-f15d-4282-9e01-579cc741582a"), requiredLevel: 5);

            builder.GainAnyAbilityBoost(Guid.Parse("73aad98c-7ea9-42d6-962b-dc8b14720369"), Guid.Parse("9f1091f6-dc7e-4bff-a3c3-485c3b52173c"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("76ffb7e1-e0e3-42aa-be74-35066ebe54be"), Guid.Parse("580bb477-991c-4c2c-9ba8-27180793b47a"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("ce29e1f3-c7a4-4d48-b380-960221bb8fd2"), Guid.Parse("cf895865-c765-4b27-87a8-22504b592a1c"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("1c2d213e-98b0-4208-990e-ed1b5b3f6aee"), Guid.Parse("cbf4fb15-594d-4c99-ac6e-2f2112f72bfb"), requiredLevel: 10);

            builder.GainAnyAbilityBoost(Guid.Parse("9fa53484-76dd-4cac-936b-296cb2ee35b2"), Guid.Parse("22f44f5c-c6da-4196-bfbb-fabd88ee06ec"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("66e341ef-bc6d-4b64-addb-639c9130ff41"), Guid.Parse("2723ae95-5761-4cba-aa88-9c34ac863c0d"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("b4ab82b7-a85b-4936-98a4-8c16614c3f7b"), Guid.Parse("d35b1657-d167-48a9-93ea-491e2baaf2d0"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("4149f8d6-4855-4de4-973d-206efa7985ed"), Guid.Parse("8d876ff8-553b-4080-b0e0-1b1c9893580b"), requiredLevel: 15);

            builder.GainAnyAbilityBoost(Guid.Parse("1c68ea67-a138-40eb-84d8-d477bce2c9f0"), Guid.Parse("513b5c4b-6153-4507-a09b-110d612b31d4"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("a2639e3a-734e-4854-b0ad-3f10d5bf1361"), Guid.Parse("1a28045d-003b-48d5-b0c4-393c7e1b89e9"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("ca8ed5cf-a7f8-4645-a2e6-914414f422a2"), Guid.Parse("f5308965-3500-46fc-a499-c4ee87bbf598"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("789e9b95-fd33-44c4-846b-bd24dde6b2c3"), Guid.Parse("b972f27d-f861-43bc-aea4-75fee7d67260"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("952510e2-f90e-4d1c-a1fe-96c053ffe636"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 98
            };
        }
    }
}
