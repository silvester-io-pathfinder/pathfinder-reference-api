using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class HouseOfImaginaryWalls : Template
    {
        public static readonly Guid ID = Guid.Parse("b388b870-f2ff-4d79-9078-8889ac259f22");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "House of Imaginary Walls",
                Level = 5,
                Range = "Touch.",
                Duration = "1 round.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Bard.ID,
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a90611dd-3cf2-4b0c-9fda-a74cc8db8f99"), Type = TextBlockType.Text, Text = "You mime an invisible 10-foot-by-10-foot wall adjacent to you and within your reach. The wall is solid to those creatures that don’t disbelieve it, even incorporeal creatures. You and your allies can voluntarily believe the wall exists to continue to treat it as solid, for instance to climb onto it. A creature that disbelieves the illusion is temporarily immune to your house of imaginary walls for 1 minute. The wall doesn’t block creatures that didn’t see your visual performance, nor does it block objects. The wall has AC 10, Hardness equal to double the spell’s level, and HP equal to quadruple the spell’s level." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Bard.ID;
            yield return Traits.Instances.Cantrip.ID;
            yield return Traits.Instances.Composition.ID;
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Visual.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("06cf1bde-3e4c-49c3-85e6-e563d43d6ece"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 386
            };
        }
    }
}
