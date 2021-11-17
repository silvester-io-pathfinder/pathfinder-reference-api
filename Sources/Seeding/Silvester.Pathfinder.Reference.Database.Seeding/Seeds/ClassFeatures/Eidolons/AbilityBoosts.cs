using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Eidolons
{
    public class AbilityBoosts : Template
    {
        public static readonly Guid ID = Guid.Parse("2fe5d809-f434-4525-8d5d-d04aa4cee4dd");

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
            yield return new TextBlock { Id = Guid.Parse("71cdf9c8-8705-4955-96dc-c4dbd5bdace4"), Type = TextBlockType.Text, Text = "At 5th level and every 5 levels thereafter, you boost four different ability scores. You can use these ability boosts to increase your ability scores above 18. Boosting an ability score increases it by 1 if the ability score is already 18 or above, or by 2 if it starts out below 18." };
            yield return new TextBlock { Id = Guid.Parse("adbbe15f-30c6-41b5-98c9-ca557502b511"), Type = TextBlockType.Text, Text = "Your eidolon also gets four ability boosts at these levels. The eidolon's ability boosts follow the same rules as yours." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAbilityBoost(Guid.Parse("0121ef7b-a9ce-405e-a745-c7bed82e2926"), Guid.Parse("e4ad9f4c-881b-4edf-9dae-b2951dbea3ea"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("bb0e55cf-f55f-412c-9f1a-fe7bab88416e"), Guid.Parse("1254b93f-158f-47aa-8af8-04d456e2c636"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("233e7469-3dca-48e9-bd23-61d0d05d1294"), Guid.Parse("d8bb302d-b992-4b94-b3d1-b41741130c68"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("be155667-c599-4746-b47d-1cab903e8685"), Guid.Parse("73565293-6570-4557-8b24-de5ad93b5370"), requiredLevel: 5);

            builder.GainAnyAbilityBoost(Guid.Parse("fd8ed216-2dad-4443-903f-30e0468ab963"), Guid.Parse("7b768228-dcd1-49a5-b065-a8d0a6b75cbf"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("d31c9a1a-3e7f-4fb7-a05c-30698a8dbd1f"), Guid.Parse("ce64f8a6-f252-42e8-9175-9a1409ee3ee7"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("60ca85a3-718e-4b44-8480-25aee65369d5"), Guid.Parse("7a2f1f23-7e3f-42b6-a8ea-c1c1ecd41a88"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("031b44a0-a1c9-4885-aac2-c640a4743369"), Guid.Parse("b754ef84-9b13-4814-afff-a7555a567583"), requiredLevel: 10);

            builder.GainAnyAbilityBoost(Guid.Parse("46f3dc74-a0ca-404c-825b-f7b12896c177"), Guid.Parse("99bfa102-ffc4-44fb-be91-0b4a83cfa532"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("dac5035f-95e1-49c1-9daf-1b7d885a1b93"), Guid.Parse("fb277a9f-a442-4409-be76-a13841b68c72"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("016c5464-4fd9-4645-b3b3-a4973f2d6a78"), Guid.Parse("c05b2560-02c2-4cc6-9f36-aec23e1dd7bd"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("0c7ad695-c038-4f36-88aa-8f8fedfe2508"), Guid.Parse("fdabd7ba-8afd-4c48-956f-5e9b4dcc039e"), requiredLevel: 15);

            builder.GainAnyAbilityBoost(Guid.Parse("4975c1e7-d9e4-45e6-a2e3-249bc256f0e5"), Guid.Parse("f29c6fee-2738-425d-8b2f-a3a948ecba9e"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("2175e47b-d531-4bc3-b4d0-1b2ce2136e1d"), Guid.Parse("49dd76b8-5bb3-43dc-90a7-a7a75a652b63"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("4f3b3fce-c93d-421f-8750-1637600f805a"), Guid.Parse("9423d495-7f6e-49c3-95f5-ac624fb4d680"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("fc4beda8-215e-4246-9ffa-1f87b95494c7"), Guid.Parse("50813a51-18ee-4fc7-83d7-5f4adb6d7536"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("67d64902-9065-430b-9a30-6c1c3af1eab6"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 56
            };
        }
    }
}
