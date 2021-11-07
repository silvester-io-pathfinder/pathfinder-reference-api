using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CallOfTheGreenMan : Template
    {
        public static readonly Guid ID = Guid.Parse("07c24b4b-0e8f-4e8a-8da9-04a4f882013a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Call of the Green Man",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("71cc12bc-7197-4984-87a7-4f1abb1d8cd8"), Type = TextBlockType.Text, Text = "You can call forth nearby nature spirits to augment your body. Once per day, you can cast (spell: plant form) as a 5th-level primal innate spell. When you reach 17th level, this spell can be heightened to 6th level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("42b75114-5684-476e-955c-1f93421f970f"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
