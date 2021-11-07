using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HeadStomp : Template
    {
        public static readonly Guid ID = Guid.Parse("38d7cafb-d58f-41b8-90f7-d82a6de9f54f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Head Stomp",
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
            yield return new TextBlock { Id = Guid.Parse("dfbcca74-6cfb-493c-b1fe-0590b99443c1"), Type = TextBlockType.Text, Text = "Make an unarmed melee attack against a prone target. On a hit, the target becomes flat-footed to all attacks until the end of your next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("79b0bd4c-31bf-479e-a8e0-dce5e48a678b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
