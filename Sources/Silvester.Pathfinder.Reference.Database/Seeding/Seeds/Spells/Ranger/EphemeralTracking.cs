using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class EphemeralTracking : Template
    {
        public static readonly Guid ID = Guid.Parse("55a2e6d4-d58f-4cba-b5ff-77f54aa4e48b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Ephemeral Tracking",
                Level = 3,
                Duration = "1 hour.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Ranger.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("448b4d91-a838-4727-8ab0-5b01312e9001"), Type = TextBlockType.Text, Text = "You can look at currents in the air and water and see tracks that you can follow just as you would on land. You can use Survival to Track through both air and water, noticing aerial or aquatic “tracks” of all creatures who passed nearby in the last hour. It’s more difficult to Track in this way: the DC to Track through air or water is always at least 30, or higher after precipitation or wind (in the air) or heavy tides or currents (in the water). It’s possible to Cover Tracks against this spell, but creatures might not realize they need to do so." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Ranger.ID;
            yield return Traits.Instances.Divination.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dfb05255-6e37-4f67-8e83-4a2ae131cccd"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 234
            };
        }
    }
}
