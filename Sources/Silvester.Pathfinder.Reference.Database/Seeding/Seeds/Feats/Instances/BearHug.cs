using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BearHug : Template
    {
        public static readonly Guid ID = Guid.Parse("47c22b11-1f2b-4d9f-8fc2-61476a38fd95");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bear Hug",
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
            yield return new TextBlock { Id = Guid.Parse("facdeafb-a4fa-41be-a28d-85711460299a"), Type = TextBlockType.Text, Text = "The bear makes another claw (action: Strike) against the same target. If this (action: Strike) hits, the target is also grabbed, as if the bear had successfully (action: Grappled | Grapple) the target." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bfc4a8a8-3d48-40b0-b3ec-13e391af0cbc"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
