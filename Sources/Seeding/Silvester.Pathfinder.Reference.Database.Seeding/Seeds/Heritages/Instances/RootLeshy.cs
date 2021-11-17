using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class RootLeshy : Template
    {
        public static readonly Guid ID = Guid.Parse("e38d11da-85c9-4f54-a831-9d0630f4da00");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Root Leshy"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ef130827-b9ad-4dc5-bca9-88f61cd9427a"), Type = TextBlockType.Text, Text = "Your body is made from hardy roots that attach you firmly to the ground. You gain 10 Hit Points from your ancestry instead of 8. You can go without sunlight for 2 weeks before you begin to starve. You gain a +2 circumstance bonus to your Fortitude or Reflex DC against attempts to Shove or Trip you. This bonus also applies to saving throws against spells or effects that attempt to move you or knock you prone." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyAncestryHitpoints(Guid.Parse("d079936c-bf91-443b-89d9-3adf431565f3"), ModifierType.Add, modifier: 2);
            builder.Manual(Guid.Parse("c31ce519-acc5-4735-a401-9efcf531c5e5"), "You can go without sunlight for 2 weeks before you begin to starve. ");
            builder.GainSpecificSkillActionSpecificSavingThrowCircumstanceBonus(Guid.Parse("c6964e6d-d3fb-4ec5-a26c-93552ff78b6f"), SavingThrowStats.Instances.Fortitude.ID, SkillActions.Instances.Shove.ID, bonus: 2, addendum: "This bonus also applies to saving throws against spells or effects that attempt to move you or knock you prone.");
            builder.GainSpecificSkillActionSpecificSavingThrowCircumstanceBonus(Guid.Parse("faf59931-acda-4e01-b7b5-555dc869a1e4"), SavingThrowStats.Instances.Fortitude.ID, SkillActions.Instances.Trip.ID, bonus: 2, addendum: "This bonus also applies to saving throws against spells or effects that attempt to move you or knock you prone.");
            builder.GainSpecificSkillActionSpecificSavingThrowCircumstanceBonus(Guid.Parse("ecb56c19-93cd-4967-b335-a462653b2e08"), SavingThrowStats.Instances.Reflex.ID, SkillActions.Instances.Shove.ID, bonus: 2, addendum: "This bonus also applies to saving throws against spells or effects that attempt to move you or knock you prone.");
            builder.GainSpecificSkillActionSpecificSavingThrowCircumstanceBonus(Guid.Parse("aaf104c0-130d-486b-b881-a18a74a0de5d"), SavingThrowStats.Instances.Reflex.ID, SkillActions.Instances.Trip.ID, bonus: 2, addendum: "This bonus also applies to saving throws against spells or effects that attempt to move you or knock you prone.");

        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("da081959-8f40-450f-8ca9-1a534d1d8cf4"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 42
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Leshy.ID;
        }
    }
}
