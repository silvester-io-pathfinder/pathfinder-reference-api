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
            yield return new TextBlock { Id = Guid.Parse("8c95efe5-4c07-47c7-a9db-c8ff685e18dc"), Type = TextBlockType.Text, Text = "Your ancestors lived and worked among the great ancient stones of the mountains or the depths of the earth. This makes you solid as a rock when you plant your feet. You gain a +2 circumstance bonus to your Fortitude or Reflex DC against attempts to Shove or Trip you. This bonus also applies to saving throws against spells or effects that attempt to knock you prone." };
            yield return new TextBlock { Id = Guid.Parse("0aabd0fe-8aa2-4458-b7df-2a19b0b1620e"), Type = TextBlockType.Text, Text = "In addition, if any effect would force you to move 10 feet or more, you are moved only half the distance." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillActionSpecificSavingThrowCircumstanceBonus(Guid.Parse("432a4265-809f-47c3-a445-7bd1fde77727"), SavingThrowStats.Instances.Fortitude.ID, SkillActions.Instances.Shove.ID, bonus: 2, addendum: "This bonus also applies to Fortitude saving throws against spells or effects that attempt to knock you prone.");
            builder.GainSpecificSkillActionSpecificSavingThrowCircumstanceBonus(Guid.Parse("d5394a9a-7798-4f20-b439-a84ee8c8aec8"), SavingThrowStats.Instances.Fortitude.ID, SkillActions.Instances.Trip.ID, bonus: 2, addendum: "This bonus also applies to Fortitude saving throws against spells or effects that attempt to knock you prone.");
            builder.GainSpecificSkillActionSpecificSavingThrowCircumstanceBonus(Guid.Parse("c3487b1f-d385-447b-8cab-5ccdecdf64a1"), SavingThrowStats.Instances.Reflex.ID, SkillActions.Instances.Shove.ID, bonus: 2, addendum: "This bonus also applies to Reflex saving throws against spells or effects that attempt to knock you prone.");
            builder.GainSpecificSkillActionSpecificSavingThrowCircumstanceBonus(Guid.Parse("a9832010-f53c-4ee4-8296-f38e9699040b"), SavingThrowStats.Instances.Reflex.ID, SkillActions.Instances.Trip.ID, bonus: 2, addendum: "This bonus also applies to Reflex saving throws against spells or effects that attempt to knock you prone.");
            builder.Manual(Guid.Parse("b8087811-18b1-4b45-9927-d1550cec6d54"), "If any effect would force you to move 10 feet or more, you are moved only half the distance.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("41e3ce2d-64c3-40e1-b847-120b26325218"),
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
