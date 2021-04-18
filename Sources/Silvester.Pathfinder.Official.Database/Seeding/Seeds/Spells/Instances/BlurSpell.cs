using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class BlurSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Illusion";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("4f77cd26-f3f0-4e6a-8424-b01480daadc4"),
                Name = "Blur",
                Level = 2,
                Duration = "1 minute.",
                Range = 0,
                Targets = "1 creature."
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("de383eb7-ec7f-460b-8b53-87dafd843c6e"), Type = Utilities.Text.TextBlockType.Text, Text = "The target’s form appears blurry. It becomes concealed. As the nature of this effect still leaves the target’s location obvious, the target can’t use this concealment to Hide or Sneak." };
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
            yield return "Illusion";
            yield return "Verbal";
        }
    }
}
