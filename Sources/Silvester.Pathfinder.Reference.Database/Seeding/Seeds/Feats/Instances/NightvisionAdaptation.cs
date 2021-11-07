using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NightvisionAdaptation : Template
    {
        public static readonly Guid ID = Guid.Parse("4dcbc32f-1bee-4c42-89aa-62721954c89d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Nightvision Adaptation",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bf08e883-29a5-4b30-8863-23547d9f1d6d"), Type = TextBlockType.Text, Text = "The nanites in your ocular processors have adapted to darkness, enhancing your ability to see in the dark. You gain darkvision." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e9131ac2-7568-4c6d-8f6a-94d38832c2e2"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
