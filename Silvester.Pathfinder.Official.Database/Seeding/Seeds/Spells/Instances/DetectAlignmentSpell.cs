using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DetectAlignmentSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Divination";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("54d80001-c58b-4524-b23d-3962bb5f7ed4"),
                Name = "Detect Alignment",
                Description = "Your eyes glow as you sense aligned auras. Choose chaotic, evil, good, or lawful. You detect auras of that alignment. You receive no information beyond presence or absence. You can choose not to detect creatures or effects you’re aware have that alignment.",
                Level = 1,
                Area = "30-foot emanation"
            };
        }

        public override IEnumerable<SpellDetailBlock> GetSpellDetailBlocks()
        {
            yield return new SpellDetailBlock { Id = Guid.Parse("93b29669-1b66-422e-96be-17a1c795e34f"), Text = "Only creatures of 6th level or higher—unless divine spellcasters, undead, or beings from the Outer Sphere—have alignment auras." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening { Id = Guid.Parse("be4200a2-c623-4146-890a-bddb87f620cf"), Level = 2, Description = "You learn each aura's location and strength." };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Divine";
            yield return "Occult";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Uncommon";
            yield return "Detection";
            yield return "Divination";
        }
    }
}
