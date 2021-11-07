using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Slither : Template
    {
        public static readonly Guid ID = Guid.Parse("8392485c-74c0-4edb-b5bb-3bce16d1141b");

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
            yield return new TextBlock { Id = Guid.Parse("3a0f67ad-2c10-405e-8ee1-df33d0b31cd6"), Type = TextBlockType.Text, Text = "You are an expert at moving through extremely tight spaces. You gain the (feat: Quick Squeeze) skill feat, even if you’re not trained in Acrobatics. When you roll a success on an Acrobatics check to (action: Squeeze), you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ac88bf05-ac80-4249-a8b6-190872ad7128"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
