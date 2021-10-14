using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class Demoralize : Template
    {
        public static readonly Guid ID = Guid.Parse("37e8b98b-1aa2-4017-b974-714617acfd73");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Demoralize",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ceba4d79-1831-444a-9218-3f892921b141"), Type = TextBlockType.Text, Text = "With a sudden shout, a well-timed taunt, or a cutting putdown, you can shake an enemy�s resolve. Choose a creature within 30 feet of you who you�re aware of. Attempt an Intimidation check against that target�s Will DC. If the target does not understand the language you are speaking, or you�re not speaking a language, you take a �4 circumstance penalty to the check. Regardless of your result, the target is temporarily immune to your attempts to Demoralize it for 10 minutes." };
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
            yield return Traits.Instances.Fear.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("86185f56-69a7-434e-9804-43a4e4934217"),
                CriticalSuccess = "The target becomes frightened 2.",
                Success = "The target becomes frightened 1.",
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
                Id = Guid.Parse("68ba59ca-66bf-426f-9c43-38ff98e6b082"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 247
            };
        }
    }
}
