using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HydraulicDeflection : Template
    {
        public static readonly Guid ID = Guid.Parse("80855e27-c188-4b5b-882b-38ec340a4ba4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hydraulic Deflection",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("11cbb372-4d73-45ba-91fb-8995a6c78401"), Type = TextBlockType.Text, Text = "Drawing moisture from the atmosphere, you create a disc of hovering water that deflects attacks. You gain a +1 circumstance bonus to AC until the start of your next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ef67f049-2e53-40b1-bc47-93f3e71062ef"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
