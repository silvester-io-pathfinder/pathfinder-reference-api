using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
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
            yield return new TextBlock { Id = Guid.Parse("a90611dd-3cf2-4b0c-9fda-a74cc8db8f99"), Type = TextBlockType.Text, Text = "You mime an invisible 10-foot-by-10-foot wall adjacent to you and within your reach. The wall is solid to those creatures that don't disbelieve it, even incorporeal creatures. You and your allies can voluntarily believe the wall exists to continue to treat it as solid, for instance to climb onto it. A creature that disbelieves the illusion is temporarily immune to your house of imaginary walls for 1 minute. The wall doesn't block creatures that didn't see your visual performance, nor does it block objects. The wall has AC 10, Hardness equal to double the spell's level, and HP equal to quadruple the spell's level." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("8e4eb906-6227-423c-9ea9-e06a7bb489cf"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("8c32f08a-256a-4175-86de-e39ebc330ed1"), Traits.Instances.Bard.ID);
            builder.Add(Guid.Parse("ebbcedc3-bfe0-429c-93b2-efb399e1781b"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("bbbddd78-1818-4b84-8554-f4f8def59c02"), Traits.Instances.Composition.ID);
            builder.Add(Guid.Parse("c286efd3-736c-4d93-9a8d-4df7bd18e97a"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("a31617fa-1071-486a-a0d8-c0294c8f7292"), Traits.Instances.Visual.ID);
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
