using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CatPounce : Template
    {
        public static readonly Guid ID = Guid.Parse("c3239f01-866d-47dd-9566-932ac22c9733");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cat Pounce",
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
            yield return new TextBlock { Id = Guid.Parse("286bb4f9-2730-47c1-a5e5-c050e7ad5873"), Type = TextBlockType.Text, Text = "The cat (action: Strides | Stride) and then (action: Strikes | Strike). If it was undetected at the start of its Cat Pounce, it remains undetected until after the attack." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("93e2b2e2-70ea-4ec5-beab-7ea538b1f003"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
