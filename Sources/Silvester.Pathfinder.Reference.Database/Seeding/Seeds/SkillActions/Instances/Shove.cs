using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class Shove : Template
    {
        public static readonly Guid ID = Guid.Parse("5665615c-60aa-466b-bf98-2fc760b87792");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Shove",
                Requirements = "You have at least one hand free. The target can�t be more than one size larger than you.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("866acb2d-343d-427f-aee5-4359e2066e52"), Type = TextBlockType.Text, Text = "You push a creature away from you. Attempt an Athletics check against your target�s Fortitude DC." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Athletics.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Attack.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("96be6540-8765-4fd7-a186-6472a85f3fc7"),
                CriticalSuccess = "You push your target up to 10 feet away from you. You can Stride after it, but you must move the same distance and in the same direction.",
                Success = "You push your target back 5 feet. You can Stride after it, but you must move the same distance and in the same direction.",
                CriticalFailure = "You lose your balance, fall, and land prone."
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
                Id = Guid.Parse("50fb4c31-d7da-4b9f-8824-26a0e8f553b4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 243
            };
        }
    }
}
