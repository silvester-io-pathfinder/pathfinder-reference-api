using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class Coerce : Template
    {
        public static readonly Guid ID = Guid.Parse("687bfc2c-126a-44c3-a80b-b810127db81c");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Coerce",
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("586c2374-429a-480d-8290-43c45e386dfb"), Type = TextBlockType.Text, Text = "With threats either veiled or overt, you attempt to bully a creature into doing what you want. You must spend at least 1 minute of conversation with a creature you can see and that can either see or sense you. At the end of the conversation, attempt an Intimidation check against the target's Will DC, modified by any circumstances the GM determines. The attitudes referenced in the effects below are summarized in the Changing Attitudes sidebar on page 246 and described in full in the Conditions Appendix, starting on page 618." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Intimidation.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Auditory.ID;
            yield return Traits.Instances.Concentrate.ID;
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Exploration.ID;
            yield return Traits.Instances.Linguistic.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("f726f588-62ea-4402-8f36-77b9a43272a4"),
                CriticalSuccess = "The target gives you the information you seek or agrees to follow your directives so long as they aren't likely to harm the target in any way. The target continues to comply for an amount of time determined by the GM but not exceeding 1 day, at which point the target becomes unfriendly (if they weren't already unfriendly or hostile). However, the target is too scared of you to retaliate - at least in the short term.",
                Success = "As critical success, but once the target becomes unfriendly, they might decide to act against you - for example, by reporting you to the authorities or assisting your enemies.",
                Failure = "The target doesn't do what you say, and if they were not already unfriendly or hostile, they become unfriendly.",
                CriticalFailure = "The target refuses to comply, becomes hostile if they weren't already, and can't be Coerced by you for at least 1 week."
            };
        }

        protected override IEnumerable<Guid> GetRequiredPlayModes()
        {
            yield return PlayModes.Instances.Exploration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c03d0d60-fe8e-4bb4-9ee1-2ed0e1f7e2d7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 247
            };
        }
    }
}
