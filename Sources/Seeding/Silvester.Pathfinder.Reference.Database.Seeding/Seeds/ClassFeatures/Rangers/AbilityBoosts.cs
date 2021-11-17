using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Rangers
{
    public class AbilityBoosts : Template
    {
        public static readonly Guid ID = Guid.Parse("ddf21957-b0dd-4493-b1b8-8c9be31c37f5");

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
            yield return new TextBlock { Id = Guid.Parse("48508aab-592e-43d8-87a6-ace1c6d328cd"), Type = TextBlockType.Text, Text = "At 5th level and every 5 levels thereafter, you boost four different ability scores. You can use these ability boosts to increase your ability scores above 18. Boosting an ability score increases it by 1 if it's already 18 or above, or by 2 if it starts out below 18." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAbilityBoost(Guid.Parse("f3da0d8f-360b-4ccb-bea1-b78af436b246"), Guid.Parse("9395b6d3-04f1-4100-bddf-19f863ea3b46"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("49f63ba2-ad4a-49f5-8066-a8661a4f3c1b"), Guid.Parse("aafa5b7e-108e-49ae-af91-455e73c9a6ea"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("0e58db14-c28a-4e5c-a232-9817a9e10413"), Guid.Parse("3fbd9b59-e0aa-4b35-9076-9f1c5ba2c8c0"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("0582c1bb-1694-45b1-9df3-781c2e39242b"), Guid.Parse("7328ff6e-bd80-404c-8ed4-6b23ae9350e7"), requiredLevel: 5);

            builder.GainAnyAbilityBoost(Guid.Parse("ffc945c1-43a1-4254-be7d-2f77edea265c"), Guid.Parse("ea3881fb-8702-4f91-9c10-850f1e64f7d9"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("9eb9370e-eb2c-4879-a8a7-43c0a3b12713"), Guid.Parse("ce87f44f-8e83-448a-859e-8787a6f94ced"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("8b509cc3-57aa-4a76-b165-5dc714b68ab8"), Guid.Parse("4f85ab3c-be25-4cd8-8a32-bb65dbe3d4ef"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("5a0ed6a4-edd2-4bd2-b44e-aa654cb4a08b"), Guid.Parse("8f939a93-774e-494b-a014-efe031d5611e"), requiredLevel: 10);

            builder.GainAnyAbilityBoost(Guid.Parse("3b6d0dce-3f6a-4ea7-be33-0ddfe38dc90a"), Guid.Parse("6f61133e-02a2-4da0-8f30-21249556b44d"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("a9182d65-81f1-4d69-ad2b-0f025bd4de21"), Guid.Parse("9e6483c6-2b21-46fd-8765-e5a1e3e3a774"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("8929961d-71cc-4b0c-8daa-3ad2cc67b16f"), Guid.Parse("69c036d6-2b97-4107-930d-610e2eda44ae"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("054eafa3-ae9e-44e9-8ea1-9896e9744a38"), Guid.Parse("1f3e212b-85c4-443b-99f2-bc8d02f909a9"), requiredLevel: 15);

            builder.GainAnyAbilityBoost(Guid.Parse("c47f5a10-ef90-4359-a321-caa0af65cc01"), Guid.Parse("48c9cb7f-e934-4761-af5a-76178b32d145"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("4d0f1357-6af0-4c44-bcd5-88d58d47a867"), Guid.Parse("2fa60b22-eced-438e-b052-d8c382a78f91"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("3713c3de-6984-4f65-adcf-7a6e2344166b"), Guid.Parse("d51aec92-608d-40e6-9ee6-69607076bfb6"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("97b4c2b2-b938-454f-85bd-819b58b90775"), Guid.Parse("f7bff74a-e7cd-462c-9233-1c980c9b519f"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("36ba7073-624e-48db-89a0-302256522a6a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 169
            };
        }
    }
}
