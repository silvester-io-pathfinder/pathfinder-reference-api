using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NestlingFall : Template
    {
        public static readonly Guid ID = Guid.Parse("a606cf37-4896-4e2d-bdd5-5443024fd28f");

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
            yield return new TextBlock { Id = Guid.Parse("79cb485e-5739-403a-92f3-7713cebbd527"), Type = TextBlockType.Text, Text = "You trust the strength of your wings and can spread them to glide safely to the ground. As long as you can act, you take no damage from falling, no matter what distance you fall." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("89ebff31-44e9-41ed-9889-4ef745cb9525"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}