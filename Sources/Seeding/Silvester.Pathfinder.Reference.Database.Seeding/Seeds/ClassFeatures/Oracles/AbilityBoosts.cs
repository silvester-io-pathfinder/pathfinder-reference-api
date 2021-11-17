using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Oracles
{
    public class AbilityBoosts : Template
    {
        public static readonly Guid ID = Guid.Parse("c9df159c-3b48-46af-aa37-b3611d7bc474");

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
            yield return new TextBlock { Id = Guid.Parse("11159338-9040-4978-970a-dcf080b21ab1"), Type = TextBlockType.Text, Text = "At 5th level and every 5 levels thereafter, you boost four different ability scores. You can use these ability boosts to increase your ability scores above 18. Boosting an ability score increases it by 1 if it's already 18 or above, or by 2 if it starts out below 18." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAbilityBoost(Guid.Parse("cc73d9ad-bd03-4a6f-9a05-071ca9216401"), Guid.Parse("dc937b44-a51b-4638-8ff9-aac45add9cc2"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("6bab67a8-8c20-4909-9058-c95cc02e5f1f"), Guid.Parse("fec15df7-ee71-40e5-bbde-3461c22c3258"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("719ef815-2e32-4efc-b9fa-458ff7a1e645"), Guid.Parse("84f96520-b072-41b3-b5d9-2749a6d98ebf"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("13d5deca-cfb3-484a-bbba-afc6828ede50"), Guid.Parse("54d2e809-9b6c-4a7a-afe2-4652a12b55b3"), requiredLevel: 5);

            builder.GainAnyAbilityBoost(Guid.Parse("44d253e1-6fde-4736-a307-084459eeb180"), Guid.Parse("99bcc676-677c-441e-8df0-ff4323206d53"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("f5745d1b-225b-469a-82b5-8b9900f95c09"), Guid.Parse("a7e98d5d-94ec-439a-a928-dd81442680a0"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("d7e93716-b6d1-4255-9c8e-da6fcb445322"), Guid.Parse("831a8de5-7082-400e-95e7-4e54391ba425"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("220a453f-698f-44dc-a5db-25bcde3957b9"), Guid.Parse("107ea5b5-1d76-44fe-809f-015cc2fcc49a"), requiredLevel: 10);

            builder.GainAnyAbilityBoost(Guid.Parse("f5ad1379-3a76-498b-bb3a-df9b1615636f"), Guid.Parse("6898c569-b2e9-4214-bdf8-edca524baa08"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("dc46e6bb-2082-4bfa-9fae-92cd6fc9f917"), Guid.Parse("43bc4ea5-a851-4320-8c1b-e5982c33ccac"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("8ca48dc5-089f-47b6-9d30-aa181a33523b"), Guid.Parse("76536de5-f6e0-4e24-8506-718840de8ca9"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("1d571f95-3281-4ca4-b44b-643407d45b8d"), Guid.Parse("8cffa50e-2155-4042-b31a-d66c439b66dc"), requiredLevel: 15);

            builder.GainAnyAbilityBoost(Guid.Parse("335a67e7-a752-4e5e-80fb-dd865c62ffb1"), Guid.Parse("de903052-29b8-4b0e-b73a-416366745868"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("11ff3ca8-feeb-4d14-9fa2-2ff4fe614e08"), Guid.Parse("5aa610fd-3ee7-4509-b1a9-7c0ff828f843"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("87fe9e37-441b-4af9-a095-4ea73e4de78d"), Guid.Parse("c7eadadb-472f-47f2-ba10-5ef62ff650e6"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("79159d4e-df53-4339-8179-d1ee196b1efe"), Guid.Parse("02fb4718-1e77-4d76-b4c9-e8b367dc5504"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9bca2e08-f6b2-4901-959d-b7241c71f92e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 71
            };
        }
    }
}
