using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Brinesoul : Template
    {
        public static readonly Guid ID = Guid.Parse("bfd3e666-d9e3-4f2f-9562-dfd66c720094");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Brinesoul",
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
            yield return new TextBlock { Id = Guid.Parse("331a22cc-4b1e-4963-a142-70a39ca91e68"), Type = TextBlockType.Text, Text = "Your elemental ancestor’s legacy asserts itself as brackish water, like the seawater of the ocean. You gain the (feat: Salt Wound) reaction." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("611a2d97-9aa9-4ad8-82e8-51531c70c7e4"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
