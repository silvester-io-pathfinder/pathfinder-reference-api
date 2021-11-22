using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MesmerizingPerformance : Template
    {
        public static readonly Guid ID = Guid.Parse("271dbd98-14a3-4b30-8619-206d2bc573d4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mesmerizing Performance",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0bde6110-70db-40a9-ab93-992ec1671b62"), Type = TextBlockType.Text, Text = "The companion maintains its performance to captivate a single target within 30 feet that witnessed its successful performance. The target must attempt a Will save." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("93944578-6d9f-4800-b212-1a6c232d379d"),
                
                Success = "The target is unaffected and is temporarily immune for 1 hour.",
                Failure = "The target is fascinated by the companion for its next action and then is temporarily immune for 1 hour.",
                CriticalFailure = "The target is fascinated by the companion for 1 round. While it remains fascinated, it can't use reactions.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1615231f-e604-4e69-8e11-ce5b294902a0"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
