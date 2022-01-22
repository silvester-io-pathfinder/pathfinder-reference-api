using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HydraulicDeflection : Template
    {
        public static readonly Guid ID = Guid.Parse("e5e1da5e-bcb3-46d5-9b0a-e39985a97a90");

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
            yield return new TextBlock { Id = Guid.Parse("82e38892-bb40-452a-91a7-533c1cf26a42"), Type = TextBlockType.Text, Text = $"Drawing moisture from the atmosphere, you create a disc of hovering water that deflects attacks. You gain a +1 circumstance bonus to AC until the start of your next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("98bf9a03-2844-432f-8d91-f819de5775d9"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
