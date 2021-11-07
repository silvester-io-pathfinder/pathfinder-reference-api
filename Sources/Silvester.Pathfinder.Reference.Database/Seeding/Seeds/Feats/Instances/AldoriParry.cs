using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AldoriParry : Template
    {
        public static readonly Guid ID = Guid.Parse("a4905d20-7e50-41e4-96b0-b3eedf24b646");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Aldori Parry",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("753fe737-4a5b-4f25-b179-b91bd38d0625"), Type = TextBlockType.Text, Text = "You can parry attacks against you with your Aldori dueling sword. You gain a +2 circumstance bonus to AC until the start of your next turn as long as you continue to meet the requirement." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e717ac71-efea-4ed2-84ae-c18db96ab57e"), Feats.Instances.AldoriDuelistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a4a4afa5-4875-4081-8751-afeb5bfae420"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
