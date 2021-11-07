using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ChangeShapeAnadi : Template
    {
        public static readonly Guid ID = Guid.Parse("6b71fb6a-bad7-4888-ad53-1284ee70c236");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Change Shape - Anadi",
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
            yield return new TextBlock { Id = Guid.Parse("4e98baa4-d60d-496d-a1e1-282f120e8025"), Type = TextBlockType.Text, Text = "You change into your human or spider shape. Each shape has a specific, persistent appearance. In your human shape, you can’t use unarmed attacks granted by your ancestry. In your spider shape, you aren’t flat-footed when climbing, but you can’t use weapons, shields, or other held items of any sort nor can you take any action that has the (trait: manipulate) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a44e6ae3-21b1-4301-87d1-02f95450fb3e"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
