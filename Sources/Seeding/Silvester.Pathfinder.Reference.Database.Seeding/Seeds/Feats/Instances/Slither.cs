using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Slither : Template
    {
        public static readonly Guid ID = Guid.Parse("087ff6f8-0e10-470c-a4bf-e459304e1488");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Slither",
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
            yield return new TextBlock { Id = Guid.Parse("d3bc6a71-510c-4cbf-88fa-1af5f306ce8a"), Type = TextBlockType.Text, Text = "You are an expert at moving through extremely tight spaces. You gain the (feat: Quick Squeeze) skill feat, even if you’re not trained in Acrobatics. When you roll a success on an Acrobatics check to (action: Squeeze), you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1f025fa5-cea7-44d9-bea2-ed8cdf3e2234"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
