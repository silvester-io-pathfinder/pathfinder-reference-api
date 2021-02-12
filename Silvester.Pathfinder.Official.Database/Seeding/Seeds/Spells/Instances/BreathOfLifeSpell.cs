using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class BreathOfLifeSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Reaction";
        public override string MagicSchool => "Necromancy";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("27b176c3-a4ac-425b-b7f1-9e6b7c25063f"),
                Name = "Breath of Life",
                Description = "Your blessing revives a creature at the moment of its death. You prevent the target from dying and restore Hit Points to the target equal to 4d8 plus your spellcasting ability modifier. You can’t use breath of life if the triggering effect was disintegrate or a death effect.",
                Level = 5,
                Range = 60,
                Targets = "The triggering creature."
            };
        }

        public override IEnumerable<SpellTrigger> GetTriggers()
        {
            yield return new SpellTrigger { Id = Guid.Parse("3992996d-8346-4d1b-9e96-13a13a9139bd"), Text = "A living creature within range would die." };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Divine";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Healing";
            yield return "Necromancy";
            yield return "Positive";
        }
    }
}
