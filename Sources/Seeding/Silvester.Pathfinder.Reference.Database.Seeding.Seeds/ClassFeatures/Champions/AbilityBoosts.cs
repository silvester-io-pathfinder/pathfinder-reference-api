using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Champions
{
    public class AbilityBoosts : Template
    {
        public static readonly Guid ID = Guid.Parse("d9557b70-a87b-4dbc-914f-d1f77eec4bfc");

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
            yield return new TextBlock { Id = Guid.Parse("d3ae7035-4843-4159-9b14-1729e2e6ff6c"), Type = TextBlockType.Text, Text = "At 5th level and every 5 levels thereafter, you boost four different ability scores. You can use these ability boosts to increase your ability scores above 18. Boosting an ability score increases it by 1 if it's already 18 or above, or by 2 if it starts out below 18." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAbilityBoost(Guid.Parse("93d907e9-a771-4092-ab19-56c261687640"), Guid.Parse("e97aa598-a23d-44f1-a02c-61cf5da6af8b"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("b1f864b0-6333-467a-992a-588a9382495a"), Guid.Parse("f51842b8-4ef1-4a8f-8dfc-b0ce9b1436d8"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("9f2e93b6-7429-40d0-93ff-652fdde6b784"), Guid.Parse("a13a0333-412a-423c-8f1a-72fd805b38c7"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("618c964d-b02e-43de-8dad-400c77e9cd72"), Guid.Parse("b0680314-5f18-47e7-8279-c126a6d76b1c"), requiredLevel: 5);

            builder.GainAnyAbilityBoost(Guid.Parse("80085127-c919-4068-b1e0-cd6581060c7f"), Guid.Parse("ef3fc71b-eed0-4aa9-8217-a3a587ba7295"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("dbdf1096-3a18-43bd-9b53-c7cc4c090e14"), Guid.Parse("c3d9140d-011a-4330-92e6-9d3d51f46f58"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("2b3ccb48-5585-4507-bd91-a306cf46f941"), Guid.Parse("f4003c47-df01-4727-adac-1ebd949ee31e"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("67051ee5-f18b-4091-b0ca-22533cdb45d7"), Guid.Parse("3c7ca086-6059-49ab-9465-a83433ac6293"), requiredLevel: 10);

            builder.GainAnyAbilityBoost(Guid.Parse("9108f7f2-6fe5-4167-a0d6-2d4244789d34"), Guid.Parse("abf42a0c-d4f9-4846-b924-1ea6e681a92d"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("af6fc390-7d41-4024-95a1-8b22a20a110c"), Guid.Parse("1bbee5ce-be46-4c95-8d28-fa040a6b58f0"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("7079423e-df13-45cb-a0c5-15d6a45aba63"), Guid.Parse("cc1276b1-9c87-40c9-87b1-a2999a69d2cf"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("0547223b-56b6-4ec7-a7e6-168c67e67a81"), Guid.Parse("ee334ff2-4421-4f10-8d33-944c46caf6b8"), requiredLevel: 15);

            builder.GainAnyAbilityBoost(Guid.Parse("d5d2c49e-6955-44b0-b4ba-195e7651ba1f"), Guid.Parse("ade1eb46-555f-4846-8f2f-ecf93a26b79c"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("854df521-57bd-4d48-9279-c51dadca3e31"), Guid.Parse("50e9d5b5-f114-4cae-b12f-6793fe35c050"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("d2ad7878-6e86-41dd-8ec3-95efb2c62c40"), Guid.Parse("8e7183f9-a44f-4720-85f2-7896d53ab8d9"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("9d9524ad-1d9f-43cb-8ef1-15a17a660664"), Guid.Parse("b334badb-0ce9-4966-bb7c-f7ead7bee7d9"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4f60fd65-ab05-436f-b3e9-e0c1e7d584ae"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 108
            };
        }
    }
}
