using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShaitanSkin : Template
    {
        public static readonly Guid ID = Guid.Parse("2a15b02b-34b9-4228-8512-17bbe0a0aaae");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shaitan Skin",
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
            yield return new TextBlock { Id = Guid.Parse("34c56c0f-36d5-4a89-ac2d-d653ca88cdc4"), Type = TextBlockType.Text, Text = "When in danger, you can harden the stone in your skin into armor, much like a shaitan. You can cast (spell: stoneskin) on yourself only, 3 times per day as a 4th-level arcane innate spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4a147d30-ae8d-443b-8448-ce9225e2fd7f"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
