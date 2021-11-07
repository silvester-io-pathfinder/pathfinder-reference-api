using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SchoolOfPerfectionUnbreakingWaves : Template
    {
        public static readonly Guid ID = Guid.Parse("fd4374e1-d2f7-4d0c-b40d-b68ca56f5d56");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "School of Perfection - Unbreaking Waves",
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
            yield return new TextBlock { Id = Guid.Parse("1febed74-a10c-44f4-8896-a76b7fbe961d"), Type = TextBlockType.Text, Text = "You gain the (spell: unbreaking wave advance) ki spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d8456d09-fe7d-4877-ba70-72e24a25618e"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
