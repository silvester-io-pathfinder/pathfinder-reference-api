using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class AnathematicReprisalSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Reaction";
        public override string MagicSchool => "Enchantment";
        public override string SavingThrowStat => "Will";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("dcadfb92-e8c7-47a4-a6cc-4de6eefb7c3c"),
                Name = "Anathematic Reprisal",
                Description = "You punish a creature that transgresses against your deity, drawing upon the anguish you feel upon seeing one of your deity’s anathema committed. You can cast this spell only when a creature actively commits a unique act of anathema. For example, if creating undead were anathema to your deity, you could use anathematic reprisal on a necromancer who had just created undead in front of you, but not on an undead creature just for existing. You deal 4d6 mental damage to the target, but a basic Will save can reduce this damage. If it fails, it is also stupefied 1 for 1 round. The creature is then temporarily immune for 1 minute.",
                Level = 4,
                Range = 30,
                Targets = "The triggering creature."
            };
        }

        public override IEnumerable<SpellTrigger> GetTriggers()
        {
            yield return new SpellTrigger { Id = Guid.Parse("8d805c41-9deb-4eee-b888-21aefafeba78"), Text = "A creature performs an act anathema to your deity." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening { Id = Guid.Parse("96d6be16-ee49-4b00-aa7e-7b364bd363bc"), Level = 1, Description = "The damage increases by 1d6." };
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
