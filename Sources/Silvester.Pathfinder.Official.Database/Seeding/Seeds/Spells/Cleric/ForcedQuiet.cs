using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ForcedQuiet : Template
    {
        public static readonly Guid ID = Guid.Parse("0c342b5d-8f99-466b-8f45-dc92f0c539cd");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Forced Quiet",
                Level = 1,
                Range = "30 feet.",
                Duration = "Varies.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                DomainId = Domains.Instances.Secrecy.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2e12497d-6af4-4ff1-8c63-41d67b86579d"), Type = TextBlockType.Text, Text = "You quiet the target’s voice, preventing it from giving away valuable secrets. This doesn’t prevent the target from talking or providing verbal spell components, but no creature more than 10 feet away can hear its whispers without succeeding at a Perception check against your spell DC, which might interfere with auditory or linguistic effects as well as communication. The spell’s duration depends on the target’s Fortitude save. After attempting its save, the target becomes temporarily immune for 24 hours." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("3065599c-d572-4c62-9730-7c46227fd207"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The duration is 1 round.",
                Failure = "The duration is 1 minute.",
                CriticalFailure = "The duration is 10 minutes."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Cleric.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("09baa449-7e54-406d-87bd-917f9c4835f6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 393
            };
        }
    }
}
