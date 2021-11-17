using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Sorcerers
{
    public class AbilityBoosts : Template
    {
        public static readonly Guid ID = Guid.Parse("2f67a6c0-dadb-4135-bc22-4c2fb6b449c3");

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
            yield return new TextBlock { Id = Guid.Parse("f2189ca4-c0b8-4983-b473-9f9fbbd587cf"), Type = TextBlockType.Text, Text = "At 5th level and every 5 levels thereafter, you boost four different ability scores. You can use these ability boosts to increase your ability scores above 18. Boosting an ability score increases it by 1 if it's already 18 or above, or by 2 if it starts out below 18." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAbilityBoost(Guid.Parse("d952ae6a-aba6-436f-b6da-f5198aee778a"), Guid.Parse("db0cc920-c471-4030-b171-749069236902"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("e664cfb7-7d8d-46a0-ada0-0f821dea823c"), Guid.Parse("95f82f38-5357-4772-b0a8-7fa0397be174"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("fbd4d9e4-269b-497a-898b-e65560d10816"), Guid.Parse("274a1755-a1ae-425c-a00c-518e539f3810"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("4ffecf8c-13d1-4e33-bf27-6174a20eb35a"), Guid.Parse("17936d06-9413-4952-9064-06c84119e63a"), requiredLevel: 5);

            builder.GainAnyAbilityBoost(Guid.Parse("3892a1d0-2f37-42da-b661-d8435d7a82de"), Guid.Parse("f8af20fb-5f39-47a6-8572-60e3ac386b02"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("826a4e12-644d-4914-8965-e6b3d3a29bb3"), Guid.Parse("f6bd6e76-16b5-479f-aeae-d8f31cc2ed80"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("d03f6fdd-0829-4fb6-a6bd-6896ccb96ca6"), Guid.Parse("ae64dcc9-b201-40d9-93e0-aa96e86ed6a0"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("1c45d3fd-c03b-4298-bdfe-8f803ac8434e"), Guid.Parse("55cc7887-2462-4012-a086-30c6571cb6e2"), requiredLevel: 10);

            builder.GainAnyAbilityBoost(Guid.Parse("855651c3-adbe-43ba-be6a-91ff9d79e52e"), Guid.Parse("b591be40-3432-442d-9f35-b5a81ff5642b"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("bb407f65-531b-4235-938a-8431fe67c7fa"), Guid.Parse("4de05e34-5a5a-4cf2-b8f3-b324f6fedd0a"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("6d22474f-02db-49c0-9d6f-12b827511c96"), Guid.Parse("90119f97-30ae-4d05-8b2e-2f8d656db738"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("473cffea-889c-4557-95cd-2a6e52848c80"), Guid.Parse("5c71ec89-32ca-4c94-bcc7-e01292b550e6"), requiredLevel: 15);

            builder.GainAnyAbilityBoost(Guid.Parse("3dbafd2a-0a17-481f-b6e9-1c835d6ff5d1"), Guid.Parse("3cdba8ef-e0d1-4d22-84d0-3f1ae31f6a1f"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("e1ce5b20-9260-4fc0-bbf4-60e3f1eef65d"), Guid.Parse("c1e03e5a-10ef-4303-8dac-a516367c571c"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("efcee4e1-e206-4817-ba12-33c432a826db"), Guid.Parse("e9f1ccca-7241-4e84-b9e5-9fcc6e7d6e2c"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("ac5acaa5-a77a-442f-b551-75655216e691"), Guid.Parse("35348971-16e8-4776-b3da-bae40157ac69"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("65d313dc-a443-4478-a32b-fd8df654d87e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 194
            };
        }
    }
}
