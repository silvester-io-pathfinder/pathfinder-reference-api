using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RedHerring : Template
    {
        public static readonly Guid ID = Guid.Parse("c6496719-5408-476d-a76a-c1b5f6b94dc3");

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
            yield return new TextBlock { Id = Guid.Parse("bef99abe-5e00-4dea-891b-db6d3a95c243"), Type = TextBlockType.Text, Text = "You have a keen sense for avoiding spurious lines of inquiry. When you (feat: Pursue a Lead), the GM tells you if the lead you chose is inconsequential. For example, if you found a splatter of gray mud on the wall, thought it was suspicious, and (feat: Pursued it as a Lead | Pursue a Lead), the GM would tell you if there was no greater mystery related to it. When the GM tells you a lead is inconsequential, you can decline to (feat: Pursue the Lead | Pursue a Lead), keeping any leads you were already pursuing. You still can't use (feat: Pursue a Lead) again for 10 minutes, as normal." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("43322875-bb51-4af2-bf3c-2680b0e73f67"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
