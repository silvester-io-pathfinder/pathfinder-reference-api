using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class IrongutGoblin : Template
    {
        public static readonly Guid ID = Guid.Parse("d1269abf-7396-4b72-8130-9a74f3253bfb");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Irongut Goblin"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("12f3e00d-9d67-4b1e-95e5-5b340e421f71"), Type = TextBlockType.Text, Text = "You can subsist on food that most folks would consider spoiled. You can keep yourself fed with poor meals in a settlement as long as garbage is readily available, without using the Subsist downtime activity. You can eat and drink things when you are sickened." };
            yield return new TextBlock { Id = Guid.Parse("f0b579f6-7522-4476-914f-86085958fa75"), Type = TextBlockType.Text, Text = "You gain a + 2 circumstance bonus to saving throws against afflictions, against gaining the sickened condition, and to remove the sickened condition. When you roll a success on a Fortitude save affected by this bonus, you get a critical success instead. All these benefits apply only when the affliction or condition resulted from something you ingested." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("b535aa9d-9f73-4ddb-8349-ecba317b1149"), "You can keep yourself fed with poor meals in a settlement as long as garbage is readily available, without using the Subsist downtime activity.");
            builder.Manual(Guid.Parse("7be1bbb9-0887-4769-8858-546d32b3030b"), "You can eat and drink things when you are sickened.");
            builder.GainSpecificTraitAnySavingThrowCircumstanceBonus(Guid.Parse("3864d510-ff99-425c-aad2-cc132247c8a5"), Traits.Instances.Disease.ID, bonus: 2, addendum: "Only applies to afflications caused by something you ingested.");
            builder.GainSpecificConditionAnySavingThrowCircumstanceBonus(Guid.Parse("e50c3693-6b9d-4453-a3fa-73731c763974"), Conditions.Instances.Sickened.ID, bonus: 2, addendum: "Only applies to afflications caused by something you ingested.");
            builder.ImproveSpecificTraitAnySavingThrow(Guid.Parse("97d28335-af39-4884-b5bf-ddf310de2526"), Traits.Instances.Disease.ID, RollResult.Success, becomes: RollResult.CriticalSuccess, addendum: "Only applies to afflications caused by something you ingested.");
            builder.ImproveSpecificConditionAnySavingThrow(Guid.Parse("2c456112-4e1f-4939-8cc8-da34945c89d1"), Conditions.Instances.Sickened.ID, RollResult.Success, becomes: RollResult.CriticalSuccess, addendum: "Only applies to afflications caused by something you ingested.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ce9fe27a-ff6e-41da-8a72-1b7f3ead8f4d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 47
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Goblin.ID;
        }
    }
}
