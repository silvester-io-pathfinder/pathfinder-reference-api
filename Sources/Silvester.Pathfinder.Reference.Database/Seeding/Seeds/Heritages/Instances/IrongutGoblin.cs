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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You can subsist on food that most folks would consider spoiled. You can keep yourself fed with poor meals in a settlement as long as garbage is readily available, without using the Subsist downtime activity. You can eat and drink things when you are sickened." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You gain a + 2 circumstance bonus to saving throws against afflictions, against gaining the sickened condition, and to remove the sickened condition. When you roll a success on a Fortitude save affected by this bonus, you get a critical success instead. All these benefits apply only when the affliction or condition resulted from something you ingested." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse(""), "You can keep yourself fed with poor meals in a settlement as long as garbage is readily available, without using the Subsist downtime activity.");
            builder.Manual(Guid.Parse(""), "You can eat and drink things when you are sickened.");
            builder.GainSpecificTraitAnySavingThrowCircumstanceBonus(Guid.Parse(""), Traits.Instances.Disease.ID, bonus: 2, addendum: "Only applies to afflications caused by something you ingested.");
            builder.GainSpecificConditionAnySavingThrowCircumstanceBonus(Guid.Parse(""), Conditions.Instances.Sickened.ID, bonus: 2, addendum: "Only applies to afflications caused by something you ingested.");
            builder.ImproveSpecificTraitAnySavingThrow(Guid.Parse(""), Traits.Instances.Disease.ID, RollResult.Success, becomes: RollResult.CriticalSuccess, addendum: "Only applies to afflications caused by something you ingested.");
            builder.ImproveSpecificConditionAnySavingThrow(Guid.Parse(""), Conditions.Instances.Sickened.ID, RollResult.Success, becomes: RollResult.CriticalSuccess, addendum: "Only applies to afflications caused by something you ingested.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
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
