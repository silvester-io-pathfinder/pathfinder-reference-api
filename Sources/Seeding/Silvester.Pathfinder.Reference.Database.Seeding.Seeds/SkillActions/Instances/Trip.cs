using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class Trip : Template
    {
        public static readonly Guid ID = Guid.Parse("76afb5e6-94dd-4593-a1e9-e3365f12ac22");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Trip",
                Requirements = "You have at least one hand free. Your target can't be more than one size larger than you.",
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("0af29030-e86b-45e9-83b0-9d12883609dd"), Type = TextBlockType.Text, Text = "You try to knock a creature to the ground. Attempt an Athletics check against the target's Reflex DC." };
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
                Id = Guid.Parse("b41e6397-5497-44a5-a346-d81c18bae87f"),
                CriticalSuccess = "The target falls and lands prone and takes 1d6 bludgeoning damage.",
                Success = "The target falls and lands prone.",
                CriticalFailure = "You lose your balance and fall and land prone."
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
                Id = Guid.Parse("ed0729fd-fa45-452c-9705-2913c0f364af"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 243
            };
        }
    }
}
