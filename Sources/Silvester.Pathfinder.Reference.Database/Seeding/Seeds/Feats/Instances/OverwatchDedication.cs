using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OverwatchDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("5d5e27bf-8a2b-4876-a41c-acfa63c987d0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Overwatch Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until after you have gained at least two other feats from the overwatch archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("362aeed1-1be0-4047-a268-4c8a93c15746"), Type = TextBlockType.Text, Text = "You have an innate knack for tactical observation, and you’ve innovated to apply that knack in a variety of ways that allow you to assist your allies. With the help of enhanced visual gear (such as a specially modified telescope, goggled visor, or binoculars), you’re keenly aware of the movement of combatants on the battlefield. You quickly and efficiently disperse that information to your nearby allies so they can use it to direct their own observations and reactions to danger." };
            yield return new TextBlock { Id = Guid.Parse("3ab1c376-7be8-46be-8733-7099160b7b8d"), Type = TextBlockType.Text, Text = "You’re surrounded by an overwatch field aura in a 30-foot emanation. Your overwatch field aura grants you increased perception and allows you to call out warnings to your allies within the aura to point out threats. This aura has the (trait: auditory) and (trait: visual) traits. You and allies within your overwatch field receive a +2 circumstance bonus when using Perception for Initiative checks." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("b853f8be-9346-4f67-bf24-1db5da3f811d"), Proficiencies.Instances.Expert.ID, Skills.Instances.Perception.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("03a6d500-5c8c-423f-b7ed-e69e3f92f0a0"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
