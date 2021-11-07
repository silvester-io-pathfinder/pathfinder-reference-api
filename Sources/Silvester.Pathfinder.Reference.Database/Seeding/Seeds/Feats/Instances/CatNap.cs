using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CatNap : Template
    {
        public static readonly Guid ID = Guid.Parse("9274ed19-3bbf-450a-92b3-a75487273ad0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cat Nap",
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
            yield return new TextBlock { Id = Guid.Parse("5f43a5fe-491c-4607-bf40-94cf97b23f18"), Type = TextBlockType.Text, Text = "You can briefly sleep to regain your energy quickly. Once per hour, by sleeping for 10 minutes, you can gain temporary Hit Points equal to your level that last for 10 minutes." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9b4ac8c9-7c78-4509-ba40-63c056d862ad"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
