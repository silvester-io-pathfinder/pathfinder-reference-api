using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class MindProbe : Template
    {
        public static readonly Guid ID = Guid.Parse("50520c01-24e6-4434-a687-b324bcd0fe85");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Mind Probe",
                Level = 5,
                CastTime = "1 minute.",
                Range = "30 feet.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a29583ec-df58-41df-89c6-504f078012e3"), Type = TextBlockType.Text, Text = "You cast your thoughts through a creature's mind, sifting for information. You access the target's memories and knowledge unless it fends you off with a Will save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("8fee38a9-d7b7-4ee7-8a84-975c797b5fc7"),
                Success = "The target is unaffected.",
                Failure = "Each round of the spell's duration, you can Sustain the Spell to ask a different question and attempt to uncover the answer. For each question, the target can attempt a Deception check against your spell DC; if the target succeeds, you don't learn the answer, and on a critical success, the target gives you a false answer that you believe is truthful Once you've asked the target a given question, asking it again, even with a separate casting of mind probe, produces the same result.",
                CriticalFailure = "As failure, and the target takes a –4 circumstance penalty to Deception checks against your questions."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
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
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Linguistic.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cb7ca411-066e-4fa7-b1e6-356938da4f6d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 351
            };
        }
    }
}
