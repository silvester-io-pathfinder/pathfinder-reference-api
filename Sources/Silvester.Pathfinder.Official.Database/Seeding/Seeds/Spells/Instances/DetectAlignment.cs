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
                SpellTypeId = SpellTypes.Instances.Focus.ID,
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
                .AddColumn("", "Creature or Item Level")
                .AddColumn("", "Spell or Effect Level")
                .AddColumn("", "Aura Strength")
                .AddRow("", row =>
                {
                    row.AddCell("", "0-5");
                    row.AddCell("", "-");
                    row.AddCell("", "None");
                })
                .AddRow("", row =>
                {
                    row.AddCell("", "6-10");
                    row.AddCell("", "0-3");
                    row.AddCell("", "Faint");
                })
                .AddRow("", row =>
                {
                    row.AddCell("", "11-15");
                    row.AddCell("", "4-7");
                    row.AddCell("", "Moderate");
                })
                .AddRow("", row =>
                {
                    row.AddCell("", "16-20");
                    row.AddCell("", "4-7");
                    row.AddCell("", "Moderate");
                })
                .AddRow("", row =>
                {
                    row.AddCell("", "21+");
                    row.AddCell("", "10");
                    row.AddCell("", "Overwhelming");
                });

            return builder.Build("", "The strength of an alignment aura depends on the level of the creature, item, or spell. The auras of undead, clerics and other divine spellcasters with a patron deity, and creatures from the Outer Sphere are one step stronger than normal (faint instead of none, for example).");
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
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 328
            };
        }
    }
}
