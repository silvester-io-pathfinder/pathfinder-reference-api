using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class CommandAnAnimal : Template
    {
        public static readonly Guid ID = Guid.Parse("81b9ac82-841b-4c60-ad86-30cff57ec296");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Command an Animal",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("67c326f8-6f29-4789-a952-e8f9bb77ca26"), Type = TextBlockType.Text, Text = "You issue an order to an animal. Attempt a Nature check against the animal�s Will DC. The GM might adjust the DC if the animal has a good attitude toward you, you suggest a course of action it was predisposed toward, or you offer it a treat." };
            yield return new TextBlock { Id = Guid.Parse("8933dce8-95c7-431f-ab2c-78371e31e273"), Type = TextBlockType.Text, Text = "You automatically fail if the animal is hostile or unfriendly to you. If the animal is helpful to you, increase your degree of success by one step. You might be able to Command an Animal more easily with a feat like Ride (page 266)." };
            yield return new TextBlock { Id = Guid.Parse("8caa392d-867d-491b-aa02-7076130342b5"), Type = TextBlockType.Text, Text = "Most animals know the Drop Prone, Leap, Seek, Stand, Stride, and Strike basic actions. If an animal knows an activity, such as a horse�s Gallop, you can Command the Animal to perform the activity, but you must spend as many actions on Command an Animal as the activity�s number of actions. You can also spend multiple actions to Command the Animal to perform that number of basic actions on its next turn; for instance, you could spend 3 actions to Command an Animal to Stride three times or to Stride twice and then Strike." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Nature.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Auditory.ID;
            yield return Traits.Instances.Concentrate.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("c065ddae-172f-4529-9fd8-c8363b79e23d"),
                Success = "The animal does as you command on its next turn.",
                Failure = "The animal is hesitant or resistant, and it does nothing.",
                CriticalFailure = "The animal misbehaves or misunderstands, and it takes some other action determined by the GM."
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
                Id = Guid.Parse("5bf2a1e3-ee5e-4dcb-9abe-7c4b3fd21b22"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 249
            };
        }
    }
}
