using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GiftOfTheMoon : Template
    {
        public static readonly Guid ID = Guid.Parse("1119f519-e132-45a1-9699-137809e91e1c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gift of the Moon",
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
            yield return new TextBlock { Id = Guid.Parse("c21950a4-55d1-46f5-a077-f7f8c2db9b54"), Type = TextBlockType.Text, Text = "You can share your power with others, but they can’t escape the werecreature’s curse as easily as you can. You can cast a 5th-level (spell: moon frenzy) as a primal innate spell once per day. At 15th level, you cast a 6th-level (spell: moon frenzy) instead. At 17th level, your 6th-level (spell: moon frenzy) grants its standard effects, except the temporary Hit Points increase to 15 and the silver weakness increases to 15. At 20th level, you cast a 10th-level (spell: moon frenzy) instead. The spell uses your class DC or spell DC, whichever is higher." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("64f024a8-0e8e-4ef5-8ca8-5cb83941161c"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
