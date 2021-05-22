using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DelusionalPride : Template
    {
        public static readonly Guid ID = Guid.Parse("965001ca-132d-4647-94c7-5502677056df");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Delusional Pride",
                Level = 4,
                Range = "30 feet.",
                Duration = "Varies.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                DomainId = Domains.Instances.Confidence.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("08a0579d-e71d-4c5a-a073-c85951ff21d3"), Type = TextBlockType.Text, Text = "You make the target overconfident, leading it to ascribe failure to external factors. If the target fails at an attack roll or skill check, it takes a –1 status penalty to attack rolls and skill checks until the end of its turn (or the end of its next turn, if it attempted the roll outside its turn). If the creature fails a second time while taking this penalty, the penalty increases to –2. The duration depends on the target’s Will save. After attempting its save, the creature becomes temporarily immune for 24 hours." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("1c505e85-bf84-444b-9d12-ed3614ad8745"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The duration is 1 round.",
                Failure = "The duration is 10 minutes.",
                CriticalFailure = "The duration is 24 hours."
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
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("57e129bb-bcde-4ae7-8259-c4e60c28c739"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 391
            };
        }
    }
}
