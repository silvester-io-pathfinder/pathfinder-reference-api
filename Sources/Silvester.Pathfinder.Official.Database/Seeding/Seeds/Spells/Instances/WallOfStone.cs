using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class WallOfStone : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Wall of Stone",
                Level = 5,
                Range = "120 feet.",
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You shape a wall of solid stone. You create a 1-inch-thick wall of stone up to 120 feet long, and 20 feet high. You can shape the wall’s path, placing each 5 feet of the wall on the border between squares. The wall doesn’t need to stand vertically, so you can use it to form a bridge or set of stairs, for example. You must conjure the wall in an unbroken open space so its edges don’t pass through any creatures or objects, or the spell is lost." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Each 5-foot-by-5-foot section of the wall has AC 10, Hardness 14, and 50 Hit Points, and it’s immune to critical hits and precision damage. A destroyed section of the wall can be moved through, but the rubble created from it is difficult terrain." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse(""), 
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The Hit Points of each section of the wall increase by 15." }
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
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Earth.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 383
            };
        }
    }
}
