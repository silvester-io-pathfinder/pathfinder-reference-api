using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StoneFace : Template
    {
        public static readonly Guid ID = Guid.Parse("775d130f-8570-464d-81f3-6ddfcfb7981f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Stone Face",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d9e3971d-c788-44a9-917e-004f6ffd8223"), Type = TextBlockType.Text, Text = "Through conditioning or experience, you’ve mastered the art of composure, even in the face of fear. You gain a +1 circumstance bonus to saves against effects with the (trait: fear) trait, and a +2 circumstance bonus to your Will DC against Intimidate skill actions, such as (action: Demoralize)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1cdb88c3-71e0-4ea1-9374-edc55102339c"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
