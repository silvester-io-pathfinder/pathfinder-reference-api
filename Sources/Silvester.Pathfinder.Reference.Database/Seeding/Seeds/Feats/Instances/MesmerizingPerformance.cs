using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MesmerizingPerformance : Template
    {
        public static readonly Guid ID = Guid.Parse("8e4dbc4f-e63f-4e08-a78d-a19339ebfaa9");

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
            yield return new TextBlock { Id = Guid.Parse("a106c0a6-06b3-484f-b934-4ab392cf5de2"), Type = TextBlockType.Text, Text = "The companion maintains its performance to captivate a single target within 30 feet that witnessed its successful performance. The target must attempt a Will save." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("86773c15-78b6-45fc-a25a-4d3fcff39492"),
                
                Success = "The target is unaffected and is temporarily immune for 1 hour.",
                Failure = "The target is fascinated by the companion for its next action and then is temporarily immune for 1 hour.",
                CriticalFailure = "The target is fascinated by the companion for 1 round. While it remains fascinated, it can’t use reactions.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5f14143f-1abf-49b5-b07e-cef23523b7db"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
