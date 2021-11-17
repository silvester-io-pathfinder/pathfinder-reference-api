using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Investigators
{
    public class AbilityBoosts : Template
    {
        public static readonly Guid ID = Guid.Parse("94cc18f5-8c5e-49a8-bb91-979bb1146323");

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
            yield return new TextBlock { Id = Guid.Parse("1def1e3a-1bbb-409f-8f5b-012448a79450"), Type = TextBlockType.Text, Text = "At 5th level and every 5 levels thereafter, you boost four different ability scores. You can use these ability boosts to increase your ability scores above 18. Boosting an ability score increases it by 1 if it's already 18 or above, or by 2 if it starts out below 18." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAbilityBoost(Guid.Parse("31cfd151-6444-43ef-8027-00dc398a0d15"), Guid.Parse("5c9dd07a-6206-40c3-80cd-4330b88f2476"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("5d67fd85-1a8f-4dee-b3b0-e8cf2aa12b86"), Guid.Parse("78ecbb89-93b7-4816-89b2-913447d48503"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("2fdfe544-3da6-4a7e-a85d-3e6ba99ebe91"), Guid.Parse("da0ecf97-6606-4fb3-aa91-3e5bcab4db06"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("a4b0f5ea-428f-46a4-9eb1-3ea16d93395c"), Guid.Parse("d58b9bb9-5e14-442c-a8a7-e4a567c170a3"), requiredLevel: 5);

            builder.GainAnyAbilityBoost(Guid.Parse("77744577-cb49-47fe-aabd-5cf3d4f95547"), Guid.Parse("187c60d4-ca34-440d-bf42-a975148ee165"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("7b3966c2-c432-4016-8931-8c5f9eaacedb"), Guid.Parse("f1b08a69-4b8f-4979-af3e-57c6274293ce"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("8e6beca9-efa5-42b4-b130-196ebc472f23"), Guid.Parse("e8203b70-ec75-4797-a5b6-d9c7e627958b"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("a92d7f34-6404-4d75-97ec-6e0f2237838e"), Guid.Parse("ff69c73b-6fa2-4d44-a47f-d74b43685ada"), requiredLevel: 10);

            builder.GainAnyAbilityBoost(Guid.Parse("4b716b59-92e2-4a62-b094-ebb208b0f7be"), Guid.Parse("f0d4f513-c056-4aaa-abac-6991475cea62"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("187a78b4-4f89-4062-90e3-01ff4b2fa59d"), Guid.Parse("ee7aeedb-a45e-4c84-b9df-7023bfb72a1e"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("0f3f1ce1-764a-48d9-906b-e0e5eb6bf9ab"), Guid.Parse("79998d0b-8c01-4fd7-a591-01e30e5955ce"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("4cebc879-0788-41e9-9bac-6220b39688b1"), Guid.Parse("619ca755-a1e8-4e21-becd-efcc93c02b6f"), requiredLevel: 15);

            builder.GainAnyAbilityBoost(Guid.Parse("b8bcaa97-f1dd-413f-9dae-c3fd7a511a28"), Guid.Parse("28fa38b9-4066-4003-9e98-3d033463c828"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("cbb9e787-95c8-4ca2-83d3-0cbab51d2b86"), Guid.Parse("d32dcf81-d3c6-4519-a26e-e62d52561c7c"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("7a33c247-815a-4979-b3c9-88ebf4ee560e"), Guid.Parse("4bfa5602-e465-4caf-9c86-a7eef20d0d3d"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("14546c95-cc55-4a61-b7b7-e78817b8ca07"), Guid.Parse("a0da5b18-7a4d-4bc6-a31e-3ad7ad565358"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7c2bdb96-57b8-4954-ae39-11761ff4dfde"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 59
            };
        }
    }
}
