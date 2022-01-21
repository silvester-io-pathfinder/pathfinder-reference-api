using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScareToDeath : Template
    {
        public static readonly Guid ID = Guid.Parse("c50f91ff-bf23-4611-a8e8-4ced5b1e9435");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scare to Death",
                Level = 15,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2e5ed718-d258-4ba5-a3ca-d17821247596"), Type = TextBlockType.Text, Text = "You can frighten foes so much, they might die. Attempt an Intimidation check against the Will DC of a living creature within 30 feet of you that you sense or observe and who can sense or observe you. If the target can't hear you or doesn't understand the language you are speaking, you take a -4 circumstance penalty. The creature is temporarily immune for 1 minute." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("c11089a0-cc6e-4619-ac66-c11974ab9034"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Intimidation.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("5b9cbc70-495d-4fdf-aa1c-41d7e4f4b103"),
                CriticalSuccess = "The target must succeed at a Fortitude save against your Intimidation DC or die. If the target succeeds at its save, it becomes frightened 2 and is fleeing for 1 round; it suffers no effect on a critical success.",
                Success = "The target becomes frightened 2.",
                Failure = "The target becomes frightened 1.",
                CriticalFailure = "The target is unaffected.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eea4e483-2e73-405a-b375-8e3deaf605a6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
