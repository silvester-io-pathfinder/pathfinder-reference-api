using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnderwaterVolcano : Template
    {
        public static readonly Guid ID = Guid.Parse("17c78e28-4b85-4f49-9cc3-9a400e70c2cd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Underwater Volcano",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("27dae1b4-c997-40e6-9d46-dea9bc444269"), Type = TextBlockType.Text, Text = "You can cast (spell: volcanic eruption) as a 7th-level primal innate spell once per day, except that you can only evoke the volcano on the floor of a body of water, and the effects that normally happen to flying creatures happen to swimming creatures instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ab659d78-7168-4fc7-bc26-b0c70faaeb8e"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
