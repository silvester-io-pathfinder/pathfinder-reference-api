using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Weird : Template
    {
        public static readonly Guid ID = Guid.Parse("e6df0cbc-a1af-4584-b496-2202c86efc87");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Weird",
                Level = 9,
                Range = "120 feet.",
                Targets = "Any number of creatures.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e6df0cbc-a1af-4584-b496-2202c86efc87"), Type = TextBlockType.Text, Text = "You fill the targets’ minds with terrifying images of fearsome creatures, each drawn from the targets’ worst fears. Only the targets can see their assailants. Each target takes 16d6 mental damage and must attempt a Will save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("e6df0cbc-a1af-4584-b496-2202c86efc87"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes half damage and is frightened 1.",
                Failure = "The target takes full damage and is frightened 2.",
                CriticalFailure = "The target is so afraid, it might instantly die. It must attempt a Fortitude saving throw. If the target succeeds, it takes double damage and is frightened 2, and it’s also fleeing until the end of its next turn unless it critically succeeded. If it fails, it is reduced to 0 Hit Points and dies."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Death.ID;
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Fear.ID;
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e6df0cbc-a1af-4584-b496-2202c86efc87"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 385
            };
        }
    }
}
