using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class Squeeze : Template
    {
        public static readonly Guid ID = Guid.Parse("31108045-fae8-41f9-8459-a5f940b087e6");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Squeeze",
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("dab011df-c68d-4942-803e-81a25a3827d5"), Type = TextBlockType.Text, Text = "You contort yourself to squeeze through a space so small you can barely fit through. This action is for exceptionally small spaces; many tight spaces are difficult terrain (page 475) that you can move through more quickly and without a check." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Acrobatics.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Exploration.ID;
            yield return Traits.Instances.Move.ID;
        }

        protected override IEnumerable<Guid> GetRequiredPlayModes()
        {
            yield return PlayModes.Instances.Exploration.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("5d9dde1e-bfca-46c3-ad73-0823c5925356"),
                CriticalSuccess = "You squeeze through the tight space in 1 minute per 10 feet of squeezing.",
                Success = "You squeeze through in 1 minute per 5 feet.",
                CriticalFailure = "You become stuck in the tight space. While you�re stuck, you can spend 1 minute attempting another Acrobatics check at the same DC. Any result on that check other than a critical failure causes you to become unstuck."
            };
        }

        protected override IEnumerable<SkillActionExample> GetExamples()
        {
            yield return new SkillActionExample { Id = Guid.Parse("8e813486-5001-40bb-a1f9-40fd67372479"), ProficiencyId = Proficiencies.Instances.Trained.ID, Description = "Space barely fitting your shoulders." };
            yield return new SkillActionExample { Id = Guid.Parse("444e2af1-35d6-4b21-9a72-d5e2ce03460d"), ProficiencyId = Proficiencies.Instances.Master.ID, Description = "Space barely fitting your head." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("09a7486a-6104-4742-95f8-00c5d9fea27a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 241
            };
        }
    }
}
