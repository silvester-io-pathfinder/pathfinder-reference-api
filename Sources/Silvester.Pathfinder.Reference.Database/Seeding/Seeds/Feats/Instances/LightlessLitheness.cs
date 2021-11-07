using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LightlessLitheness : Template
    {
        public static readonly Guid ID = Guid.Parse("8c558d77-5cc8-4d65-8c0f-cecff728028c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lightless Litheness",
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
            yield return new TextBlock { Id = Guid.Parse("d5f70412-c551-4a26-b08b-9ee40a49615f"), Type = TextBlockType.Text, Text = "Your body is almost as flexible as your shadow. When you critically fail at (action: Squeezing | Squeeze), you get a failure instead. Additionally, when you roll a success at an (action: Escape) check, you get a critical success instead; if you roll a critical success, you can (action: Step) instead of (action: Striding | Stride) up to 5 feet." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("03d89ef6-b40e-4b46-a269-d5d7f31a8336"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
