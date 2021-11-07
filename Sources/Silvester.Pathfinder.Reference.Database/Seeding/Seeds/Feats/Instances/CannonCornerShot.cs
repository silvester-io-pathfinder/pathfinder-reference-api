using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CannonCornerShot : Template
    {
        public static readonly Guid ID = Guid.Parse("650f6a0b-8c99-42a8-9934-1c1c243f709a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cannon Corner Shot",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("51bfd8c9-7044-456a-b485-a1ef91bb855c"), Type = TextBlockType.Text, Text = "By loading special ammunition in a particular way, you can make your siege weapons do all manner of tricks that other siege engineers can barely even imagine. If you personally contribute an additional Load action to the siege weapon’s loading, above the minimum, you can change a burst into a line twice as long as the size of the burst, or vice versa (so a 10-foot burst turns into a 20-foot line, or a 20-foot line turns into a 10-foot burst)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bb7403a6-e4fb-41e9-8c94-fa87f3b36fbb"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
