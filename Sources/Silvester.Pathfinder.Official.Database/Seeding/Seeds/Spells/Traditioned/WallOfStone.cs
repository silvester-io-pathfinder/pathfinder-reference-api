using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class WallOfStone : Template
    {
        public static readonly Guid ID = Guid.Parse("5a043675-fed0-4aa8-86d4-1fc30eb28c12");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Wall of Stone",
                Level = 5,
                Range = "120 feet.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0d39792e-04e6-4de7-929f-1da88ffe66bc"), Type = TextBlockType.Text, Text = "You shape a wall of solid stone. You create a 1-inch-thick wall of stone up to 120 feet long, and 20 feet high. You can shape the wall’s path, placing each 5 feet of the wall on the border between squares. The wall doesn’t need to stand vertically, so you can use it to form a bridge or set of stairs, for example. You must conjure the wall in an unbroken open space so its edges don’t pass through any creatures or objects, or the spell is lost." };
            yield return new TextBlock { Id = Guid.Parse("31e01a97-a11a-4953-93d2-3bed2260b5bd"), Type = TextBlockType.Text, Text = "Each 5-foot-by-5-foot section of the wall has AC 10, Hardness 14, and 50 Hit Points, and it’s immune to critical hits and precision damage. A destroyed section of the wall can be moved through, but the rubble created from it is difficult terrain." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("7d6aed9b-686b-446b-b987-b3615d2efbcc"), 
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("cfaccd84-771e-49f5-8b4d-a869960ce59a"), Type = TextBlockType.Text, Text = "The Hit Points of each section of the wall increase by 15." }
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
                Id = Guid.Parse("cbddfc7d-b4f6-46f7-938f-ac0525ba87b1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 383
            };
        }
    }
}
