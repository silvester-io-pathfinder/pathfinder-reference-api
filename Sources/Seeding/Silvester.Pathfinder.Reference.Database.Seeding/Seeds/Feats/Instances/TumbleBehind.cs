using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TumbleBehind : Template
    {
        public static readonly Guid ID = Guid.Parse("42167ad0-bcd9-44d9-a525-2e30c3bfe728");

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
            yield return new TextBlock { Id = Guid.Parse("c55aa400-c6cd-48f5-9b99-f42dae0e0915"), Type = TextBlockType.Text, Text = "You tumble under and behind your foe to catch them off guard. When you successfully (action: Tumble Through), the foe whose space you passed through is flat-footed against the next attack you make before the end of your turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a0a22003-5676-4c11-a8e8-6c6db60ce2c4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
