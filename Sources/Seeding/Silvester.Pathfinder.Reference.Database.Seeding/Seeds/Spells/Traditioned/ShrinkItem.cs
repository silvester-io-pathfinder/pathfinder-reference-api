using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ShrinkItem : Template
    {
        public static readonly Guid ID = Guid.Parse("fda456f7-c79c-486f-b6b8-0f054565deac");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Shrink Item",
                Level = 3,
                CastTime = "10 minutes.",
                Range = "Touch.",
                Duration = "1 day.",
                Targets = "1 non-magical object up to 20 cubic feet in volume and up to 80 bulk.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4d1b85ca-b824-431a-a0ea-a29fb9a55b35"), Type = TextBlockType.Text, Text = "You shrink the target to roughly the size of a coin. This reducesit to negligible Bulk. You can Dismiss the spell, and the spell ends if you toss the object onto a solid surface. The object can’t be used to attack or cause damage during the process of it returning to normal size. If there isn’t room for the object to return to normal size when the spell ends, the spell’s duration continues until the object is in a location large enough to accommodate its normal size." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Polymorph.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9ae15651-589e-4023-91e3-63368388059e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 369
            };
        }
    }
}
