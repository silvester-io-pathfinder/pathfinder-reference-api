using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TranslucentSkin : Template
    {
        public static readonly Guid ID = Guid.Parse("bb2cfc74-5259-4c36-90ce-6d3bf496d475");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Translucent Skin",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c0b306c3-297e-46ee-8f4c-46aab49fa75d"), Type = TextBlockType.Text, Text = "Your body is translucent while underwater. Whenever you are fully submerged in water, you can (action: Hide) from other creatures even if you don’t have cover against them and aren’t concealed from them." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("03b59370-1dc6-4049-a570-1214e5fd6d13"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
