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
        public static readonly Guid ID = Guid.Parse("");

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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your body is made from hardy roots that attach you firmly to the ground. You gain 10 Hit Points from your ancestry instead of 8. You can go without sunlight for 2 weeks before you begin to starve. You gain a +2 circumstance bonus to your Fortitude or Reflex DC against attempts to Shove or Trip you. This bonus also applies to saving throws against spells or effects that attempt to move you or knock you prone." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyAncestryHitpoints(Guid.Parse(""), ModifierType.Add, modifier: 2);
            builder.Manual(Guid.Parse(""), "You can go without sunlight for 2 weeks before you begin to starve. ");
            builder.GainSpecificSkillActionSpecificSavingThrowCircumstanceBonus(Guid.Parse(""), SavingThrowStats.Instances.Fortitude.ID, SkillActions.Instances.Shove.ID, bonus: 2, addendum: "This bonus also applies to saving throws against spells or effects that attempt to move you or knock you prone.");
            builder.GainSpecificSkillActionSpecificSavingThrowCircumstanceBonus(Guid.Parse(""), SavingThrowStats.Instances.Fortitude.ID, SkillActions.Instances.Trip.ID, bonus: 2, addendum: "This bonus also applies to saving throws against spells or effects that attempt to move you or knock you prone.");
            builder.GainSpecificSkillActionSpecificSavingThrowCircumstanceBonus(Guid.Parse(""), SavingThrowStats.Instances.Reflex.ID, SkillActions.Instances.Shove.ID, bonus: 2, addendum: "This bonus also applies to saving throws against spells or effects that attempt to move you or knock you prone.");
            builder.GainSpecificSkillActionSpecificSavingThrowCircumstanceBonus(Guid.Parse(""), SavingThrowStats.Instances.Reflex.ID, SkillActions.Instances.Trip.ID, bonus: 2, addendum: "This bonus also applies to saving throws against spells or effects that attempt to move you or knock you prone.");

        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
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
