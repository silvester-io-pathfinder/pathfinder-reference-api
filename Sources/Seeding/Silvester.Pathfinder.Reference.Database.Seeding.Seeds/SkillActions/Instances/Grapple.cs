using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class Grapple : Template
    {
        public static readonly Guid ID = Guid.Parse("aea32876-55d0-41da-9264-a2cbafb7e5a2");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Grapple",
                Requirements = "You have at least one free hand or have your target grappled or restrained. Your target isn�t more than one size larger than you.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("8791ac0c-e1a9-4887-ada4-8ff989edf2af"), Type = TextBlockType.Text, Text = "You attempt to grab a creature or object with your free hand. Attempt an Athletics check against the target�s Fortitude DC. You can Grapple a target you already have grabbed or restrained without having a hand free." };
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
                Id = Guid.Parse("aefcfd4d-5fbe-49c3-8b37-1b585a7a74f4"),
                CriticalSuccess = "Your target is restrained until the end of your next turn unless you move or your target Escapes (page 470).",
                Success = "Your target is grabbed until the end of your next turn unless you move or your target Escapes.",
                Failure = "You fail to grab your target. If you already had the target grabbed or restrained using a Grapple, those conditions on that creature or object end.",
                CriticalFailure = "If you already had the target grabbed or restrained, it breaks free. Your target can either grab you, as if it succeeded at using the Grapple action against you, or force you to fall and land prone."
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
                Id = Guid.Parse("78de8d79-283d-4de8-9857-b226c633f829"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 242
            };
        }
    }
}
