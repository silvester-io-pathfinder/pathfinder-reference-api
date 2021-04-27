using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class AbyssalPlagueSpell : AbstractSpellTemplate
    {
        public static readonly Guid ID = Guid.Parse("328dda55-0bc8-461f-a3d3-686df512438c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Abyssal Plague",
                Level = 5,
                Range = 0,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d3c3fea0-9363-4659-a888-2196a2e88b29"), Type = Utilities.Text.TextBlockType.Text, Text = "Your touch afflicts the target with Abyssal plague, which siphons fragments of their soul away to empower the Abyss. The effect is based on the target’s Fortitude save." };
        }

        public override RollableEffect GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("0450af9d-7660-403b-8970-5515635a7779"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes 2 evil damage per spell level, and takes a –2 status penalty to saves against Abyssal plague for 1 day or until the target contracts it, whichever comes first.",
                Failure = "The target is afflicted with Abyssal plague at stage 1.",
                CriticalFailure = "The target is afflicted with Abyssal plague at stage 2."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Chaotic.ID;
            yield return Traits.Instances.Disease.ID;
            yield return Traits.Instances.Evil.ID;
            yield return Traits.Instances.Necromancy.ID;
        }
    }
}
