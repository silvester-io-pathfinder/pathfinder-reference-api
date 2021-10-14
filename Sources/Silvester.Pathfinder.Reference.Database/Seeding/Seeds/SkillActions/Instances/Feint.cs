using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class Feint : Template
    {
        public static readonly Guid ID = Guid.Parse("3dd822a8-2aab-4db5-a92d-a0bc3d19c3c9");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Feint",
                Requirements = "You are within melee reach of the target you attempt to Feint.",
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("0b7e9637-eabc-4d19-9e08-1bc81eed323c"), Type = TextBlockType.Text, Text = "With a misleading flourish, you leave an opponent unprepared for your real attack. Attempt a Deception check against your target�s Perception DC." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Deception.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Mental.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("1cf74d47-1673-41cc-920c-20b1e7923fdd"),
                CriticalSuccess = "You throw your enemy�s defenses against you entirely off. The target is flat-footed against melee attacks that you attempt against it until the end of your next turn.",
                Success = "Your foe is fooled, but only momentarily. The target is flat-footed against the next melee attack that you attempt against it before the end of your current turn.",
                CriticalFailure = "Your feint backfires. You are flat-footed against melee attacks the target attempts against you until the end of your next turn."
            };
        }

        protected override IEnumerable<Guid> GetRequiredPlayModes()
        {
            yield return PlayModes.Instances.Encounter.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f12e69a9-02a1-4257-bf17-08d4390c8274"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 246
            };
        }
    }
}
