using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RedHerring : Template
    {
        public static readonly Guid ID = Guid.Parse("053fe724-3d5a-48dc-ab15-7348d8792005");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Red Herring",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("47bc837a-74ae-4f94-b6a5-ebbe8a4a62e9"), Type = TextBlockType.Text, Text = "You have a keen sense for avoiding spurious lines of inquiry. When you (feat: Pursue a Lead), the GM tells you if the lead you chose is inconsequential. For example, if you found a splatter of gray mud on the wall, thought it was suspicious, and (feat: Pursued it as a Lead | Pursue a Lead), the GM would tell you if there was no greater mystery related to it. When the GM tells you a lead is inconsequential, you can decline to (feat: Pursue the Lead | Pursue a Lead), keeping any leads you were already pursuing. You still can&#39;t use (feat: Pursue a Lead) again for 10 minutes, as normal." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7f0511a7-81f1-492d-93e1-32e1af05be35"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
