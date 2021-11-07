using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class Request : Template
    {
        public static readonly Guid ID = Guid.Parse("0a106f6c-5b51-45f1-9ec2-655b576f5b6e");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Request",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("dfe01dbb-2b9a-42f1-b334-a1a07c99f867"), Type = TextBlockType.Text, Text = "You can make a request of a creature that�s friendly or helpful to you. You must couch the request in terms that the target would accept given their current attitude toward you. The GM sets the DC based on the difficulty of the request. Some requests are unsavory or impossible, and even a helpful NPC would never agree to them." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Diplomacy.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Auditory.ID;
            yield return Traits.Instances.Concentrate.ID;
            yield return Traits.Instances.Linguistic.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("0963b259-94d4-4042-ab80-be5411263871"),
                CriticalSuccess = "The target agrees to your request without qualifications.",
                Success = "The target agrees to your request, but they might demand added provisions or alterations to the request.",
                Failure = "The target refuses the request, though they might propose an alternative that is less extreme.",
                CriticalFailure = "Not only does the target refuse the request, but their attitude toward you decreases by one step due to the temerity of the request."
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
                Id = Guid.Parse("b2b0ad9d-9103-4392-b69d-05ddca7c9a0d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 247
            };
        }
    }
}
