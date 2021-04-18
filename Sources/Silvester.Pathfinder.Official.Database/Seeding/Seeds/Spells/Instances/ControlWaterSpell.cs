using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ControlWaterSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Evocation";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("b2cc63b2-466a-478a-b024-b785f2b722de"),
                Name = "Control Water",
                Level = 5,
                Range = 500,
                Area = "50 feet long by 50 feet wide"
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ecde9a96-ca65-4f65-85aa-9500e8417229"), Type = Utilities.Text.TextBlockType.Text, Text = "By imposing your will upon the water, you can raise or lower the level of water in the chosen area by 10 feet. Water creatures in the area are subjected to the effects of slow." };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Arcane";
            yield return "Primal";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Evocation";
            yield return "Water";
        }
    }
}
