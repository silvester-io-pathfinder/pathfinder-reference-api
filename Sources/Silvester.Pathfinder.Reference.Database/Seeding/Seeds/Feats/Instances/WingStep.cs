using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WingStep : Template
    {
        public static readonly Guid ID = Guid.Parse("412efeec-9ad9-4c48-b392-510e27dcf8b0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wing Step",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ad460225-b9a3-4316-8baf-cb1c662af7f6"), Type = TextBlockType.Text, Text = "With a sharp flap of your wings, you stay light on your feet as you move. You (action: Step) twice." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7f97bd1d-e7e1-4383-b2a3-bd011e5f9a92"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
