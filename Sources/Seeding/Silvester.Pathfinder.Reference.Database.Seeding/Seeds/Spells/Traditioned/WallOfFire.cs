using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class WallOfFire : Template
    {
        public static readonly Guid ID = Guid.Parse("d401091b-7d19-46c6-aa97-a510fb2d8cc7");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Wall of Fire",
                Level = 4,
                Range = "120 feet.",
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("23c39a69-ffbd-4406-b1b1-29558f0a8f5e"), Type = TextBlockType.Text, Text = "You raise a blazing wall that burns creatures passing through it. You create either a 5-foot-thick wall of flame in a straight line up to 60 feet long and 10 feet high, or a 5-foot-thick, 10-foot-radius ring of flame with the same height. The wall stands vertically in either form; if you wish, the wall can be of a shorter length or height. Everything on each side of the wall is concealed from creatures on the opposite side. Any creature that crosses the wall or is occupying the wall's area at the start of its turn takes 4d6 fire damage." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("e2cddc15-4bfd-4bc3-81d7-ed157b3d7e95"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("350c03fd-2d60-4966-9037-0dba00f39a2b"), Type = TextBlockType.Text, Text = "The fire damage increases by 1d6." }
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
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Fire.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3ea80d0d-e4b2-412e-a7ea-6a1b8de7bf3a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 382
            };
        }
    }
}
