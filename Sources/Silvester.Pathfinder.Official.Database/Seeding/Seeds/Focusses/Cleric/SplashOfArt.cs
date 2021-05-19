using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Tables;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Focusses.Cleric.Instances
{
    public class SplashOfArt : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Focus GetFocus()
        {
            return new Focus
            {
                Id = ID,
                Name = "Splash of Art",
                Level = 1,
                Range = "30 feet.",
                Area = "5-foot burst.",
                Duration = "Varies.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                DomainId = Domains.Instances.Creation.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Cleric.ID,
                FocusTypeId = FocusTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "A deluge of colorful illusory paint, tools, or other symbols of art and artisanship drift down in the area. Roll 1d4 to determine the color of the illusion. Each creature in the area must attempt a Will save. A creature is unaffected on a success. On a failure or critical failure, the creature takes the results listed on the table relevant to the color." };
        }

        protected override Table? GetTable(TableBuilder builder)
        {
            builder
                .AddColumn("", "1d4")
                .AddColumn("", "Color")
                .AddColumn("", "Failure")
                .AddColumn("", "Critical Failure")
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "1")
                        .AddCell("", "White")
                        .AddCell("", "Dazzled 1 round.")
                        .AddCell("", "Dazzled 1 minute.");
                })
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "2")
                        .AddCell("", "Red")
                        .AddCell("", "Enfeebled 1 for 1 round.")
                        .AddCell("", "Enfeebled 2 for 1 round.");
                })
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "3")
                        .AddCell("", "Yellow")
                        .AddCell("", "Frightened 1.")
                        .AddCell("", "Frightened 2.");
                })
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "4")
                        .AddCell("", "Blue")
                        .AddCell("", "Clumsy 1 for 1 round.")
                        .AddCell("", "Clumsy 2 for 1 round.");
                });

            return builder.Build("");
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Visual.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 397
            };
        }
    }
}
