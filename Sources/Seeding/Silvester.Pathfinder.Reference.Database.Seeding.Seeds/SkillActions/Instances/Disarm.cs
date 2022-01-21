using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class Disarm : Template
    {
        public static readonly Guid ID = Guid.Parse("bf30c154-cfc4-4b66-8fb1-71c6bfe0555d");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Disarm",
                Requirements = "You have at least one hand free. The target can�t be more than one size larger than you.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("e92bfc31-7789-48f6-8faf-e73265c89a76"), Type = TextBlockType.Text, Text = "You try to knock something out of a creature�s grasp. Attempt an Athletics check against the target�s Reflex DC." };
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
                Id = Guid.Parse("c8bae780-3fe6-4c61-8c7d-33fbb948ccb7"),
                CriticalSuccess = "You knock the item out of the target�s grasp. It falls to the ground in the target�s space.",
                Success = "You weaken your target�s grasp on the item. Until the start of that creature�s turn, attempts to Disarm the target of that item gain a +2 circumstance bonus, and the target takes a �2 circumstance penalty to attacks with the item or other checks requiring a firm grasp on the item.",
                CriticalFailure = "You lose your balance and become flat-footed until the start of your next turn."
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
                Id = Guid.Parse("1e69b94c-4adb-4579-a6cf-019446aa2a53"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 243
            };
        }
    }
}
