using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ShatteringGem : Template
    {
        public static readonly Guid ID = Guid.Parse("0c1876b3-98e3-41e5-b626-bfd88a58b1df");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Shattering Gem",
                Level = 1,
                Range = "Touch.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3c29ebe0-e9be-45a3-9e90-2e936ed061d8"), Type = TextBlockType.Text, Text = "A large gem floats around the target in an erratic pattern. The gem has 5 Hit Points. Each time a creature Strikes the target, the target attempts a DC 11 flat check. On a success, the gem blocks the attack, so the attack first damages the gem and then applies any remaining damage to the target. If the gem is reduced to 0 Hit Points, it shatters, immediately dealing the creature that destroyed it 1d8 slashing damage (basic Reflex save), as long as that creature is within 10 feet of the target." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("b8eefadb-ded5-48b2-bed5-b8908cffbc17"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("44640285-0897-4c19-8540-18113468dd97"), Type = TextBlockType.Text, Text = "The gem has 5 additional HP, and the damage dealt by its detonation increases by 1d8." }
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
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Earth.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3caa28d0-6b09-4139-bfd4-5160057c9ee9"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 109
            };
        }
    }
}
