using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GiantSnare : Template
    {
        public static readonly Guid ID = Guid.Parse("80b8a098-6bf2-4d43-8133-ae1b7a7f285a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Giant Snare",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("57661b81-c750-4f1d-8856-6dc3d0fff685"), Type = TextBlockType.Text, Text = "You can create bigger snares for quick deployment, making it more likely for a creature to walk into your snares. When you prepare snares for quick deployment, you can prepare some of them as giant snares. A giant snare takes up a 10-foot-by-10-foot area but costs two of your quick deployment snares. A giant snare can trigger from a creature entering any portion of its area, and all its effects apply over the full area." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("90343182-10e9-464a-abb9-bec541aef987"), Feats.Instances.SnarecrafterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bc61c7ef-9cbb-4bff-a404-cbe38dc5b4ba"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
