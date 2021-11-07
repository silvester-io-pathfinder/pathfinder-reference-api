using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CatchyTune : Template
    {
        public static readonly Guid ID = Guid.Parse("d8c681a7-ef00-4cb7-8f10-55ebe91a0525");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Catchy Tune",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5fb0b128-e348-4a7f-894d-be5bc45f7985"), Type = TextBlockType.Text, Text = "You create a tune so catchy, your foes can’t help but dance along. Attempt a Performance check against the Will DCs of all enemies in a 30-foot emanation." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("a48c1ee6-965b-4411-a85f-b6099078deea"),
                CriticalSuccess = "The target takes a -10-foot status penalty to its Speed and is flat-footed, both for 1 round.",
                Success = "The target takes a –5-foot status penalty to its Speed for 1 round.",
                
                CriticalFailure = "The target is temporarily immune for 1 hour.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aac42283-d4db-4717-851b-487c54de58c3"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
