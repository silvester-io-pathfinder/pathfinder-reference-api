using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CelebrityDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("bc059d24-b163-4061-b91a-8da944ebde44");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Celebrity Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the celebrity archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("862d8006-e364-4c91-bcd5-49e2b3dab4ae"), Type = TextBlockType.Text, Text = "The more people you have looking at you, the more content you are, and you take every opportunity to show up others when their performances are less than perfect. You gain the (feat: Upstage) reaction. In addition, when you (action: Earn Income), if the level of the task is higher than your level, you gain a +1 circumstance bonus to your check to (action: Earn Income)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0e78f119-9115-4649-b006-5a8d096efb6e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
