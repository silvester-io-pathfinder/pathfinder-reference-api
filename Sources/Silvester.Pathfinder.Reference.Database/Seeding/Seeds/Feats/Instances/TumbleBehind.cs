using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TumbleBehind : Template
    {
        public static readonly Guid ID = Guid.Parse("f4c0c666-db2b-47a5-9ce0-49e95f0a4f46");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tumble Behind",
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
            yield return new TextBlock { Id = Guid.Parse("d113fdde-9ae3-485a-989c-0c3534d93a7d"), Type = TextBlockType.Text, Text = "You tumble under and behind your foe to catch them off guard. When you successfully (action: Tumble Through), the foe whose space you passed through is flat-footed against the next attack you make before the end of your turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4a585b0b-5536-4d32-8c41-355e32565324"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
