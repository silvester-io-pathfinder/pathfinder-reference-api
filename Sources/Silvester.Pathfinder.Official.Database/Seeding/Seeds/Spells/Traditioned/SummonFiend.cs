using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class SummonFiend : Template
    {
        public static readonly Guid ID = Guid.Parse("52d68049-4e45-4aef-a657-c2f22c3292c4");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Summon Fiend",
                Level = 5,
                Range = "30 feet.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("52d68049-4e45-4aef-a657-c2f22c3292c4"), Type = TextBlockType.Text, Text = "You conjure a fiend to fight for you. You summon a common creature that has the fiend trait and whose level is 5 or lower, such as those found in Pathfinder Bestiary volumes. Heightening the spell increases the maximum level of creature you can summon. You can’t summon a creature unless its alignment is one of your deity’s preferred alignments (or, if you don’t have a deity, is within one step of your alignment). At the GM’s discretion, some deities might restrict specific types of fiends, even if their alignments match." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("52d68049-4e45-4aef-a657-c2f22c3292c4"),
                Level = "2nd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("52d68049-4e45-4aef-a657-c2f22c3292c4"), Type = TextBlockType.Text, Text = "The summoned creature's level is 1." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("52d68049-4e45-4aef-a657-c2f22c3292c4"),
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("52d68049-4e45-4aef-a657-c2f22c3292c4"), Type = TextBlockType.Text, Text = "The summoned creature's level is 2." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("52d68049-4e45-4aef-a657-c2f22c3292c4"),
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("52d68049-4e45-4aef-a657-c2f22c3292c4"), Type = TextBlockType.Text, Text = "The summoned creature's level is 3." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("52d68049-4e45-4aef-a657-c2f22c3292c4"),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("52d68049-4e45-4aef-a657-c2f22c3292c4"), Type = TextBlockType.Text, Text = "The summoned creature's level is 5." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("52d68049-4e45-4aef-a657-c2f22c3292c4"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("52d68049-4e45-4aef-a657-c2f22c3292c4"), Type = TextBlockType.Text, Text = "The summoned creature's level is 7." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("52d68049-4e45-4aef-a657-c2f22c3292c4"),
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("52d68049-4e45-4aef-a657-c2f22c3292c4"), Type = TextBlockType.Text, Text = "The summoned creature's level is 9." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("52d68049-4e45-4aef-a657-c2f22c3292c4"),
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("52d68049-4e45-4aef-a657-c2f22c3292c4"), Type = TextBlockType.Text, Text = "The summoned creature's level is 11." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("52d68049-4e45-4aef-a657-c2f22c3292c4"),
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("52d68049-4e45-4aef-a657-c2f22c3292c4"), Type = TextBlockType.Text, Text = "The summoned creature's level is 13." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("52d68049-4e45-4aef-a657-c2f22c3292c4"),
                Level = "10th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("52d68049-4e45-4aef-a657-c2f22c3292c4"), Type = TextBlockType.Text, Text = "The summoned creature's level is 15." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Conjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("52d68049-4e45-4aef-a657-c2f22c3292c4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 375
            };
        }
    }
}
