using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class BlinkSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Conjuration";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("e130e307-ede2-4a68-9667-cfc482855d95"),
                Name = "Blink",
                Level = 3,
                Duration = "1 minute."
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("06487cd4-8f08-4bda-bbdb-74387d15734e"), Type = Utilities.Text.TextBlockType.Text, Text = "You blink quickly between the Material Plane and the Ethereal Plane. You gain resistance 5 to all damage (except force). You can Sustain the Spell to vanish and reappear 10 feet away in a random direction determined by the GM; the movement doesn’t trigger reactions. At the end of your turn, you vanish and reappear as above." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("84e120a3-6dd6-4348-9a07-934858f71840"),
                Level = 2,
                Details =
                {
                    new TextBlock { Id = Guid.Parse("74827007-1d12-462a-a927-1324a4bf22ae"), Type = Utilities.Text.TextBlockType.Text, Text = "The resistance increases by 3." }
                }
            };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
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
            yield return "Teleportation";
        }
    }
}
