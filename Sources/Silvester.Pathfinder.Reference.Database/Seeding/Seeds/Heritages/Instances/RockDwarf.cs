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
    public class RockDwarf : Template
    {
        public static readonly Guid ID = Guid.Parse("b9e766b7-d4e6-4f93-bc21-8020c2cc09bc");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            {
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Rock Dwarf"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your ancestors lived and worked among the great ancient stones of the mountains or the depths of the earth. This makes you solid as a rock when you plant your feet. You gain a +2 circumstance bonus to your Fortitude or Reflex DC against attempts to Shove or Trip you. This bonus also applies to saving throws against spells or effects that attempt to knock you prone." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "In addition, if any effect would force you to move 10 feet or more, you are moved only half the distance." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillActionSpecificSavingThrowCircumstanceBonus(Guid.Parse(""), SavingThrowStats.Instances.Fortitude.ID, SkillActions.Instances.Shove.ID, bonus: 2, addendum: "This bonus also applies to Fortitude saving throws against spells or effects that attempt to knock you prone.");
            builder.GainSpecificSkillActionSpecificSavingThrowCircumstanceBonus(Guid.Parse(""), SavingThrowStats.Instances.Fortitude.ID, SkillActions.Instances.Trip.ID, bonus: 2, addendum: "This bonus also applies to Fortitude saving throws against spells or effects that attempt to knock you prone.");
            builder.GainSpecificSkillActionSpecificSavingThrowCircumstanceBonus(Guid.Parse(""), SavingThrowStats.Instances.Reflex.ID, SkillActions.Instances.Shove.ID, bonus: 2, addendum: "This bonus also applies to Reflex saving throws against spells or effects that attempt to knock you prone.");
            builder.GainSpecificSkillActionSpecificSavingThrowCircumstanceBonus(Guid.Parse(""), SavingThrowStats.Instances.Reflex.ID, SkillActions.Instances.Trip.ID, bonus: 2, addendum: "This bonus also applies to Reflex saving throws against spells or effects that attempt to knock you prone.");
            builder.Manual(Guid.Parse(""), "If any effect would force you to move 10 feet or more, you are moved only half the distance.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 36
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Dwarf.ID;
        }
    }
}
