using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ElasticMutagen : Template
    {
        public static readonly Guid ID = Guid.Parse("a356225d-9d0d-42f1-8c92-8b2465bffa3a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elastic Mutagen",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0718aa3e-8f38-4050-a6fc-bd94e7d69b92"), Type = TextBlockType.Text, Text = "You can cause your body to twist and flow like the quicksilver within your mutagens. Whenever you are under the effects of a quicksilver mutagen, you can stretch your legs and (action: Step) up to 10 feet, and you can squish and compress your body, allowing you to make it through tight spaces as if you were one size smaller, in addition to any effect from (action: Squeezing | Squeeze)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a21f5659-27a8-443b-bbab-48ce64f6d625"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
