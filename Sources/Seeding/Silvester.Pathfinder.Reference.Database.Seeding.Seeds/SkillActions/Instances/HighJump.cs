using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class HighJump : Template
    {
        public static readonly Guid ID = Guid.Parse("c5a53f6c-0c4b-4ef1-a45b-f690c5f2af83");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "High Jump",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("e6b3f950-1b44-4a21-8039-31dfc257e65f"), Type = TextBlockType.Text, Text = "You Stride, then make a vertical Leap and attempt a DC 30 Athletics check to increase the height of your jump. If you didn�t Stride at least 10 feet, you automatically fail your check. This DC might be increased or decreased due to the situation, as determined by the GM." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Athletics.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("cc70dd6d-9d5c-4876-a18b-53a76dd3d850"),
                CriticalSuccess = "Increase the maximum vertical distance to 8 feet, or increase the maximum vertical distance to 5 feet and maximum horizontal distance to 10 feet.",
                Success = "Increase the maximum vertical distance to 5 feet.",
                Failure = "You Leap normally.",
                CriticalFailure = "You don�t Leap at all, and instead you fall prone in your space."
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
                Id = Guid.Parse("6fbd726b-8a96-4858-b907-b513f18fb9cc"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 242
            };
        }
    }
}
