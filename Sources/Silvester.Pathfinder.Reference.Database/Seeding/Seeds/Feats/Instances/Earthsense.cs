using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Earthsense : Template
    {
        public static readonly Guid ID = Guid.Parse("96158842-498d-42fc-aa4d-735da5781cdf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Earthsense",
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
            yield return new TextBlock { Id = Guid.Parse("d8338d88-9b13-4038-95be-c5918406953b"), Type = TextBlockType.Text, Text = "Your connection to earth and stone allows you to feel the slightest displacement that disturbs them, down to the shift of a pebble. You gain tremorsense as an imprecise sense with a range of 30 feet." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ecaef432-4f0c-41f3-a52b-f01bf956619d"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
