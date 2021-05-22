using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Tables;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DetectAlignment : Template
    {
        public static readonly Guid ID = Guid.Parse("54d80001-c58b-4524-b23d-3962bb5f7ed4");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Detect Alignment",
                Level = 1,
                Area = "30-foot emanation",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d37d719b-1a7d-4c17-bfcf-be3fbd1d9e64"), Type = Utilities.Text.TextBlockType.Text, Text = "Your eyes glow as you sense aligned auras. Choose chaotic, evil, good, or lawful. You detect auras of that alignment. You receive no information beyond presence or absence. You can choose not to detect creatures or effects you’re aware have that alignment." };
            yield return new TextBlock { Id = Guid.Parse("93b29669-1b66-422e-96be-17a1c795e34f"), Type = Utilities.Text.TextBlockType.Text, Text = "Only creatures of 6th level or higher—unless divine spellcasters, undead, or beings from the Outer Sphere—have alignment auras." };
        }

        protected override Table? GetTable(TableBuilder builder)
        {
            builder
                .AddColumn("a995d2ac-862a-4144-a49d-ebe41674b98d", "Creature or Item Level")
                .AddColumn("5fbc8431-df89-49f0-8031-278de1d821d7", "Spell or Effect Level")
                .AddColumn("3b3ca2e1-0bae-4139-8a60-a5a67eed076c", "Aura Strength")
                .AddRow("67704341-3c02-40fa-abf7-7bb01147f9d9", row =>
                {
                    row.AddCell("92b4678a-f0df-4d06-8145-13949c8abf7e", "0-5");
                    row.AddCell("2c0c37e8-5033-4b6d-bae8-9761cbf12512", "-");
                    row.AddCell("746c0b3e-83a3-483c-9bc8-c8bbf6c5ba5b", "None");
                })
                .AddRow("8e5b88b0-47fb-489e-9a1b-6b3c1b03e2f3", row =>
                {
                    row.AddCell("5f27f445-de06-47c7-9d83-a2d8b4f7805c", "6-10");
                    row.AddCell("d5e05a9d-2570-4d18-a5d0-2158af7c457f", "0-3");
                    row.AddCell("f1e5b86d-eca6-42f4-856f-b2ed70c38a87", "Faint");
                })
                .AddRow("93244a11-0097-47dc-94c0-38cb7603a229", row =>
                {
                    row.AddCell("884ab5b0-8f89-4568-944d-9e645aa0f796", "11-15");
                    row.AddCell("f21212d2-9441-4f9f-91f6-c1b146882597", "4-7");
                    row.AddCell("7867aa1f-fd1c-4983-979f-cfab25851b17", "Moderate");
                })
                .AddRow("772692cd-853c-4adc-9c37-2b67f4afd24f", row =>
                {
                    row.AddCell("26aca67e-567e-4abc-bad2-6f8d889d254a", "16-20");
                    row.AddCell("e49811d9-7330-4803-97b2-48e6eb30c70a", "4-7");
                    row.AddCell("9fe614a2-f821-48d9-be52-d420b8f69417", "Moderate");
                })
                .AddRow("6d62d5c6-671a-4023-aa1b-ab989bea290c", row =>
                {
                    row.AddCell("7f98a85c-4835-4940-9abd-ed786424ed0a", "21+");
                    row.AddCell("0bb5fe75-a9d1-4a4b-bbf4-1cedee2c2d5b", "10");
                    row.AddCell("a3c30e30-faa2-450f-83bc-f688558f55df", "Overwhelming");
                });

            return builder.Build("2258f9cf-0a20-4580-a2dd-66ef4ba69280", "The strength of an alignment aura depends on the level of the creature, item, or spell. The auras of undead, clerics and other divine spellcasters with a patron deity, and creatures from the Outer Sphere are one step stronger than normal (faint instead of none, for example).");
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("be4200a2-c623-4146-890a-bddb87f620cf"), 
                Level = "2nd", 
                Details =
                {
                    new TextBlock { Id = Guid.Parse("a5619aec-d3da-4d3e-baaa-fb27eae58a13"), Type = Utilities.Text.TextBlockType.Text, Text = "You learn each aura's location and strength." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Detection.ID;
            yield return Traits.Instances.Divination.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("29e16aa5-3741-4ab5-a690-e0f7050f9d85"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 328
            };
        }
    }
}
