using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CityScavenger : Template
    {
        public static readonly Guid ID = Guid.Parse("3fb8eea3-fdf9-4fc0-9df6-811387a67e17");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "City Scavenger",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If you have the irongut goblin heritage, increase the bonuses to +2.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c68836fb-7545-4415-9489-8292ccf6e97d"), Type = TextBlockType.Text, Text = "You know that the greatest treasures often look like refuse, and you scoff at those who throw away perfectly good scraps. You gain a +1 circumstance bonus to checks to (action: Subsist), and you can use Society or Survival when you (action: Subsist) in a settlement." };
            yield return new TextBlock { Id = Guid.Parse("16a8bcc7-8ccc-4e8f-bca9-36aa416a0578"), Type = TextBlockType.Text, Text = "When you (action: Subsist) in a city, you also gather valuable junk that silly longshanks threw away. You can (action: Earn Income) using Society or Survival in the same time as you (action: Subsist), without spending any additional days of downtime. You also gain a +1 circumstance bonus to this check." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dba90d62-e961-4ecd-9fdd-65b01721822e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
