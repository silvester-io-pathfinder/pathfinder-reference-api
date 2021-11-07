using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GracefulPoise : Template
    {
        public static readonly Guid ID = Guid.Parse("d53fc4b6-7eba-487a-b753-1118f47684cc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Graceful Poise",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("59e305ca-54ea-49fb-a554-e17c6d49397f"), Type = TextBlockType.Text, Text = "With the right positioning, your off-hand weapon can strike like a scorpion’s stinger. While you are in this stance, if you make your second (Action: Strike) from (Feat: Double Slice) with an agile weapon, (Feat: Double Slice) counts as one attack when calculating your multiple attack penalty." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fd8d5396-ab92-4789-a994-513abf6e04a5"), Feats.Instances.DoubleSlice.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e3b7372c-e13c-4f03-a65b-1247aa7fdd63"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
