using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GrippingLimbs : Template
    {
        public static readonly Guid ID = Guid.Parse("9f5b4189-6c28-4c55-a46a-417067d38b58");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gripping Limbs",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("83717c6a-8644-4a32-8929-311af7701789"), Type = TextBlockType.Text, Text = "Nodules, hooks, or claws on your limbs allow you to cling to surfaces with ease. You gain a climb Speed of 15 feet." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bca6f1e3-e8d9-40a9-bcbd-029975b8ec0a"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
