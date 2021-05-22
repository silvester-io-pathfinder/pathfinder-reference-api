using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ReverseGravity : Template
    {
        public static readonly Guid ID = Guid.Parse("6404a5b3-90a1-425d-abc5-b87d531b5bdc");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Reverse Gravity",
                Level = 7,
                Range = "120 feet.",
                Area = "20-foot radius, 40-foot-tall cylinder.",
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4e78afe2-837a-4536-98a5-fe31ee2f395c"), Type = TextBlockType.Text, Text = "You reverse gravity in the area. Creatures and objects that aren’t secured to the ground immediately fall upward to the top of the area. A creature might be able to Grab an Edge to arrest its fall if it falls past an appropriate surface. If a creature falls against a solid object (such as a ceiling), it takes the appropriate amount of falling damage and lands on the surface. Once an object or creature reaches the top of the area, it floats, caught between the normal and reversed gravity. The creature can move along the plane where the two forms of gravity meet. Creatures that can levitate or fly can use those abilities to mitigate the effects of reverse gravity." };
            yield return new TextBlock { Id = Guid.Parse("964a22e4-3812-494b-9041-4c4edfb0f9dd"), Type = TextBlockType.Text, Text = "When reverse gravity ends, all creatures and objects caught in the area fall back down. Likewise, anything that moves beyond the spell’s area is subjected to normal gravity again." };
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Occult.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6c0cbf11-dc73-49fd-be7a-7680a8527594"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 365
            };
        }
    }
}
