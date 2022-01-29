using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class LongJump : Template
    {
        public static readonly Guid ID = Guid.Parse("1d41d15b-3bf8-4eef-a3f7-22689251aea4");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Long Jump",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("731f2949-8697-46a0-912d-7e30393491a9"), Type = TextBlockType.Text, Text = "You Stride, then make a horizontal Leap and attempt an Athletics check to increase the length of your jump. The DC of the Athletics check is equal to the total distance in feet you're attempting to move during your Leap (so you'd need to succeed at a DC 20 check to Leap 20 feet). You can't Leap farther than your Speed." };
            yield return new TextBlock { Id = Guid.Parse("0e76aaea-53bc-4176-a8c8-715c6cca34f1"), Type = TextBlockType.Text, Text = "If you didn't Stride at least 10 feet, or if you attempt to jump in a different direction than your Stride, you automatically fail your check. This DC might be increased or decreased due to the situation, as determined by the GM." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Athletics.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("8319ba95-fb9d-4e8f-b429-ba96f5cf80dc"),
                CriticalSuccess = "",
                Success = "Increase the maximum horizontal distance you Leap to the desired distance.",
                Failure = "You Leap normally.",
                CriticalFailure = "You Leap normally, but then fall and land prone."
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
                Id = Guid.Parse("67a74da7-4cac-41a8-a520-4b356eb55e29"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 242
            };
        }
    }
}
