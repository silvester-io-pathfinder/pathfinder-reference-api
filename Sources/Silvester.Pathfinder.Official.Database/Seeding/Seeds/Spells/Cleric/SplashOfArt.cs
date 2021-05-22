using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Tables;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class SplashOfArt : Template
    {
        public static readonly Guid ID = Guid.Parse("ff4b0053-15f7-4b25-8795-43dbc59e15de");

        public override Spell GetSpell()
        {
            return new Spell
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
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3c18f999-1631-4ec7-bb23-9b48a1d7b66c"), Type = TextBlockType.Text, Text = "A deluge of colorful illusory paint, tools, or other symbols of art and artisanship drift down in the area. Roll 1d4 to determine the color of the illusion. Each creature in the area must attempt a Will save. A creature is unaffected on a success. On a failure or critical failure, the creature takes the results listed on the table relevant to the color." };
        }

        protected override Table? GetTable(TableBuilder builder)
        {
            builder
                .AddColumn("b9917bfa-96d3-48c5-bc12-fb530e73db87", "1d4")
                .AddColumn("e29d1ddf-cb8a-44f3-aa00-23c5d402493b", "Color")
                .AddColumn("cce1ea2f-a856-428e-8a4d-5aac108cd5cd", "Failure")
                .AddColumn("5e34d24f-b720-4c64-9126-be13552c2d1f", "Critical Failure")
                .AddRow("fcf31656-4f89-42da-bf9b-35f209fdeb5c", row =>
                {
                    row
                        .AddCell("f0840b48-88ba-44e2-8cde-fb9e2f6d697c", "1")
                        .AddCell("a0b9d7c1-832e-4c60-908a-50cec6807126", "White")
                        .AddCell("64d74f40-2eb3-471d-9187-01b10f3226c0", "Dazzled 1 round.")
                        .AddCell("8c9a6be8-4153-4682-8ecf-d437772333b0", "Dazzled 1 minute.");
                })
                .AddRow("43f1abd3-b59c-4fcb-a8f9-d25d67561301", row =>
                {
                    row
                        .AddCell("93781c76-8083-4c4e-a028-bd30f1c75d0a", "2")
                        .AddCell("485fd071-daa8-4ec3-83f0-96fa201ad0ac", "Red")
                        .AddCell("07b98d48-04f5-4328-a53e-87445f6bfcd5", "Enfeebled 1 for 1 round.")
                        .AddCell("84f6b213-8315-4f60-a941-15009d662b60", "Enfeebled 2 for 1 round.");
                })
                .AddRow("be37f12e-0f0e-468f-b954-a25ee89c5176", row =>
                {
                    row
                        .AddCell("d3cf00ac-078a-4d6a-8777-6c89229427aa", "3")
                        .AddCell("0f6c0a01-39af-4162-999c-421b3ed3083b", "Yellow")
                        .AddCell("69ba681d-f286-448e-8f49-eeede6ac8061", "Frightened 1.")
                        .AddCell("7a005aaa-c00c-4c68-9c65-b41140dbe588", "Frightened 2.");
                })
                .AddRow("044f0a18-cc33-4c05-9f2e-cc411fe89279", row =>
                {
                    row
                        .AddCell("63a29908-5408-457f-b128-c2e164b1ea58", "4")
                        .AddCell("7f9acb9d-5e79-454f-a1d6-c1e26bd07e88", "Blue")
                        .AddCell("59446203-e584-478e-8991-42706c01e4d8", "Clumsy 1 for 1 round.")
                        .AddCell("56068469-144a-407d-8edc-af02233ad5b3", "Clumsy 2 for 1 round.");
                });

            return builder.Build("77fab51e-5718-4cbc-93ec-29df80ce3c3b");
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
                Id = Guid.Parse("546fcab2-c5ad-4c9d-af5d-9ea4db1013f8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 397
            };
        }
    }
}
