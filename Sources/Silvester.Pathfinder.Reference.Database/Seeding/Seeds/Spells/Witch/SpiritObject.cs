using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SpiritObject : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Spirit Object",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 unattended object up to 1 Bulk.",
                ActionTypeId = ActionTypes.Instances.OneOrTwoActions.ID,
                ClassId = Classes.Instances.Witch.ID,
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Using a sliver of Baba Yaga's power, you briefly bring an object to life. The object gains a means of locomotion, such as sprouting chicken legs, and Strides up to 25 feet to a space you decide within range. If you spent 2 actions Casting the Spell, the object then attacks one creature of your choice adjacent to its new space. Make a melee spell attack roll against the creature. On a success, the creature takes bludgeoning, piercing, or slashing damage (as appropriate for the object) equal to 1d4 plus your spellcasting ability modifier, and on a critical success, it takes double damage." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse(""),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Increase the maximum Bulk of the target by 1 and the damage by 1d4." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Cantrip.ID;
            yield return Traits.Instances.Hex.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Witch.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4cb76e81-9582-4f14-b8b5-f5523b547251"),
                SourceId = Sources.Instances.Legends.ID,
                Page = 32
            };
        }
    }
}
