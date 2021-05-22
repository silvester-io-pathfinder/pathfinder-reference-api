using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class WallOfThorns : Template
    {
        public static readonly Guid ID = Guid.Parse("c2d4733e-1336-4d4d-a37f-146e1682a14f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Wall of Thorns",
                Level = 3,
                Range = "60 feet.",
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c2d4733e-1336-4d4d-a37f-146e1682a14f"), Type = TextBlockType.Text, Text = "Over the course of a minute, you cause a thick wall of thorny brambles to grow from the ground. You create a 5-foot-thick wall of brambles and thorns in a straight line up to 60 feet long and 10 feet high. You must create the wall in an unbroken open space so its edges don’t pass through any creatures or objects, or the spell is lost. The wall stands vertically. If you wish, the wall can be of a shorter length or height. Everything on each side of the wall has cover from creatures on the opposite side, and the wall’s spaces are difficult terrain. For every move action a creature uses to enter at least one of the wall’s spaces, that creature takes 3d4 piercing damage." };
            yield return new TextBlock { Id = Guid.Parse("c2d4733e-1336-4d4d-a37f-146e1682a14f"), Type = TextBlockType.Text, Text = "Each 5-foot-by-5-foot section of the wall has AC 10, Hardness 10, and 20 Hit Points. It’s immune to critical hits and precision damage. A destroyed section can be moved through freely." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("c2d4733e-1336-4d4d-a37f-146e1682a14f"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("c2d4733e-1336-4d4d-a37f-146e1682a14f"), Type = TextBlockType.Text, Text = "The Hit Points of each section of the wall increase by 5, and the piercing damage increases by 1d4." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Plant.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c2d4733e-1336-4d4d-a37f-146e1682a14f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 383
            };
        }
    }
}
