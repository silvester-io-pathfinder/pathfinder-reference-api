using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LightStep : Template
    {
        public static readonly Guid ID = Guid.Parse("23352a20-6692-4778-a048-d711da810482");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Light Step",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7efceb0b-4eec-4679-aafd-9e5a7e9b1af9"), Type = TextBlockType.Text, Text = "You aren’t bothered by tricky footing. When you (action: Stride) or (action: Step), you can ignore difficult terrain." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("532606f5-1ced-4728-a309-a1084255c3c8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
