using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ClairvoyanceSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "No Action";
        public override string MagicSchool => "Divination";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("af9903ec-8e9e-4752-bae4-042aca73f91a"),
                Name = "Clairvoyance",
                Level = 4,
                Range = 500,
                CastTime = TimeSpan.FromMinutes(1),
                Duration = "10 minutes."
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fe688355-a855-421f-bb33-20b2fd2b25d1"), Type = Utilities.Text.TextBlockType.Text, Text = "You create an invisible floating eye at a location within range (even if it’s outside your line of sight or line of effect). The eye can’t move, but you can see in all directions from that point as if using your normal visual senses." };
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
            yield return "Divination";
            yield return "Scrying";
        }
    }
}
