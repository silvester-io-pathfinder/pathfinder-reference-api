using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AmorphousAspect : Template
    {
        public static readonly Guid ID = Guid.Parse("20e483c3-deb8-4194-96b1-180e568185b4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Amorphous Aspect",
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
            yield return new TextBlock { Id = Guid.Parse("dffe3e6e-0e8b-48c8-a117-39564acf413d"), Type = TextBlockType.Text, Text = "Your body is supremely flexible. You gain a +1 circumstance bonus on checks to (action: Escape) or (action: Squeeze), and when you critically fail when (action: Squeezing | Squeeze), you get a failure instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("edcf841a-f90b-48b1-a429-6f834b96c092"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
