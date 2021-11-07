using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SchoolOfPerfectionUnfoldingWind : Template
    {
        public static readonly Guid ID = Guid.Parse("a7d96eae-4e94-4ce6-952b-e25f6d33c4eb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "School of Perfection - Unfolding Wind",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a4ebb886-64c8-44d0-a9c5-6f16c8b02b39"), Type = TextBlockType.Text, Text = "You gain the (spell: unfolding wind rush) ki spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3d752a80-cb98-4654-b5a3-5f2d564b19d4"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
