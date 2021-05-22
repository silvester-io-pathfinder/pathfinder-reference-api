using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class WallOfFire : Template
    {
        public static readonly Guid ID = Guid.Parse("a74a9914-720c-47e9-950a-ee3dba38800a");

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
            yield return new TextBlock { Id = Guid.Parse("a74a9914-720c-47e9-950a-ee3dba38800a"), Type = TextBlockType.Text, Text = "You raise a blazing wall that burns creatures passing through it. You create either a 5-foot-thick wall of flame in a straight line up to 60 feet long and 10 feet high, or a 5-foot-thick, 10-foot-radius ring of flame with the same height. The wall stands vertically in either form; if you wish, the wall can be of a shorter length or height. Everything on each side of the wall is concealed from creatures on the opposite side. Any creature that crosses the wall or is occupying the wall’s area at the start of its turn takes 4d6 fire damage." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("a74a9914-720c-47e9-950a-ee3dba38800a"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("a74a9914-720c-47e9-950a-ee3dba38800a"), Type = TextBlockType.Text, Text = "The fire damage increases by 1d6." }
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
                Id = Guid.Parse("a74a9914-720c-47e9-950a-ee3dba38800a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 382
            };
        }
    }
}
