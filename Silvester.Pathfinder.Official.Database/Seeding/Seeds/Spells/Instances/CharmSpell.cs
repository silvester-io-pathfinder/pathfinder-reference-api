using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class CharmSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Enchantment";
        public override string SavingThrowStat => "Will";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("41b3515e-c59f-4ac6-92a2-ef16195cd647"),
                Name = "Charm",
                Description = "To the target, your words are honey and your visage seems bathed in a dreamy haze. It must attempt a Will save, with a +4 circumstance bonus if you or your allies recently threatened it or used hostile actions against it. You can Dismiss the spell. If you use hostile actions against the target, the spell ends. When the spell ends, the target doesn’t necessarily realize it was charmed unless its friendship with you or the actions you convinced it to take clash with its expectations, meaning you could potentially convince the target to continue being your friend via mundane means.",
                Level = 1,
                Range = 30,
                Targets = "1 creature."
            };
        }

        public override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect 
            {
                Id = Guid.Parse("ace65902-0a3b-4cec-acb6-6f8282687977"),
                CriticalSuccess = "The target is unaffected and aware you tried to charm it.",
                Success = "The target is unaffected but thinks your spell was something harmless instead of charm, unless it identifies the spell (see Identifying Spells on page 305).",
                Failure = "The target’s attitude becomes friendly toward you. If it was friendly, it becomes helpful. It can’t use hostile actions against you.",
                CriticalFailure = "The target’s attitude becomes helpful toward you, and it can’t use hostile actions against you."
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening { Id = Guid.Parse("8fad2d3e-740c-4f51-bb8d-8abe84a24783"), Level = 4, Description = "The duration lasts until the next time you make your daily preparations." };
            yield return new SpellHeightening { Id = Guid.Parse("99a5bbf6-51c5-4e42-ba6b-e1155c40d500"), Level = 8, Description = "The duration lasts until the next time you make your daily preparations, and you can target up to 10 creatures." };
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
            yield return "Emotion";
            yield return "Enchantment";
            yield return "Incapacitation";
            yield return "Mental";
        }
    }
}
