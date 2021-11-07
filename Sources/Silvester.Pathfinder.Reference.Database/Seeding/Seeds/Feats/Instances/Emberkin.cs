using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Emberkin : Template
    {
        public static readonly Guid ID = Guid.Parse("23e1fb69-b2d3-43db-b9fe-50d3ac8ad61a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Emberkin",
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
            yield return new TextBlock { Id = Guid.Parse("bdcecbab-c9a6-41ef-8e15-05a9ced8e289"), Type = TextBlockType.Text, Text = "A peri’s roaring spirit burns in your soul. Peris engage in constant struggle to right the wrongs of their fallen forebears, and that struggle has been passed on to you. You have a direct impulse to right wrongs and better the world. You gain a +1 circumstance bonus to saving throws against (trait: fire) effects, and your perception is unaffected by non-magical flames, fog and smoke." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1aae6ddf-42bb-4f47-8eec-19d142a0b766"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
