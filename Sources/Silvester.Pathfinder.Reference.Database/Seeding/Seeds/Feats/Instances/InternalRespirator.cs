using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InternalRespirator : Template
    {
        public static readonly Guid ID = Guid.Parse("d0e81238-66dd-475a-b638-3527b6e12d23");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Internal Respirator",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("37546f25-a682-486c-aa5d-50918d0329eb"), Type = TextBlockType.Text, Text = "Your body can internally synthesize oxygen for limited periods of time. When you hold your breath, you can do so for an additional hour due to your internal air reservoirs. At the end of this hour, your air reservoirs are expended. Refilling your empty air reservoirs takes 10 minutes of exposure to breathable air." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("129dc4e2-8a33-4bee-ad31-313766ea697c"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
