using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Druids
{
    public class AbilityBoosts : Template
    {
        public static readonly Guid ID = Guid.Parse("c2147de7-1ad5-4fac-9d8b-3228a7744281");

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
            yield return new TextBlock { Id = Guid.Parse("212c0b59-e45c-4d1a-9529-83fa21039a68"), Type = TextBlockType.Text, Text = "At 5th level and every 5 levels thereafter, you boost four different ability scores. You can use these ability boosts to increase your ability scores above 18. Boosting an ability score increases it by 1 if it's already 18 or above, or by 2 if it starts out below 18." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAbilityBoost(Guid.Parse("7c12f5b4-9e3b-4e23-a688-22c6e689fea0"), Guid.Parse("d1d12fe4-f20e-47cb-b67e-4ee1d7d0106c"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("1ad48c46-118c-4b77-9c3a-576c5d824a58"), Guid.Parse("81d682dc-ca67-43fd-9837-ec5bca842f18"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("7f53d119-0302-41de-aa51-6ca183276445"), Guid.Parse("853d29e0-152a-4cbe-a2a0-a50e590dbf0d"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("e8865a1f-b51b-47f1-8569-f5a63ebdaf3d"), Guid.Parse("3e264b4b-22c8-4bf5-aa30-d62636580cff"), requiredLevel: 5);

            builder.GainAnyAbilityBoost(Guid.Parse("03280901-b6e7-4189-b59d-6357bea89357"), Guid.Parse("cd528285-4900-45fb-8b42-5d85041a330e"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("c51fb823-1d40-4741-8027-fd717905004e"), Guid.Parse("99e55d23-1e6a-4cfa-b231-848360b549c1"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("938e96fd-2142-44b1-a427-1ac9345405ce"), Guid.Parse("e6a6ee7b-04f7-4906-ab50-12adfc3ae719"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("ec365f59-db7f-4837-bbca-79b4991aec3b"), Guid.Parse("a0042fd6-5007-48f6-9f4d-e2cd5b33fc15"), requiredLevel: 10);

            builder.GainAnyAbilityBoost(Guid.Parse("e8223d59-b215-4330-aef1-ebba8d053a12"), Guid.Parse("5378d116-4c7f-42be-974d-1621579a943b"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("fd0c0c34-1502-4bac-b2b9-327737edd170"), Guid.Parse("831c21a3-0115-4c90-aeb7-8da81758affd"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("73b33e84-9a9b-4ad9-81f3-d2f797d8210a"), Guid.Parse("321683df-3aa5-4384-b572-f060baec2df4"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("6e949ee1-95f0-48bf-98ed-bb2f76630de5"), Guid.Parse("74d9760f-7739-4a31-9113-6f0f7882a4f3"), requiredLevel: 15);

            builder.GainAnyAbilityBoost(Guid.Parse("8abf767a-399a-4c4b-9b56-947bf9be3d9e"), Guid.Parse("f7437ebc-b304-4e69-a95e-3983daa7a5a1"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("ddad312d-a2b8-4f23-bff5-f22b16ee5e55"), Guid.Parse("85138852-e3fd-48dd-b710-078516d38133"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("73193105-a7c6-49d2-a20c-292fc9bafb84"), Guid.Parse("ecc52b12-6853-4ef4-9e57-fe4335048dcb"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("06d8c526-59ee-4fe0-a100-aa647931cab6"), Guid.Parse("915f2bc4-3956-4f4c-ab56-7da2b7365abf"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a047cd02-2c24-440f-86da-302da77afc4b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 133
            };
        }
    }
}
