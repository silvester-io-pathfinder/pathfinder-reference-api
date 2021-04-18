using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DancingLightsSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Cantrip";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Evocation";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("7b0f3283-1f79-4a64-a697-eb842bb776b2"),
                Name = "Dancing Lights",
                Level = 1,
                Range = 120,
                Duration = "Sustained."
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b68ff7f1-51e6-44b8-b9c3-0af52ed1082c"), Type = Utilities.Text.TextBlockType.Text, Text = "You create up to four floating lights, no two of which are more than 10 feet apart. Each sheds light like a torch. When you Sustain the Spell, you can move any number of lights up to 60 feet. Each light must remain within 120 feet of you and within 10 feet of all others, or it winks out." };
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
            yield return "Primal";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Cantrip";
            yield return "Evocation";
            yield return "Light";
        }
    }
}
