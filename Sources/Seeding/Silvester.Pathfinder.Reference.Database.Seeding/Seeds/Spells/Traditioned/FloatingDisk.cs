using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class FloatingDisk : Template
    {
        public static readonly Guid ID = Guid.Parse("f6c88aa0-9627-4eac-815c-41c4a31acd9e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Floating Disk",
                Level = 1,
                Duration = "8 hours",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b197b408-2b0b-4afa-bd40-1c27e994e335"), Type = TextBlockType.Text, Text = "A disk of magical force materializes adjacent to you. This disk is 2 feet in diameter and follows 5 feet behind you, floating just above the ground. It holds up to 5 Bulk of objects (though they must be able to fit and balance on its surface). Any objects atop the disk fall to the ground when the spell ends." };
            yield return new TextBlock { Id = Guid.Parse("750ac885-e20b-4032-8027-ba7e81eb4cd3"), Type = TextBlockType.Text, Text = "The spell ends if a creature tries to ride atop the disk, if the disk is overloaded, if anyone tries to lift or force the disk higher above the ground, or if you move more than 30 feet away from the disk." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
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
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Force.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d5252680-6757-44d9-b767-37da3e6ef818"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 339
            };
        }
    }
}
