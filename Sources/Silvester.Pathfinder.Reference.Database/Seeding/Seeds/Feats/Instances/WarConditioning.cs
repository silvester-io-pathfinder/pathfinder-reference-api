using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WarConditioning : Template
    {
        public static readonly Guid ID = Guid.Parse("5d396fd7-2f46-4ff3-824c-9fad1a7060a8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "War Conditioning",
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
            yield return new TextBlock { Id = Guid.Parse("9fcfab06-312e-4d50-aafd-b4c484e5fe78"), Type = TextBlockType.Text, Text = "You have extensive training in remote environments, allowing you to move through these areas easily. When you gain this feat, you can choose to gain either a climb Speed of 20 feet or a swim Speed of 20 feet." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("31c1c9a1-d675-4d3c-a8c5-a21f63afb9a6"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
