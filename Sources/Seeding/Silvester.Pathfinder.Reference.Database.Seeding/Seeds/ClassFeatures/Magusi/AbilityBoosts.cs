using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Magusi
{
    public class AbilityBoosts : Template
    {
        public static readonly Guid ID = Guid.Parse("e65a7d5d-b8cd-4dc5-8db4-2a96fbb4d00e");

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
            yield return new TextBlock { Id = Guid.Parse("151f425e-481a-4638-8985-2a1653722d3a"), Type = TextBlockType.Text, Text = "At 5th level and every 5 levels thereafter, you boost four different ability scores. You can use these ability boosts to increase your ability scores above 18. Boosting an ability score increases it by 1 if it's already 18 or above, or by 2 if it starts out below 18." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAbilityBoost(Guid.Parse("281514ce-b7fb-4c54-a8ce-4acec0a4f0b7"), Guid.Parse("34a1fe26-f3f8-45dd-8d7c-a205c6e7566c"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("5aa0f446-8bfd-45d8-8f26-0063ff179263"), Guid.Parse("02696677-0742-4c5f-a269-efd5ba0d5e54"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("37313c9e-2b8c-41c8-8031-69a767488e80"), Guid.Parse("483ac38f-311e-4054-b6a2-9173cd158575"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("daf639f9-0bf4-4d3b-b112-ddb63c194b3b"), Guid.Parse("7cdae3d6-7182-4b49-bff8-f27f723435e0"), requiredLevel: 5);

            builder.GainAnyAbilityBoost(Guid.Parse("0c027232-820b-41dd-8485-780ce28d8da1"), Guid.Parse("1f53bc31-d5ca-4062-a168-e30f5d08322e"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("c46e834b-4ff8-4c4f-9edb-acea19223462"), Guid.Parse("86e9218c-3da9-421f-a43b-fd080dfdce05"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("73c1f131-3946-4001-9673-4d6c910e3e62"), Guid.Parse("e8937d2d-7892-4b4b-aba4-5c11e6725fe4"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("5e2573f4-d979-4bd2-91f9-ffb67ca2c738"), Guid.Parse("f718fc45-f4be-4aa0-b7ad-4e30ba15a650"), requiredLevel: 10);

            builder.GainAnyAbilityBoost(Guid.Parse("4f4fc781-eab0-408d-aff8-2141244479f8"), Guid.Parse("293e497e-3cab-4ada-a6a7-94a5dd5fd81e"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("3994d78c-9781-414d-a0d5-cee459fcf7b3"), Guid.Parse("d9a54703-4c98-4cfd-89fe-765771273daf"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("863cb256-be9d-4522-830b-a0d6ff3fea1b"), Guid.Parse("b223553e-e63a-44ec-b86a-ac39f9222a82"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("54ddca4c-e5a9-4821-892b-baeb17053e4b"), Guid.Parse("af8873b5-da38-4892-a76e-74caf6473ffd"), requiredLevel: 15);

            builder.GainAnyAbilityBoost(Guid.Parse("717f71b4-6673-46b2-aa9f-5520ccd37348"), Guid.Parse("6b561efa-b5a3-46c6-adbd-b1c153747da2"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("d504d587-84f5-446f-befd-c6a36aa993b0"), Guid.Parse("51cd9e10-4b3b-4f63-87b8-94e27fe8834b"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("a2a83fd0-fd1f-4680-9ff9-617028483238"), Guid.Parse("455bc41c-6f4f-4d58-bee2-51566593438b"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("e391b07a-4c3b-4591-b94a-144fb7c4c936"), Guid.Parse("802fa0e1-be2d-456b-8351-0ae8433a546a"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8cc2633e-28bb-47ab-8709-97195e8c8661"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 40
            };
        }
    }
}
