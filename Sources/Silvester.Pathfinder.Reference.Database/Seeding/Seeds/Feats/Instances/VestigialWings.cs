using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VestigialWings : Template
    {
        public static readonly Guid ID = Guid.Parse("7d6acf39-884e-46c1-82da-69f0b9482096");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vestigial Wings",
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
            yield return new TextBlock { Id = Guid.Parse("2b28fc69-7424-4fe3-98b8-6b32d6ba84ec"), Type = TextBlockType.Text, Text = "You possess small, weak wings that aid in balance. You gain the (feat: Steady Balance) and (feat: Cat Fall) skill feats as bonus feats, even if you aren’t trained in Acrobatics." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f5f47083-6a4c-428a-a9f6-294121ee6a02"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
