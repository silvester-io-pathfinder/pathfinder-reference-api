using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Tusks : Template
    {
        public static readonly Guid ID = Guid.Parse("1b025693-2a88-4984-b3a5-c54099112d2d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tusks",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can take this feat only at 1st level, and you can't retrain into this feat. You can retrain out of this feat only through drastic measures such as breaking or filing your tusks.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("faa28b3f-5277-4aad-a9a7-0a8cf46bcd79"), Type = TextBlockType.Text, Text = "You have particularly long, jagged tusks perfect for tearing meat from bone. You gain a tusks unarmed attack that deals 1d6 piercing damage. Your tusks are in the brawling group and have the (trait: finesse) and (trait: unarmed) traits." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4960fb93-51a6-489f-b4b2-0d39bda1a33d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
