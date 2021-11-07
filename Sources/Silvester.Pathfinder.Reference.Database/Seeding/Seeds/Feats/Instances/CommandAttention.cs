using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CommandAttention : Template
    {
        public static readonly Guid ID = Guid.Parse("3f15974f-feb3-4ff3-9919-bf042224fc22");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Command Attention",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("eee18fdd-a65d-4055-82ca-c22c3f495a37"), Type = TextBlockType.Text, Text = "You command the attention of all around you with style, ensuring their gaze falls only upon you until the end of your next turn. When creatures within 30 feet of you attempt saving throws against other (trait: visual) effects, they use the outcome for one degree of success better than the result they rolled. An enemy within the area attempting to use a (trait: visual) effect that involves focusing its attention on a particular creature (such as a medusa’s Focus Gaze) must succeed at a Will save against your class DC or spell DC, whichever is higher, in order to target any creature except you. Allies in the area can attempt to (action: Hide) even if they don’t have cover, as you are continually providing a distraction." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7ee3137b-4773-4fec-b1a8-b82459b889df"), Feats.Instances.CelebrityDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2b0e0cda-d3ad-48f3-8a4b-47b5abfd1b5b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
