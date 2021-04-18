using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class BlackTentaclesSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Three Actions";
        public override string MagicSchool => "Conjuration";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("436d4b2a-846a-4ff1-ae57-63ecfe80f337"),
                Name = "Black Tentacle",
                Level = 5,
                Range = 120,
                Duration = "1 minute.",
                Targets = "20-foot burst adjecent to a flat surface."
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("410bc6f5-72ec-4aae-9571-4305984478a9"), Type = Utilities.Text.TextBlockType.Text, Text = "Oily black tentacles rise up and attempt to capture creatures in the area. Make spell attack rolls against the Fortitude DC of each creature in the area. Any creature you succeed againstis grabbed by a tentacle and takes 3d6 bludgeoning damage.Whenever a creature ends its turn in the area, the tentacles attempt to grab that creature if they haven’t already, and they deal 1d6 bludgeoning damage to any creature already grabbed. The tentacles’ Escape DC is equal to your spell DC. A creature can attack a tentacle in an attempt to release its grip. Its AC is equal to your spell DC, and it is destroyed if it takes 12 or more damage. Even if destroyed, additional tentacles continue to grow in the area until the duration ends. You can Dismiss the spell." };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Material";
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Arcane";
            yield return "Occult";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Conjuration";
        }
    }
}
