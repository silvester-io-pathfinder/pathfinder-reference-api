using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Earthsense : Template
    {
        public static readonly Guid ID = Guid.Parse("8958dd65-4e12-401e-9068-b85e219ee15f");

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
            yield return new TextBlock { Id = Guid.Parse("acbe2419-5966-4696-a13b-ce63badce965"), Type = TextBlockType.Text, Text = $"Your connection to earth and stone allows you to feel the slightest displacement that disturbs them, down to the shift of a pebble. You gain tremorsense as an imprecise sense with a range of 30 feet." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c1a87848-1069-4014-a54c-6c7e23cd0382"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
