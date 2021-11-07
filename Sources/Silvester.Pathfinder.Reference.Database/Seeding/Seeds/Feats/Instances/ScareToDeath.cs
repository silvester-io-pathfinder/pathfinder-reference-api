using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScareToDeath : Template
    {
        public static readonly Guid ID = Guid.Parse("9737c7ba-aa08-41b8-8780-66a76f2c32ed");

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
            yield return new TextBlock { Id = Guid.Parse("e08d920c-4ed6-49ef-893d-482b6e767b0f"), Type = TextBlockType.Text, Text = "You can frighten foes so much, they might die. Attempt an Intimidation check against the Will DC of a living creature within 30 feet of you that you sense or observe and who can sense or observe you. If the target can’t hear you or doesn’t understand the language you are speaking, you take a -4 circumstance penalty. The creature is temporarily immune for 1 minute." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("23ab1c00-b775-4388-a8fa-a649669a9f52"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Intimidation.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("ac3fc8b1-1d94-4fb8-bcc3-3e9d0c8608b3"),
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
                Id = Guid.Parse("2db92766-fb53-49bb-a55a-c0855d0f2e9a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
