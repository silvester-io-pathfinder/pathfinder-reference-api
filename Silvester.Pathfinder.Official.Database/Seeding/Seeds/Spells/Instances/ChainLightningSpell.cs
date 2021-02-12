using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ChainLightningSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Evocation";
        public override string SavingThrowStat => "Reflex";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("7ca414c2-6185-4817-b1d7-9692d7a4433a"),
                Name = "Chain Lightning",
                Description = "You discharge a powerful bolt of lightning at the target, dealing 8d12 electricity damage. The target must attempt a basic Reflex save. The electricity arcs to another creature within 30 feet of the first target, jumps to another creature within 30 feet of that target, and so on. You can end the chain at any point. You can’t target the same creature more than once, and you must have line of effect to all targets. Roll the damage only once, and apply it to each target (halving or doubling as appropriate for its saving throw outcome). The chain ends if any one of the targets critically succeeds at its save.",
                Level = 6,
                Range = 500,
                Targets = "1 creature, plus any number of additional creatures."
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening { Id = Guid.Parse("e7d4ce94-e923-43fb-bcc9-e34987534372"), Level = 1, Description = "The damage increases by 1d12." };
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
            yield return "Electricity";
            yield return "Evocation";
        }
    }
}
