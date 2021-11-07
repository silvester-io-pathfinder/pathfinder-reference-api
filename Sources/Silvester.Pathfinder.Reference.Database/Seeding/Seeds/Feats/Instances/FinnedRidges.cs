using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FinnedRidges : Template
    {
        public static readonly Guid ID = Guid.Parse("66927003-2291-4c86-a9f8-b8a9a5cba507");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Finned Ridges",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("211373b5-1168-41ae-85bf-36c95c2dae0d"), Type = TextBlockType.Text, Text = "The ridges and flaps of your skin steer you through the water. You gain a swim Speed of 15 feet." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7f3a59d6-c203-4f7a-b9fe-d9e5f953e231"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
