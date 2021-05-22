using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class PhantomSteed : Template
    {
        public static readonly Guid ID = Guid.Parse("c2a06c80-ed09-45aa-8a2f-25949cdc6ae9");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Phantom Steed",
                Level = 2,
                CastTime = "10 minutes.",
                Range = "30 feet.",
                Duration = "8 hours.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b6851595-88ae-40ca-a699-0ae4b9239993"), Type = TextBlockType.Text, Text = "You conjure a Large, magical, equine creature that only you (or another Medium or Small creature you choose) can ride. The horse is clearly phantasmal in nature, has 20 AC and 10 Hit Points, and automatically fails all saves. If it’s reduced to 0 Hit Points, it disappears and the spell ends. The steed has a Speed of 40 feet and can hold its rider’s body weight, plus 20 Bulk." };
        }
        
        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("cdbd556e-1007-44bc-956a-bdea4e2ad8c7"),
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("c94d0dff-8f84-45b1-b7be-a0ef6a9545c1"), Type = TextBlockType.Text, Text = "The steed has a Speed of 60 feet, can walk on water, and ignores areas of natural difficult terrain." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("959bcfec-a6a4-4671-9d00-57f895e4b8d7"),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("e9bd81e7-238c-4fef-ba9b-073093b49eb1"), Type = TextBlockType.Text, Text = "The steed has a Speed of 60 feet, can walk on water, and ignores areas of natural difficult terrain. It can also air walk but must end its turn on solid ground or fall." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("a17f90b6-b49e-4b00-b044-fcaeb1a20b63"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("602734bc-ea2e-4eb3-8a3c-0ee630c5f2d3"), Type = TextBlockType.Text, Text = "The steed can walk or fly at a Speed of 80 feet, can walk on water, and ignores natural difficult terrain." }
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
            yield return MagicTraditions.Instances.Primal.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Conjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4b8ecf5d-b5a0-4829-b247-7a20ed419e85"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 357
            };
        }
    }
}
