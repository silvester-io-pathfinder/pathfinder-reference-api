using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NestlingFall : Template
    {
        public static readonly Guid ID = Guid.Parse("9f2d90b2-4339-43db-829f-aff120b710ad");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Nestling Fall",
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
            yield return new TextBlock { Id = Guid.Parse("d6f4f283-e410-4d06-a68b-8e6ac881f230"), Type = TextBlockType.Text, Text = "You trust the strength of your wings and can spread them to glide safely to the ground. As long as you can act, you take no damage from falling, no matter what distance you fall." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("69b6c109-c9ea-4b7a-8884-c5990322a2bf"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
