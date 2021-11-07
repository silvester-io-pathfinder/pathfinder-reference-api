using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AnchoringRoots : Template
    {
        public static readonly Guid ID = Guid.Parse("ca5b8f2e-7ef3-4bb4-b9da-81bbc6ba5907");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Anchoring Roots",
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
            yield return new TextBlock { Id = Guid.Parse("719b2708-ddd7-4085-9ef0-0e96c9591a35"), Type = TextBlockType.Text, Text = "Small roots sprout from your feet, steadying you as you move. You gain the (feat: Steady Balance) skill feat, even if you aren’t trained in Acrobatics, and you can use the (feat: Anchor) action." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0a78a1f3-0899-464f-9770-f2df783677a5"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
