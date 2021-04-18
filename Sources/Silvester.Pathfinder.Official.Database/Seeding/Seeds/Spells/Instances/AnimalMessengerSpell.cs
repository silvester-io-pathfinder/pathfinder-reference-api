using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class AnimalMessengerSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "No Action";
        public override string MagicSchool => "Enchantment";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("5ca21ccd-2ccc-4900-99fe-40480d6103f2"),
                Name = "Animal Messenger",
                Level = 2,
                Range = 120,
                CastTime = TimeSpan.FromMinutes(1),
                Duration = "24 hours."
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1b0611b5-02a7-40ca-9245-23b738f2e6fc"), Type = Utilities.Text.TextBlockType.Text, Text = "You offer food, and an ordinary Tiny animal within range approaches to eat it. You imprint the image, direction, and distance of an obvious place or landmark well known to you within the animal. You can also attach a small object or note up to light Bulk to it. The animal does its best to reach the destination; if it makes it there, it waits nearby and allows nonhostile creatures to approach and remove the attached object. The spell ends after the message is delivered or after 24 hours, whichever comes first." };
            yield return new TextBlock { Id = Guid.Parse("53d9891f-038b-459c-a98a-76577a5aac33"), Type = Utilities.Text.TextBlockType.Text, Text = "If there are no Tiny wild animals in range, the spell is lost." };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Material";
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Primal";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Enchantment";
            yield return "Mental";
        }
    }
}
