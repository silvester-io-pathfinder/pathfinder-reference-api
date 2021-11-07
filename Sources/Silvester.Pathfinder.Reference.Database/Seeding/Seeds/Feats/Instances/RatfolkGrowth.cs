using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RatfolkGrowth : Template
    {
        public static readonly Guid ID = Guid.Parse("a61e0d22-adda-4481-97aa-b6889bb9580c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ratfolk Growth",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f32787f3-2c37-4453-80de-2c90cd737b0a"), Type = TextBlockType.Text, Text = "You call upon the familial bonds you share with other ysoki to defend them in battle. You can cast (spell: enlarge) as a 6th-level primal innate spell once per day. You can target only yourself and other ratfolk with this spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ce5af802-7605-4d0b-bbb6-149e3165d7d1"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
