using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CatfolkDance : Template
    {
        public static readonly Guid ID = Guid.Parse("3c3d1307-81a7-4390-b837-ddf2e115ff9d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Catfolk Dance",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9757cfaa-8391-4365-94a9-4ee2693b00a1"), Type = TextBlockType.Text, Text = "You have a habit of always being in the way when other creatures attempt to move. Attempt an Acrobatics check against an adjacent creature’s Reflex DC." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("7b379329-3fe2-4a91-8d04-7b709f8628a8"),
                CriticalSuccess = "The target creature gains a –2 circumstance penalty to Reflex saves and is flat-footed until the start of your next turn.",
                Success = "The target creature gains a –2 circumstance penalty to Reflex saves until the start of your next turn.",
                
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3cf1a22c-ab15-4776-9989-e9863f89af1e"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
