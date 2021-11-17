using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SharedNightmare : Template
    {
        public static readonly Guid ID = Guid.Parse("c481cb2f-cd45-4d1c-9088-ecc88e2cdd5d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Shared Nightmare",
                Level = 4,
                Range = "30 feet.",
                Duration = "Varies.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                DomainId = Domains.Instances.Nightmares.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6693f7dd-046e-40b4-a98c-7069b8257cec"), Type = TextBlockType.Text, Text = "Merging minds with the target, you swap disorienting visions from one another’s nightmares. One of you will become confused, but which it’ll be depends on the target’s Will save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("d3c6de44-d9cf-46d1-abc4-589bec0edb75"),
                CriticalSuccess = "You are confused for 1 round.",
                Success = "At the start of your next turn, you spend your first action with the confused condition, then act normally.",
                Failure = "As success, but the target is affected instead of you, spending its first action each turn confused. The duration is 1 minute.",
                CriticalFailure = "The target is confused for 1 minute."
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
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Incapacitation.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("31d20aac-5a9b-42cf-8483-3d40e10402b9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 396
            };
        }
    }
}
