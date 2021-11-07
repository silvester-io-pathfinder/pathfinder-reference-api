using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StoryCrooner : Template
    {
        public static readonly Guid ID = Guid.Parse("cdcbe9bb-00b7-4f3b-b286-eff89a00b3d5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Story Crooner",
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
            yield return new TextBlock { Id = Guid.Parse("0947c422-a8bf-4e17-b503-775cf8523d8c"), Type = TextBlockType.Text, Text = "You’re a talented story weaver and use your voice effectively. You are trained in Performance. If you would automatically become trained in Performance, you instead become trained in a skill of your choice. You also gain the (feat: Impressive Performance) skill feat and gain a +1 circumstance bonus when (action: Performing | Perform) for an audience of strix." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ab8f595b-10eb-49ca-bcb9-831111fbe0d2"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
