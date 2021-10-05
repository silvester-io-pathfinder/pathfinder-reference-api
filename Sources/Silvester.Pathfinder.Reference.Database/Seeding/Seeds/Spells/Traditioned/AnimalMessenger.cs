using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class AnimalMessenger : Template
    {
        public static readonly Guid ID = Guid.Parse("5ca21ccd-2ccc-4900-99fe-40480d6103f2");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Animal Messenger",
                Level = 2,
                Range = "120 feet.",
                CastTime = "1 minute.",
                Duration = "24 hours.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1b0611b5-02a7-40ca-9245-23b738f2e6fc"), Type = Utilities.Text.TextBlockType.Text, Text = "You offer food, and an ordinary Tiny animal within range approaches to eat it. You imprint the image, direction, and distance of an obvious place or landmark well known to you within the animal. You can also attach a small object or note up to light Bulk to it. The animal does its best to reach the destination; if it makes it there, it waits nearby and allows nonhostile creatures to approach and remove the attached object. The spell ends after the message is delivered or after 24 hours, whichever comes first." };
            yield return new TextBlock { Id = Guid.Parse("53d9891f-038b-459c-a98a-76577a5aac33"), Type = Utilities.Text.TextBlockType.Text, Text = "If there are no Tiny wild animals in range, the spell is lost." };
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
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("482fef50-2d43-4c48-92dc-aea4e171764f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 318
            };
        }
    }
}
