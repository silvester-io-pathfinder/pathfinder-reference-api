using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CommandAttention : Template
    {
        public static readonly Guid ID = Guid.Parse("3fd22e34-cb83-49e8-a579-dc293b727a57");

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
            yield return new TextBlock { Id = Guid.Parse("09915910-99a5-4ef2-b91c-42943c75ddce"), Type = TextBlockType.Text, Text = "You command the attention of all around you with style, ensuring their gaze falls only upon you until the end of your next turn. When creatures within 30 feet of you attempt saving throws against other (trait: visual) effects, they use the outcome for one degree of success better than the result they rolled. An enemy within the area attempting to use a (trait: visual) effect that involves focusing its attention on a particular creature (such as a medusa’s Focus Gaze) must succeed at a Will save against your class DC or spell DC, whichever is higher, in order to target any creature except you. Allies in the area can attempt to (action: Hide) even if they don’t have cover, as you are continually providing a distraction." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cf36df19-844e-4c08-82e7-e0fa6b60eb41"), Feats.Instances.CelebrityDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("573ee519-a54b-4ec5-89ed-57527671a7e0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
