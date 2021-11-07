using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SlipTheGrasp : Template
    {
        public static readonly Guid ID = Guid.Parse("838c89ec-654e-41a9-a30d-bc1ee4c25029");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Slip the Grasp",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("19f47de5-c710-4e4a-b34b-8730209ecac7"), Type = TextBlockType.Text, Text = "You have some feature that allows you to quickly evade effects that restrain you. Attempt a check to (action: Escape). If you succeed, you can (action: Stride), (action: Step), or make a (action: Strike) with a melee unarmed attack targeting the creature you (action: Escaped | Escape) from. If you fail, you instead attempt to (action: Escape) a second time." };
            yield return new TextBlock { Id = Guid.Parse("d6f92811-2622-4963-8faf-7c6029dc3e84"), Type = TextBlockType.Text, Text = "You increase your multiple attack penalty as appropriate for the actions you took, but only after completing both actions." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e274d7a6-bd55-44e6-b0f7-f40781051c31"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
