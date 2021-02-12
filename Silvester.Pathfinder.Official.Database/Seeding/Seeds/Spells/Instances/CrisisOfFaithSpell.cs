using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class CrisisOfFaithSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Enchantment";
        public override string SavingThrowStat => "Will";
        
        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("b7157338-c1de-4e79-a90c-e0f62abd709c"),
                Name = "Crisis of Faith",
                Description = "You assault the target’s faith, riddling the creature with doubt and mental turmoil that deal 6d6 mental damage, or 6d8 mental damage if it can cast divine spells. The effects are determined by its Will save.",
                Level = 3,
                Range = 30,
                Targets = "1 creature."
            };
        }

        public override IEnumerable<SpellDetailBlock> GetSpellDetailBlocks()
        {
            yield return new SpellDetailBlock { Id = Guid.Parse("858468ee-88f6-495c-8cf5-542d9209b061"), Text = "To many deities, casting this spell on a follower of your own deity without significant cause is anathema." }; 
        }

        public override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("6a073760-7f3c-41ea-adbc-276607b88ece"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes half damage.",
                Failure = "The target takes full damage; if the target can cast divine spells, it’s stupefied 1 for 1 round.",
                CriticalFailure = "The target takes double damage, is stupefied 1 for 1 round, and can’t cast divine spells for 1 round."
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening { Id = Guid.Parse("ae249d83-3fe3-4e38-8154-4d6b07924f3c"), Level = 1, Description = "The damage increases by 2d6 (or by 2d8 if the target is a divine spellcaster)." };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Divine";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Enchantment";
            yield return "Mental";
        }
    }
}
