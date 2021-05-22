using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class MageArmor : Template
    {
        public static readonly Guid ID = Guid.Parse("6176512c-2c29-445f-885b-b4929a886fb9");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Mage Armor",
                Level = 1,
                Duration = "Until the next time you make your daily preparations.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b78109a0-8e71-474c-b6ac-60059a4a93f8"), Type = TextBlockType.Text, Text = "You ward yourself with shimmering magical energy, gaining a +1 item bonus to AC and a maximum Dexterity modifier of +5. While wearing mage armor, you use your unarmored proficiency to calculate your AC." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("c4596fa3-5395-4c0e-bc2b-00acefeca908"),
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("213d6522-4a42-4838-8031-c1bd83cf4064"), Type = TextBlockType.Text, Text = "You gain a +1 item bonus to saving throws." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("302f0377-c00f-4cf9-b3f8-dc6601d2655f"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("d303a6ae-7e3f-40fa-baf4-4ce60fff9c83"), Type = TextBlockType.Text, Text = "The item bonus to AC increases to +2, and you gain a +1 item bonus to saving throws." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("518cd078-8775-4a04-ba26-c0516f7437a5"),
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("e60efb6c-6a95-4c75-9686-51357b3cf4de"), Type = TextBlockType.Text, Text = "The item bonus to AC increases to +2, and you gain a +2 item bonus to saving throws." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("3e7ad9a5-2a98-4a6d-96bd-7a9c01c4bbe4"),
                Level = "10th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("03476483-67a5-48a4-8eb8-9803d62b3ea7"), Type = TextBlockType.Text, Text = "The item bonus to AC increases to +3, and you gain a +3 item bonus to saving throws." }
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
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("545f03e3-afa7-4428-a3a4-7e9f717f29ec"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 348
            };
        }
    }
}
